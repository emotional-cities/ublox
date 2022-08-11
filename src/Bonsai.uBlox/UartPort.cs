namespace Bonsai.uBlox
{
    /// <summary>
    /// Specifies the UART port identifier number.
    /// </summary>
    public enum UartPort : byte
    {
        /// <summary>
        /// UART protocol over I2C.
        /// </summary>
        I2C = 0,

        /// <summary>
        /// UART port 1.
        /// </summary>
        Uart1 = 1,

        /// <summary>
        /// UART port 2.
        /// </summary>
        Uart2 = 2,

        /// <summary>
        /// UART over USB transport.
        /// </summary>
        Usb = 3,

        /// <summary>
        /// UART protocol over SPI.
        /// </summary>
        Spi = 4
    }
}
