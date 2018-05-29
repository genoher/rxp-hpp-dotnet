namespace Realexpayments.HPP.SDK
{
    using System;
    using System.Collections.Generic;

    [Serializable]
    public class RealexValidationException : RealexException
    {
        /// <summary>
        /// Gets the validation messages.
        /// </summary>
        /// <value>
        /// The validation messages.
        /// </value>
        public List<string> ValidationMessages { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealexValidationException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public RealexValidationException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealexValidationException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="validationMessages">The validation messages.</param>
        public RealexValidationException(string message, List<string> validationMessages)
            : base(message)
        {
            this.ValidationMessages = validationMessages;
        }
    }
}
