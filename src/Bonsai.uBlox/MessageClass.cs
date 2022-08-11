namespace Bonsai.uBlox
{
    /// <summary>
    /// Specifies the class ID of a UBX message.
    /// </summary>
    public enum MessageClass : byte
    {
        /// <summary>
        /// Navigation Results: Position, Speed, Time, Acc, Heading, DOP, SVs used.
        /// </summary>
        NAV = 0x01,

        /// <summary>
        /// Receiver Manager Messages: Satellite Status, RTC Status.
        /// </summary>
        RXM = 0x02,

        /// <summary>
        /// Information Messages: Printf-Style Messages, with IDs such as Error, Warning, Notice.
        /// </summary>
        INF = 0x04,

        /// <summary>
        /// Ack/Nack Messages: as replies to CFG Input Messages.
        /// </summary>
        ACK = 0x05,

        /// <summary>
        /// Configuration Input Messages: Set Dynamic Model, Set DOP Mask, Set Baud Rate, etc.
        /// </summary>
        CFG = 0x06,

        /// <summary>
        /// Monitoring Messages: Comunication Status, CPU Load, Stack Usage, Task Status.
        /// </summary>
        MON = 0x0A,

        /// <summary>
        /// AssistNow Aiding Messages: Ephemeris, Almanac, other A-GPS data input.
        /// </summary>
        AID = 0x0B,

        /// <summary>
        /// Timing Messages: Timepulse Output, Timemark Results.
        /// </summary>
        TIM = 0x0D
    }
}
