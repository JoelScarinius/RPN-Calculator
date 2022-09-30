namespace RPN_Calculator.Model.Exceptions
{
    /// <summary>
    /// This class represents an exception that occurs if an invalid token is found in the RPN expression
    /// </summary>
    public class InvalidTokenException : Exception
    {
        /// <summary>
        /// The constructor accepts an error message as parameter and pass the message to the super class.
        /// </summary>
        /// <param name="message">The error message.</param>

        public InvalidTokenException(string message)
            : base($"InvalidTokenException: {message}")
        { }
    }
}