using System;
using System.ComponentModel;
using System.IO.Ports;
using System.Reactive.Linq;
using Bonsai;

namespace EmotionalCities.uBlox
{
    /// <summary>
    /// Represents an operator that creates a connection to the UBX device at the specified serial port.
    /// </summary>
    [Description("Creates a connection to the UBX device at the specified serial port.")]
    public class Device : Source<UbxPacket>
    {
        /// <summary>
        /// Gets or sets the name of the serial port used to communicate with the UBX device.
        /// </summary>
        [TypeConverter(typeof(PortNameConverter))]
        [Description("The name of the serial port used to communicate with the UBX device.")]
        public string PortName { get; set; }

        /// <summary>
        /// Creates a connection to the UBX device at the specified serial port and
        /// returns an observable sequence of messages streaming from the device.
        /// </summary>
        /// <returns>
        /// The sequence of <see cref="UbxPacket"/> messages transmitted by the device.
        /// </returns>
        public override IObservable<UbxPacket> Generate()
        {
            return Observable.Create<UbxPacket>(observer =>
            {
                var transport = new SerialTransport(PortName, observer);
                transport.IgnoreErrors = true;
                transport.Open();

                var baudRate = 9600;
                var configurePort = UbxRequest.ConfigurePort(UartPort.Uart1, baudRate, PortInputProtocols.Ubx, PortOutputProtocols.Ubx);
                transport.Write(configurePort);
                return transport;
            });
        }

        class PortNameConverter : StringConverter
        {
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
            {
                return true;
            }

            public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                return new StandardValuesCollection(SerialPort.GetPortNames());
            }
        }
    }
}
