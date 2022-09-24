using System;

namespace Workshop3.Exceptions
{
    /// <summary>
    /// This class represents an exception for a file that doesn't exists in the file system.
    /// </summary>
    public class DivideByZeroException : Exception
    {
        /// <summary>The name of the file.</summary>
        public double Operand2 { get; private set; }

        /// <summary>
        /// The constructor accepts an error message and a file name as parameters.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="operand1">The operand1 that is not allowed to be zero.</param>
        public DivideByZeroException(string message, double operand2)
            : base(message)
        {
            Operand2 = operand2;
        }
    }
}