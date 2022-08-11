﻿using System;
using System.Runtime.Serialization;

namespace Bonsai.uBlox
{
    /// <summary>
    /// Represents errors that are reported by UBX devices at runtime.
    /// </summary>
    [Serializable]
    public sealed class UbxException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UbxException"/> class.
        /// </summary>
        public UbxException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UbxException"/> class with
        /// a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public UbxException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UbxException"/> class with
        /// a specified error message and a reference to the inner exception that is the
        /// cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">
        /// The exception that is the cause of the current exception, or a null reference
        /// (Nothing in Visual Basic) if no inner exception is specified.
        /// </param>
        public UbxException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        private UbxException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
