using System;
using System.IO;

namespace Bonsai.uBlox
{
    class StreamTransport
    {
        IObserver<UbxPacket> observer;
        BufferedStream bufferedStream;
        byte[] currentMessage;
        int currentOffset;
        bool pendingMessage;
        int classId;
        int messageId;

        public StreamTransport(IObserver<UbxPacket> observer)
        {
            SetObserver(observer);
        }

        public bool IgnoreErrors { get; set; }

        internal void SetObserver(IObserver<UbxPacket> observer)
        {
            this.observer = observer ?? throw new ArgumentNullException(nameof(observer));
        }

        internal void ReceiveData(Stream stream, int readBufferSize, int bytesToRead)
        {
            try
            {
                bufferedStream = bufferedStream ?? new BufferedStream(stream, readBufferSize);
                bufferedStream.PushBytes(bytesToRead);

                while (bytesToRead > 0)
                {
                    // There is a current packet
                    if (currentMessage != null)
                    {
                        var remaining = Math.Min(currentMessage.Length - currentOffset, bytesToRead);
                        var bytesRead = bufferedStream.Read(currentMessage, currentOffset, remaining);

                        currentOffset += bytesRead;
                        bytesToRead -= bytesRead;

                        // If our packet is complete
                        if (currentOffset >= currentMessage.Length)
                        {
                            // If checksum is valid, emit packet
                            var checksum = currentMessage[currentMessage.Length - 2] |
                                           currentMessage[currentMessage.Length - 1] << 8;
                            if (checksum == UbxPacket.GetChecksum(currentMessage))
                            {
                                var packet = new UbxPacket(currentMessage);
                                observer.OnNext(packet);
                            }
                            else if (!IgnoreErrors)
                            {
                                var errorMessage = "Unable to parse UBX packet";
                                errorMessage += "(" + DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo) + ")!";
                                errorMessage += "\nRaw message bytes: ";
                                errorMessage += BitConverter.ToString(currentMessage).Replace("-", ":");
                                throw new UbxException(errorMessage);
                            }
                            else
                            {
                                var offset = currentMessage.Length - 1;
                                bufferedStream.Seek(-offset);
                                bytesToRead += offset;
                            }
                            currentMessage = null;
                            currentOffset = 0;
                            classId = 0;
                            messageId = 0;
                            pendingMessage = false;
                        }
                    }
                    // Read packet length and allocate
                    else if (classId > 0)
                    {
                        var length1 = bufferedStream.ReadByte();
                        var length2 = bufferedStream.ReadByte();
                        var payloadLength = length1 | length2 << 8;
                        if (payloadLength > 0)
                        {
                            currentMessage = new byte[UbxPacket.PayloadOffset + payloadLength + 2];
                            currentMessage[0] = UbxPacket.SyncChar1;
                            currentMessage[1] = UbxPacket.SyncChar2;
                            currentMessage[2] = (byte)classId;
                            currentMessage[3] = (byte)messageId;
                            currentMessage[4] = (byte)length1;
                            currentMessage[5] = (byte)length2;
                            currentOffset = 6;
                        }
                        else
                        {
                            classId = 0;
                            messageId = 0;
                            pendingMessage = false;
                        }
                        bytesToRead -= 2;
                    }
                    // Read packet message ID
                    else if (pendingMessage)
                    {
                        if (bufferedStream.ReadByte() == UbxPacket.SyncChar2)
                        {
                            classId = bufferedStream.ReadByte();
                            messageId = bufferedStream.ReadByte();
                            bytesToRead -= 2;
                        }
                        else pendingMessage = false;
                        bytesToRead--;
                    }
                    // Check for a new packet
                    else
                    {
                        pendingMessage = bufferedStream.ReadByte() == UbxPacket.SyncChar1;
                        bytesToRead--;
                    }
                }
            }
            catch (Exception ex)
            {
                observer.OnError(ex);
            }
        }
    }
}
