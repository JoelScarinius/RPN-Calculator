namespace RPN_Calculator.Model.Exceptions
{
    /// <summary>
    /// This class represents an exception that occurs if an invalid operation is found in the RPN expression
    /// </summary>
    public class InvalidOperationException : Exception
    {

        /// <summary>
        /// The constructor passes an error message to its super class.
        /// </summary>
        public InvalidOperationException()
            : base($"InvalidOperationException")
        { }
    }
}