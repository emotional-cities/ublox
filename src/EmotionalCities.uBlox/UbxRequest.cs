namespace EmotionalCities.uBlox
{
    internal static class UbxRequest
    {
        public static UbxPacket ConfigurePort(
            UartPort port,
            int baudRate,
            PortInputProtocols inputProtocols,
            PortOutputProtocols outputProtocols)
        {
            var uartMode = UartMode.EightBit | UartMode.OneStopBit | UartMode.NoParity;
            return UbxPacket.FromPayload(
                MessageId.CFG_PRT,
                (byte)port,
                0, 0, 0, // reserved
                (byte)uartMode,
                (byte)((uint)uartMode >> 8),
                (byte)((uint)uartMode >> 16),
                (byte)((uint)uartMode >> 24),
                (byte)baudRate,
                (byte)(baudRate >> 8),
                (byte)(baudRate >> 16),
                (byte)(baudRate >> 24),
                (byte)inputProtocols,
                (byte)((ushort)inputProtocols >> 8),
                (byte)outputProtocols,
                (byte)((ushort)outputProtocols >> 8),
                0, 0, 0, 0); // reserved
        }

        public static UbxPacket ConfigureMessageRate(MessageId messageId, int i2c, int uart1, int uart2, int usb, int spi)
        {
            return UbxPacket.FromPayload(
                MessageId.CFG_MSG,
                (byte)((int)messageId >> 8),
                (byte)messageId,
                (byte)i2c,
                (byte)uart1,
                (byte)uart2,
                (byte)usb,
                (byte)spi,
                0);
        }
    }
}
