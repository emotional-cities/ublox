namespace Bonsai.uBlox
{
    /// <summary>
    /// Specifies the class ID of a UBX message.
    /// </summary>
    public enum MessageClass : byte
    {
        /// <summary>
        /// Navigation solution messages: Position, Speed, Time, Acc, Heading, DOP, SVs used
        /// </summary>
        NAV = 0x01,

        /// <summary>
        /// Receiver manager messages: Satellite Status, RTC Status
        /// </summary>
        RXM = 0x02,

        /// <summary>
        /// Information messages: Printf-Style Messages, with IDs such as Error, Warning, Notice
        /// </summary>
        INF = 0x04,

        /// <summary>
        /// Acknowledgement and negative acknowledgement messages
        /// </summary>
        ACK = 0x05,

        /// <summary>
        /// Configuration and command messages: Set Dynamic Model, Set DOP Mask, Set Baud Rate, etc.
        /// </summary>
        CFG = 0x06,

        /// <summary>
        /// External sensor fusion messages
        /// </summary>
        ESF = 0x10,

        /// <summary>
        /// Firmware update messages
        /// </summary>
        UPD = 0x09,

        /// <summary>
        /// Monitoring messages: Comunication Status, CPU Load, Stack Usage, Task Status
        /// </summary>
        MON = 0x0A,

        /// <summary>
        /// AssistNow aiding messages: Ephemeris, Almanac, other A-GPS data input
        /// </summary>
        AID = 0x0B,

        /// <summary>
        /// Timing messages: Timepulse Output, Timemark Results
        /// </summary>
        TIM = 0x0D,

        /// <summary>
        /// GNSS Assistance (A-GNSS) messages
        /// </summary>
        MGA = 0x13,

        /// <summary>
        /// Logging messages
        /// </summary>
        LOG = 0x21,

        /// <summary>
        /// Security messages
        /// </summary>
        SEC = 0x27
    }
}
