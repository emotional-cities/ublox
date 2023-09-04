using System;
using System.ComponentModel;
using System.IO;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Bonsai;

namespace EmotionalCities.uBlox
{
    /// <summary>
    /// Represents an operator which produces an observable sequence of UBX messages from a previously recorded data file.
    /// </summary>
    [Description("Produces a sequence of UBX messages from a previously recorded data file.")]
    public class FileDevice : Source<UbxPacket>
    {
        readonly IObservable<UbxPacket> source;
        readonly object captureLock = new object();
        const int ReadBufferSize = 4096;

        /// <summary>
        /// Initializes a new instance of the <see cref="FileDevice"/> class.
        /// </summary>
        public FileDevice()
        {
            source = Observable.Create<UbxPacket>((observer, cancellationToken) =>
            {
                return Task.Factory.StartNew(() =>
                {
                    lock (captureLock)
                    {
                        using (var stream = new FileStream(FileName, FileMode.Open))
                        {
                            long bytesToRead;
                            var transport = new StreamTransport(observer);
                            while (!cancellationToken.IsCancellationRequested &&
                                   (bytesToRead = Math.Min(ReadBufferSize, stream.Length - stream.Position)) > 0)
                            {
                                transport.ReceiveData(stream, ReadBufferSize, (int)bytesToRead);
                            }
                        }
                    }
                },
                cancellationToken,
                TaskCreationOptions.LongRunning,
                TaskScheduler.Default);
            })
            .PublishReconnectable()
            .RefCount();
        }

        /// <summary>
        /// Gets or sets the path to the binary file containing UBX messages to playback.
        /// </summary>
        [Description("The path to the binary file containing UBX messages.")]
        [Editor("Bonsai.Design.OpenFileNameEditor, Bonsai.Design", DesignTypes.UITypeEditor)]
        public string FileName { get; set; }

        /// <summary>
        /// Opens the specified file name and returns the observable sequence of UBX messages
        /// stored in the binary file.
        /// </summary>
        /// <returns>The observable sequence of UBX messages stored in the binary file.</returns>
        public override IObservable<UbxPacket> Generate()
        {
            return source;
        }
    }
}
