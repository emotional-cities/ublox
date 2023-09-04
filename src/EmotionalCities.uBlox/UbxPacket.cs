using System;

namespace EmotionalCities.uBlox
{
    /// <summary>
    /// Represents a single message in the UBX protocol.
    /// </summary>
    public class UbxPacket
    {
        internal const byte SyncChar1 = 0xB5;
        internal const byte SyncChar2 = 0x62;
        internal const int PayloadOffset = 6;
        const int ClassOffset = 2;

        /// <summary>
        /// Initializes a new instance of the <see cref="UbxPacket"/> class from
        /// the full binary representation of the UBX message.
        /// </summary>
        /// <param name="messageBytes">An array of bytes containing the full binary representation of the UBX message.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="messageBytes"/> is <c>null</c>.
        /// </exception>
        public UbxPacket(params byte[] messageBytes)
        {
            MessageBytes = messageBytes ?? throw new ArgumentNullException(nameof(messageBytes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UbxPacket"/> class from
        /// the full binary representation of the UBX message, and optionally updates
        /// the value of the checksum byte.
        /// </summary>
        /// <param name="updateChecksum">Indicates whether to compute and update the checksum byte.</param>
        /// <param name="messageBytes">An array of bytes containing the full binary representation of the UBX message.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="messageBytes"/> is <c>null</c>.
        /// </exception>
        public UbxPacket(bool updateChecksum, params byte[] messageBytes)
            : this(messageBytes)
        {
            if (updateChecksum)
            {
                var checksum = GetChecksum(messageBytes);
                messageBytes[messageBytes.Length - 2] = (byte)(checksum >> 1);
                messageBytes[messageBytes.Length - 1] = (byte)checksum;
            }
        }

        /// <summary>
        /// Gets the full binary representation of the UBX message.
        /// </summary>
        public byte[] MessageBytes { get; private set; }

        /// <summary>
        /// Gets a value specifying the class ID of the UBX message.
        /// </summary>
        public MessageClass MessageClass
        {
            get { return (MessageClass)MessageBytes[ClassOffset]; }
        }

        /// <summary>
        /// Gets a value specifying the ID of the UBX message.
        /// </summary>
        public MessageId MessageId
        {
            get { return (MessageId)((int)MessageClass << 8 | MessageBytes[ClassOffset + 1]); }
        }

        /// <summary>
        /// Gets the length of the payload, in bytes.
        /// </summary>
        public int PayloadLength
        {
            get { return MessageBytes.Length - PayloadOffset - 2; }
        }

        /// <summary>
        /// Gets the checksum bytes used for error detection in the UBX protocol.
        /// </summary>
        public ushort Checksum
        {
            get { return BitConverter.ToUInt16(MessageBytes, MessageBytes.Length - 2); }
        }

        internal static ushort GetChecksum(byte[] messageBytes)
        {
            byte checksumA = 0;
            byte checksumB = 0;
            for (int i = 2; i < messageBytes.Length - 2; i++)
            {
                checksumA += messageBytes[i];
                checksumB += checksumA;
            }
            return (ushort)(checksumA | checksumB << 8);
        }

        /// <summary>
        /// Gets the array segment containing the raw message payload. This method
        /// returns a view into the original array without copying any data.
        /// </summary>
        /// <returns>
        /// An <see cref="ArraySegment{T}"/> delimiting the message payload section
        /// of the message bytes.
        /// </returns>
        public ArraySegment<byte> GetPayload()
        {
            return new ArraySegment<byte>(MessageBytes, PayloadOffset, PayloadLength);
        }

        /// <summary>
        /// Returns the message payload as an array of non-pointer value types. The size of the
        /// type should be a multiple of the total size of the payload.
        /// </summary>
        /// <typeparam name="TArray">The type of the non-pointer values in the array.</typeparam>
        /// <returns>An array containing a copy of the message payload data.</returns>
        public unsafe TArray[] GetPayloadArray<TArray>() where TArray : unmanaged
        {
            var value = new TArray[PayloadLength / sizeof(TArray)];
            Buffer.BlockCopy(MessageBytes, PayloadOffset, value, 0, PayloadLength);
            return value;
        }

        /// <summary>
        /// Returns a <see cref="UbxPacket"/> with the specified ID and binary payload.
        /// </summary>
        /// <param name="messageId">The ID of the UBX message.</param>
        /// <param name="payload">The array containing the binary message payload data.</param>
        /// <returns>
        /// A <see cref="UbxPacket"/> instance with the specified ID and binary payload,
        /// including all necessary UBX headers and checksum.
        /// </returns>
        public static UbxPacket FromPayload(MessageId messageId, params byte[] payload)
        {
            var messageBytes = new byte[payload.Length + PayloadOffset + 2];
            messageBytes[0] = SyncChar1;
            messageBytes[1] = SyncChar2;
            messageBytes[2] = (byte)((int)messageId >> 8);
            messageBytes[3] = (byte)messageId;
            messageBytes[4] = (byte)payload.Length;
            messageBytes[5] = (byte)(payload.Length >> 8);
            Buffer.BlockCopy(payload, 0, messageBytes, PayloadOffset, payload.Length);
            return new UbxPacket(updateChecksum: true, messageBytes);
        }

        /// <summary>
        /// Returns a <see cref="string"/> that represents the UBX message ID and payload length.
        /// </summary>
        /// <returns>
        /// A formatted <see cref="string"/> representing the UBX message ID and payload length.
        /// </returns>
        public override string ToString()
        {
            return $"{MessageId} Length:{PayloadLength}";
        }
    }
}
