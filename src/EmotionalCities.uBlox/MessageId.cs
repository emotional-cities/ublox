namespace EmotionalCities.uBlox
{
    /// <summary>
    /// Specifies the ID of a UBX message.
    /// </summary>
    public enum MessageId : ushort
    {
        /// <summary>
        /// Message acknowledged (Output)
        /// </summary>
        ACK_ACK = MessageClass.ACK << 8 | 0x01,

        /// <summary>
        /// Message not acknowledged (Output)
        /// </summary>
        ACK_NAK = MessageClass.ACK << 8 | 0x00,

        /// <summary>
        /// Antenna control settings (Get/set)
        /// </summary>
        CFG_ANT = MessageClass.CFG << 8 | 0x13,

        /// <summary>
        /// Data batching configuration (Get/set)
        /// </summary>
        CFG_BATCH = MessageClass.CFG << 8 | 0x93,

        /// <summary>
        /// Clear, save and load configurations (Command)
        /// </summary>
        CFG_CFG = MessageClass.CFG << 8 | 0x09,

        /// <summary>
        /// User-defined datum (Get/set)
        /// </summary>
        CFG_DAT = MessageClass.CFG << 8 | 0x06,

        /// <summary>
        /// Geofencing configuration (Get/set)
        /// </summary>
        CFG_GEOFENCE = MessageClass.CFG << 8 | 0x69,

        /// <summary>
        /// GNSS system configuration (Get/set)
        /// </summary>
        CFG_GNSS = MessageClass.CFG << 8 | 0x3E,

        /// <summary>
        /// Information message configuration for one protocol (Get/set/poll request)
        /// </summary>
        CFG_INF = MessageClass.CFG << 8 | 0x02,

        /// <summary>
        /// Jamming/interference monitor configuration (Get/set)
        /// </summary>
        CFG_ITFM = MessageClass.CFG << 8 | 0x39,

        /// <summary>
        /// Data logger configuration (Get/set)
        /// </summary>
        CFG_LOGFILTER = MessageClass.CFG << 8 | 0x47,

        /// <summary>
        /// Message configuration and message rate (Get/set/poll request)
        /// </summary>
        CFG_MSG = MessageClass.CFG << 8 | 0x01,

        /// <summary>
        /// Navigation engine settings (Get/set)
        /// </summary>
        CFG_NAV5 = MessageClass.CFG << 8 | 0x24,

        /// <summary>
        /// Navigation engine expert settings (Get/set)
        /// </summary>
        CFG_NAVX5 = MessageClass.CFG << 8 | 0x23,

        /// <summary>
        /// Extended NMEA protocol configuration V1 (Get/set)
        /// </summary>
        CFG_NMEA = MessageClass.CFG << 8 | 0x17,

        /// <summary>
        /// Odometer, low-speed COG engine settings (Get/set)
        /// </summary>
        CFG_ODO = MessageClass.CFG << 8 | 0x1E,

        /// <summary>
        /// Extended power management configuration (Get/set)
        /// </summary>
        CFG_PM2 = MessageClass.CFG << 8 | 0x3B,

        /// <summary>
        /// Power mode setup (Get/set)
        /// </summary>
        CFG_PMS = MessageClass.CFG << 8 | 0x86,

        /// <summary>
        /// Port configuration for UART, USB, SPI or I2C (DDC) port (Get/set/poll request)
        /// </summary>
        CFG_PRT = MessageClass.CFG << 8 | 0x00,

        /// <summary>
        /// Put receiver in a defined power state (Set)
        /// </summary>
        CFG_PWR = MessageClass.CFG << 8 | 0x57,

        /// <summary>
        /// Navigation/measurement rate settings (Get/set)
        /// </summary>
        CFG_RATE = MessageClass.CFG << 8 | 0x08,

        /// <summary>
        /// Contents of remote inventory (Get/set)
        /// </summary>
        CFG_RINV = MessageClass.CFG << 8 | 0x34,

        /// <summary>
        /// Reset receiver / Clear backup data structures (Command)
        /// </summary>
        CFG_RST = MessageClass.CFG << 8 | 0x04,

        /// <summary>
        /// RXM configuration (Get/set)
        /// </summary>
        CFG_RXM = MessageClass.CFG << 8 | 0x11,

        /// <summary>
        /// SBAS configuration (Get/set)
        /// </summary>
        CFG_SBAS = MessageClass.CFG << 8 | 0x16,

        /// <summary>
        /// Time pulse parameters (Get/set)
        /// </summary>
        CFG_TP5 = MessageClass.CFG << 8 | 0x31,

        /// <summary>
        /// USB configuration (Get/set)
        /// </summary>
        CFG_USB = MessageClass.CFG << 8 | 0x1B,

        /// <summary>
        /// Delete configuration item values (with or without transaction) (Set)
        /// </summary>
        CFG_VALDEL = MessageClass.CFG << 8 | 0x8C,

        /// <summary>
        /// Get configuration items (Poll request)
        /// </summary>
        CFG_VALGET = MessageClass.CFG << 8 | 0x8B,

        /// <summary>
        /// Set configuration item values (with or without transaction) (Set)
        /// </summary>
        CFG_VALSET = MessageClass.CFG << 8 | 0x8A,

        /// <summary>
        /// IMU alignment information (Periodic/polled)
        /// </summary>
        ESF_ALG = MessageClass.ESF << 8 | 0x14,

        /// <summary>
        /// Vehicle dynamics information (Periodic/polled)
        /// </summary>
        ESF_INS = MessageClass.ESF << 8 | 0x15,

        /// <summary>
        /// External sensor fusion measurements (Input/output)
        /// </summary>
        ESF_MEAS = MessageClass.ESF << 8 | 0x02,

        /// <summary>
        /// Raw sensor measurements (Output)
        /// </summary>
        ESF_RAW = MessageClass.ESF << 8 | 0x03,

        /// <summary>
        /// External sensor fusion status (Periodic/polled)
        /// </summary>
        ESF_STATUS = MessageClass.ESF << 8 | 0x10,

        /// <summary>
        /// ASCII output with debug contents (Output)
        /// </summary>
        INF_DEBUG = MessageClass.INF << 8 | 0x04,

        /// <summary>
        /// ASCII output with error contents (Output)
        /// </summary>
        INF_ERROR = MessageClass.INF << 8 | 0x00,

        /// <summary>
        /// ASCII output with informational contents (Output)
        /// </summary>
        INF_NOTICE = MessageClass.INF << 8 | 0x02,

        /// <summary>
        /// ASCII output with test contents (Output)
        /// </summary>
        INF_TEST = MessageClass.INF << 8 | 0x03,

        /// <summary>
        /// ASCII output with warning contents (Output)
        /// </summary>
        INF_WARNING = MessageClass.INF << 8 | 0x01,

        /// <summary>
        /// Batched data (Polled)
        /// </summary>
        LOG_BATCH = MessageClass.LOG << 8 | 0x11,

        /// <summary>
        /// Create log file (Command)
        /// </summary>
        LOG_CREATE = MessageClass.LOG << 8 | 0x07,

        /// <summary>
        /// Erase logged data (Command)
        /// </summary>
        LOG_ERASE = MessageClass.LOG << 8 | 0x03,

        /// <summary>
        /// Find index of a log entry based on a given time (Input/output)
        /// </summary>
        LOG_FINDTIME = MessageClass.LOG << 8 | 0x0E,

        /// <summary>
        /// Poll for log information (Poll request/output)
        /// </summary>
        LOG_INFO = MessageClass.LOG << 8 | 0x08,

        /// <summary>
        /// Request log data (Command)
        /// </summary>
        LOG_RETRIEVE = MessageClass.LOG << 8 | 0x09,

        /// <summary>
        /// Request batch data (Command)
        /// </summary>
        LOG_RETRIEVEBATCH = MessageClass.LOG << 8 | 0x10,

        /// <summary>
        /// Position fix log entry (Output)
        /// </summary>
        LOG_RETRIEVEPOS = MessageClass.LOG << 8 | 0x0B,

        /// <summary>
        /// Odometer log entry (Output)
        /// </summary>
        LOG_RETRIEVEPOSEXTRA = MessageClass.LOG << 8 | 0x0F,

        /// <summary>
        /// Byte string log entry (Output)
        /// </summary>
        LOG_RETRIEVESTRING = MessageClass.LOG << 8 | 0x0D,

        /// <summary>
        /// Store arbitrary string in on-board flash (Command)
        /// </summary>
        LOG_STRING = MessageClass.LOG << 8 | 0x04,

        /// <summary>
        /// Multiple GNSS acknowledge message (Output)
        /// </summary>
        MGA_ACK = MessageClass.MGA << 8 | 0x60,

        /// <summary>
        /// Multiple GNSS AssistNow Offline assistance (Input)
        /// </summary>
        MGA_ANO = MessageClass.MGA << 8 | 0x20,

        /// <summary>
        /// BeiDou ephemeris, almanac, health, UTC, ionosphere assistance (Input)
        /// </summary>
        MGA_BDS = MessageClass.MGA << 8 | 0x03,
        
        /// <summary>
        /// Navigation database dump entry (Input/output/poll request)
        /// </summary>
        MGA_DBD = MessageClass.MGA << 8 | 0x80,
        
        /// <summary>
        /// Galileo ephemeris, almanac, GPS time offset, UTC assistance (Input)
        /// </summary>
        MGA_GAL = MessageClass.MGA << 8 | 0x02,
        
        /// <summary>
        /// GLONASS ephemeris, almanac, auxiliary time offset assistance (Input)
        /// </summary>
        MGA_GLO = MessageClass.MGA << 8 | 0x06,

        /// <summary>
        /// GPS ephemeris, almanac, health, UTC, ionosphere assistance (Input)
        /// </summary>
        MGA_GPS = MessageClass.MGA << 8 | 0x00,

        /// <summary>
        /// Initial position, time, clock drift, frequency, and earth orientation parameters assistance (Input)
        /// </summary>
        MGA_INI = MessageClass.MGA << 8 | 0x40,

        /// <summary>
        /// QZSS ephemeris, almanac, health assistance (Input)
        /// </summary>
        MGA_QZSS = MessageClass.MGA << 8 | 0x05,

        /// <summary>
        /// Data batching buffer status (Polled)
        /// </summary>
        MON_BATCH = MessageClass.MON << 8 | 0x32,

        /// <summary>
        /// Communication port information (Periodic/polled)
        /// </summary>
        MON_COMMS = MessageClass.MON << 8 | 0x36,

        /// <summary>
        /// Information message major GNSS selection (Polled)
        /// </summary>
        MON_GNSS = MessageClass.MON << 8 | 0x28,

        /// <summary>
        /// Hardware status (Periodic/polled)
        /// </summary>
        MON_HW = MessageClass.MON << 8 | 0x09,

        /// <summary>
        /// Extended hardware status (Periodic/polled)
        /// </summary>
        MON_HW2 = MessageClass.MON << 8 | 0x0b,

        /// <summary>
        /// I/O pin status (Periodic/polled)
        /// </summary>
        MON_HW3 = MessageClass.MON << 8 | 0x37,

        /// <summary>
        /// I/O system status (Periodic/polled)
        /// </summary>
        MON_IO = MessageClass.MON << 8 | 0x02,

        /// <summary>
        /// Message parse and process status (Periodic/polled)
        /// </summary>
        MON_MSGPP = MessageClass.MON << 8 | 0x06,

        /// <summary>
        /// Installed patches (Polled)
        /// </summary>
        MON_PATCH = MessageClass.MON << 8 | 0x27,

        /// <summary>
        /// RF information (Periodic/polled)
        /// </summary>
        MON_RF = MessageClass.MON << 8 | 0x38,

        /// <summary>
        /// Receiver buffer status (Periodic/polled)
        /// </summary>
        MON_RXBUF = MessageClass.MON << 8 | 0x07,

        /// <summary>
        /// Receiver status information (Output)
        /// </summary>
        MON_RXR = MessageClass.MON << 8 | 0x21,

        /// <summary>
        /// Signal characteristics (Periodic/polled)
        /// </summary>
        MON_SPAN = MessageClass.MON << 8 | 0x31,

        /// <summary>
        /// Transmitter buffer status (Periodic/polled)
        /// </summary>
        MON_TXBUF = MessageClass.MON << 8 | 0x08,

        /// <summary>
        /// Receiver and software version (Polled)
        /// </summary>
        MON_VER = MessageClass.MON << 8 | 0x04,

        /// <summary>
        /// Attitude solution (Periodic/polled)
        /// </summary>
        NAV_ATT = MessageClass.NAV << 8 | 0x05,

        /// <summary>
        /// Clock solution (Periodic/polled)
        /// </summary>
        NAV_CLOCK = MessageClass.NAV << 8 | 0x22,

        /// <summary>
        /// Covariance matrices (Periodic/polled)
        /// </summary>
        NAV_COV = MessageClass.NAV << 8 | 0x36,

        /// <summary>
        /// Dilution of precision (Periodic/polled)
        /// </summary>
        NAV_DOP = MessageClass.NAV << 8 | 0x04,

        /// <summary>
        /// Position error ellipse parameters (Periodic/polled)
        /// </summary>
        NAV_EELL = MessageClass.NAV << 8 | 0x3D,

        /// <summary>
        /// End of epoch (Periodic)
        /// </summary>
        NAV_EOE = MessageClass.NAV << 8 | 0x61,

        /// <summary>
        /// Geofencing status (Periodic/polled)
        /// </summary>
        NAV_GEOFENCE = MessageClass.NAV << 8 | 0x39,

        /// <summary>
        /// High precision position solution in ECEF (Periodic/polled)
        /// </summary>
        NAV_HPPOSECEF = MessageClass.NAV << 8 | 0x13,

        /// <summary>
        /// High precision geodetic position solution (Periodic/polled)
        /// </summary>
        NAV_HPPOSLLH = MessageClass.NAV << 8 | 0x14,

        /// <summary>
        /// Odometer solution (Periodic/polled)
        /// </summary>
        NAV_ODO = MessageClass.NAV << 8 | 0x09,

        /// <summary>
        /// GNSS orbit database info (Periodic/polled)
        /// </summary>
        NAV_ORB = MessageClass.NAV << 8 | 0x34,

        /// <summary>
        /// Position solution in ECEF (Periodic/polled)
        /// </summary>
        NAV_POSECEF = MessageClass.NAV << 8 | 0x01,

        /// <summary>
        /// Geodetic position solution (Periodic/polled)
        /// </summary>
        NAV_POSLLH = MessageClass.NAV << 8 | 0x02,

        /// <summary>
        /// Navigation position velocity attitude time solution (Periodic/polled)
        /// </summary>
        NAV_PVAT = MessageClass.NAV << 8 | 0x17,

        /// <summary>
        /// Navigation position velocity time solution (Periodic/polled)
        /// </summary>
        NAV_PVT = MessageClass.NAV << 8 | 0x07,

        /// <summary>
        /// Relative positioning information in NED frame (Periodic/polled)
        /// </summary>
        NAV_RELPOSNED = MessageClass.NAV << 8 | 0x3C,

        /// <summary>
        /// Reset odometer (Command)
        /// </summary>
        NAV_RESETODO = MessageClass.NAV << 8 | 0x10,

        /// <summary>
        /// Satellite information (Periodic/polled)
        /// </summary>
        NAV_SAT = MessageClass.NAV << 8 | 0x35,

        /// <summary>
        /// SBAS status data (Periodic/polled)
        /// </summary>
        NAV_SBAS = MessageClass.NAV << 8 | 0x32,

        /// <summary>
        /// Signal information (Periodic/polled)
        /// </summary>
        NAV_SIG = MessageClass.NAV << 8 | 0x43,

        /// <summary>
        /// QZSS L1S SLAS status data (Periodic/polled)
        /// </summary>
        NAV_SLAS = MessageClass.NAV << 8 | 0x42,

        /// <summary>
        /// Receiver navigation status (Periodic/polled)
        /// </summary>
        NAV_STATUS = MessageClass.NAV << 8 | 0x03,

        /// <summary>
        /// BeiDou time solution (Periodic/polled)
        /// </summary>
        NAV_TIMEBDS = MessageClass.NAV << 8 | 0x24,

        /// <summary>
        /// Galileo time solution (Periodic/polled)
        /// </summary>
        NAV_TIMEGAL = MessageClass.NAV << 8 | 0x25,

        /// <summary>
        /// GLONASS time solution (Periodic/polled)
        /// </summary>
        NAV_TIMEGLO = MessageClass.NAV << 8 | 0x23,

        /// <summary>
        /// GPS time solution (Periodic/polled)
        /// </summary>
        NAV_TIMEGPS = MessageClass.NAV << 8 | 0x20,

        /// <summary>
        /// Leap second event information (Periodic/polled)
        /// </summary>
        NAV_TIMELS = MessageClass.NAV << 8 | 0x26,

        /// <summary>
        /// QZSS time solution (Periodic/polled)
        /// </summary>
        NAV_TIMEQZSS = MessageClass.NAV << 8 | 0x27,

        /// <summary>
        /// UTC time solution (Periodic/polled)
        /// </summary>
        NAV_TIMEUTC = MessageClass.NAV << 8 | 0x21,

        /// <summary>
        /// Velocity solution in ECEF (Periodic/polled)
        /// </summary>
        NAV_VELECEF = MessageClass.NAV << 8 | 0x11,

        /// <summary>
        /// Velocity solution in NED frame (Periodic/polled)
        /// </summary>
        NAV_VELNED = MessageClass.NAV << 8 | 0x12,

        /// <summary>
        /// Differential correction input status (Output)
        /// </summary>
        RXM_COR = MessageClass.RXM << 8 | 0x34,

        /// <summary>
        /// Satellite measurements for RRLP (Periodic/polled)
        /// </summary>
        RXM_MEASX = MessageClass.RXM << 8 | 0x14,

        /// <summary>
        /// Power management request (Command)
        /// </summary>
        RXM_PMREQ = MessageClass.RXM << 8 | 0x41,

        /// <summary>
        /// Multi-GNSS raw measurements (Periodic/polled)
        /// </summary>
        RXM_RAWX = MessageClass.RXM << 8 | 0x15,

        /// <summary>
        /// Galileo SAR short-RLM or long-RLM report (Output)
        /// </summary>
        RXM_RLM = MessageClass.RXM << 8 | 0x59,

        /// <summary>
        /// RTCM input status (Output)
        /// </summary>
        RXM_RTCM = MessageClass.RXM << 8 | 0x32,

        /// <summary>
        /// SPARTN input status (Output)
        /// </summary>
        RXM_SPARTN = MessageClass.RXM << 8 | 0x33,

        /// <summary>
        /// Broadcast navigation data subframe (Output)
        /// </summary>
        RXM_SFRBX = MessageClass.RXM << 8 | 0x13,

        /// <summary>
        /// Signal security information (Periodic/polled)
        /// </summary>
        SEC_SIG = MessageClass.SEC << 8 | 0x09,

        /// <summary>
        /// Unique chip ID (Output)
        /// </summary>
        SEC_UNIQID = MessageClass.SEC << 8 | 0x03,

        /// <summary>
        /// Time mark data (Periodic/polled)
        /// </summary>
        TIM_TM2 = MessageClass.TIM << 8 | 0x03,

        /// <summary>
        /// Time pulse time data (Periodic/polled)
        /// </summary>
        TIM_TP = MessageClass.TIM << 8 | 0x01,

        /// <summary>
        /// Sourced time verification (Periodic/polled)
        /// </summary>
        TIM_VRFY = MessageClass.TIM << 8 | 0x06,

        /// <summary>
        /// Create, clear, or restore backup (Poll request/command/output)
        /// </summary>
        UPD_SOS = MessageClass.UPD << 8 | 0x14
    }
}
