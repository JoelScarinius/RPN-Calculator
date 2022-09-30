namespace RPN_Calculator.Exceptions
{
    /// <summary>
    /// This class represents an exception that occurs when the user tries to divide any number by zero.
    /// </summary>
    public class DivideByZeroException : Exception
    {
        /// <summary>
        /// The constructor accepts an error message as parameter.
        /// </summary>
        /// <param name="message">The error message.</param>
        public DivideByZeroException(string message)
            : base($"Not possible to divide by zero: {message}")
        { }
    }
}