using System;

namespace Kandy.Exceptions
{
    /// <summary>
    /// Base KandyException
    /// </summary>
    public class KandyException : Exception
    {
        /// <summary>
        /// Create an empty KandyException
        /// </summary>
        public KandyException() { }

        /// <summary>
        /// Create a KandyException from an error message
        /// </summary>
        /// <param name="message">Error message</param>
        public KandyException(string message) : base(message) { }

        /// <summary>
        /// Create a KandyException from message and another exception
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="exception">Original Exception</param>
        public KandyException(string message, Exception exception) : base(message, exception) { }
    }

    /// <summary>
    /// Exception related to connection errors
    /// </summary>
    public class ApiConnectionException : KandyException
    {
        /// <summary>
        /// Create an ApiConnectionException from a message
        /// </summary>
        /// <param name="message">Error message</param>
        public ApiConnectionException(string message) : base(message) { }

        /// <summary>
        /// Create an ApiConnectionException from a message and another Exception
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="exception">Original Exception</param>
        public ApiConnectionException(string message, Exception exception) : base(message, exception) { }
    }

    /// <summary>
    /// Exception related to Authentication Errors
    /// </summary>
    public class AuthenticationException : KandyException
    {
        /// <summary>
        /// Create AuthenticationException from an error messsage
        /// </summary>
        /// <param name="message">Error message</param>
        public AuthenticationException(string message) : base(message) { }
    }
}
