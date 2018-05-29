namespace Realexpayments.HPP.SDK
{
    using System;

    /// <summary>
    ///  An exception class for general Realex SDK errors. All other SDK exceptions will extend this class.
    /// </summary>
    /// <seealso cref="System.Exception" />
    [Serializable]
    public class RealexException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RealexException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public RealexException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealexException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public RealexException(string message, Exception innerException)
           : base(message, innerException)
        {
        }
    }
}
