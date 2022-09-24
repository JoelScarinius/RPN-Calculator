namespace RPN_Calculator.Exceptions
{
    /// <summary>
    /// This class represents an exception that occurs when the user tries to divide any number by zero.
    /// </summary>
    public class Exception : SystemException
    {
        /// <summary>The name of the file.</summary>
        public string Message { get; private set; }

        /// <summary>
        /// The constructor accepts an error message and a file name as parameters.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="operand1">The operand1 that is not allowed to be zero.</param>
        public Exception(string message)
        {
            Message = message;
        }
    }
}