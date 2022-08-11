namespace Bonsai.uBlox
{
    /// <summary>
    /// Specifies the ID of a UBX message.
    /// </summary>
    public enum MessageId : ushort
    {
        /// <summary>
        /// Message Acknowledged.
        /// </summary>
        ACK_ACK = MessageClass.ACK << 8 | 0x01,

        /// <summary>
        /// Message Not-Acknowledged.
        /// </summary>
        ACK_NAK = MessageClass.ACK << 8 | 0x00,

        /// <summary>
        /// Poll GPS Aiding Almanach Data.
        /// </summary>
        AID_ALM = MessageClass.AID << 8 | 0x30,

        /// <summary>
        /// ALP client requests or sends AlmanacPlus data from server.
        /// </summary>
        AID_ALPSRV = MessageClass.AID << 8 | 0x32,

        /// <summary>
        /// ALP file data transfer to the receiver.
        /// </summary>
        AID_ALP = MessageClass.AID << 8 | 0x50,

        /// <summary>
        /// Polls all GPS Initial Aiding Data.
        /// </summary>
        AID_DATA = MessageClass.AID << 8 | 0x10,

        /// <summary>
        /// Poll GPS Aiding Ephemeris Data.
        /// </summary>
        AID_EPH = MessageClass.AID << 8 | 0x31,

        /// <summary>
        /// Poll GPS Health, UTC and ionosphere parameters.
        /// </summary>
        AID_HUI = MessageClass.AID << 8 | 0x02,

        /// <summary>
        /// Poll GPS Initial Aiding Data: position, time, frequency, clock drift.
        /// </summary>
        AID_INI = MessageClass.AID << 8 | 0x01,

        /// <summary>
        /// Sends a poll (AID-DATA) for all GPS Aiding Data.
        /// </summary>
        AID_REQ = MessageClass.AID << 8 | 0x00,

        /// <summary>
        /// Poll Antenna Control Settings.
        /// </summary>
        CFG_ANT = MessageClass.CFG << 8 | 0x13,

        /// <summary>
        /// Clear, Save and Load configurations.
        /// </summary>
        CFG_CFG = MessageClass.CFG << 8 | 0x09,

        /// <summary>
        /// Poll Datum Setting.
        /// </summary>
        CFG_DAT = MessageClass.CFG << 8 | 0x06,

        /// <summary>
        /// Poll INF message configuration for one protocol.
        /// </summary>
        CFG_INF = MessageClass.CFG << 8 | 0x02,

        /// <summary>
        /// Poll a message configuration.
        /// </summary>
        CFG_MSG = MessageClass.CFG << 8 | 0x01,

        /// <summary>
        /// Poll Navigation Engine Settings.
        /// </summary>
        CFG_NAV5 = MessageClass.CFG << 8 | 0x24,

        /// <summary>
        /// Poll Navigation Engine Expert Settings.
        /// </summary>
        CFG_NAVX5 = MessageClass.CFG << 8 | 0x23,

        /// <summary>
        /// Poll the NMEA protocol configuration.
        /// </summary>
        CFG_NMEA = MessageClass.CFG << 8 | 0x17,

        /// <summary>
        /// Poll the configuration of the used I/O Port.
        /// </summary>
        CFG_PRT = MessageClass.CFG << 8 | 0x00,

        /// <summary>
        /// Poll Navigation/Measurement Rate Settings.
        /// </summary>
        CFG_RATE = MessageClass.CFG << 8 | 0x08,

        /// <summary>
        /// Reset Receiver / Clear Backup Data Structures.
        /// </summary>
        CFG_RST = MessageClass.CFG << 8 | 0x04,

        /// <summary>
        /// RXM configuration.
        /// </summary>
        CFG_RXM = MessageClass.CFG << 8 | 0x11,

        /// <summary>
        /// SBAS configuration.
        /// </summary>
        CFG_SBAS = MessageClass.CFG << 8 | 0x16,

        /// <summary>
        /// Poll Time Mode Settings.
        /// </summary>
        CFG_TMODE = MessageClass.CFG << 8 | 0x1D,

        /// <summary>
        /// Poll TimePulse Parameters.
        /// </summary>
        CFG_TP = MessageClass.CFG << 8 | 0x07,

        /// <summary>
        /// Poll a USB configuration.
        /// </summary>
        CFG_USB = MessageClass.CFG << 8 | 0x1B,

        /// <summary>
        /// ASCII String output, indicating debug output.
        /// </summary>
        INF_DEBUG = MessageClass.INF << 8 | 0x04,

        /// <summary>
        /// ASCII String output, indicating an error.
        /// </summary>
        INF_ERROR = MessageClass.INF << 8 | 0x00,

        /// <summary>
        /// ASCII String output, with informational contents.
        /// </summary>
        INF_NOTICE = MessageClass.INF << 8 | 0x02,

        /// <summary>
        /// ASCII String output, indicating test output.
        /// </summary>
        INF_TEST = MessageClass.INF << 8 | 0x03,

        /// <summary>
        /// ASCII String output, indicating a warning.
        /// </summary>
        INF_WARNING = MessageClass.INF << 8 | 0x01,

        /// <summary>
        /// Hardware Status.
        /// </summary>
        MON_HW = MessageClass.MON << 8 | 0x09,

        /// <summary>
        /// I/O Subsystem Status.
        /// </summary>
        MON_IO = MessageClass.MON << 8 | 0x02,

        /// <summary>
        /// Message Parse and Process Status.
        /// </summary>
        MON_MSGPP = MessageClass.MON << 8 | 0x06,

        /// <summary>
        /// Receiver Buffer Status.
        /// </summary>
        MON_RXBUF = MessageClass.MON << 8 | 0x07,

        /// <summary>
        /// Transmitter Buffer Status.
        /// </summary>
        MON_TXBUF = MessageClass.MON << 8 | 0x08,

        /// <summary>
        /// Receiver/Software Version.
        /// </summary>
        MON_VER = MessageClass.MON << 8 | 0x04,

        /// <summary>
        /// Clock Solution.
        /// </summary>
        NAV_CLOCK = MessageClass.NAV << 8 | 0x22,

        /// <summary>
        /// Dilution of precision.
        /// </summary>
        NAV_DOP = MessageClass.NAV << 8 | 0x04,

        /// <summary>
        /// Position Solution in ECEF.
        /// </summary>
        NAV_POSECEF = MessageClass.NAV << 8 | 0x01,

        /// <summary>
        /// Geodetic Position Solution.
        /// </summary>
        NAV_POSLLH = MessageClass.NAV << 8 | 0x02,

        /// <summary>
        /// SBAS Status Data.
        /// </summary>
        NAV_SBAS = MessageClass.NAV << 8 | 0x32,

        /// <summary>
        /// Navigation Solution Information.
        /// </summary>
        NAV_SOL = MessageClass.NAV << 8 | 0x06,

        /// <summary>
        /// Receiver Navigation Status.
        /// </summary>
        NAV_STATUS = MessageClass.NAV << 8 | 0x03,

        /// <summary>
        /// Space Vehicle Information.
        /// </summary>
        NAV_SVINFO = MessageClass.NAV << 8 | 0x30,

        /// <summary>
        /// GPS Time Solution.
        /// </summary>
        NAV_TIMEGPS = MessageClass.NAV << 8 | 0x20,

        /// <summary>
        /// UTC Time Solution.
        /// </summary>
        NAV_TIMEUTC = MessageClass.NAV << 8 | 0x21,

        /// <summary>
        /// Velocity Solution in ECEF.
        /// </summary>
        NAV_VELECEF = MessageClass.NAV << 8 | 0x11,

        /// <summary>
        /// Velocity Solution in NED.
        /// </summary>
        NAV_VELNED = MessageClass.NAV << 8 | 0x12,

        /// <summary>
        /// SV Status Info.
        /// </summary>
        RXM_SVSI = MessageClass.RXM << 8 | 0x20,

        /// <summary>
        /// Survey-in data.
        /// </summary>
        TIM_SVIN = MessageClass.TIM << 8 | 0x04,

        /// <summary>
        /// Time mark data.
        /// </summary>
        TIM_TM2 = MessageClass.TIM << 8 | 0x03,

        /// <summary>
        /// Timepulse Timedata.
        /// </summary>
        TIM_TP = MessageClass.TIM << 8 | 0x01
    }
}
