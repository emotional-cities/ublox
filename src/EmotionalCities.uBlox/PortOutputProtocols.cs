using System;

namespace EmotionalCities.uBlox
{
    /// <summary>
    /// Specifies which output protocols are active in a specified UART port.
    /// </summary>
    [Flags]
    public enum PortOutputProtocols : ushort
    {
        /// <summary>
        /// The UBX protocol.
        /// </summary>
        Ubx = 0x1,

        /// <summary>
        /// The NMEA protocol.
        /// </summary>
        Nmea = 0x2
    }
}
