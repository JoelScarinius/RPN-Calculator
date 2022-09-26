﻿namespace RPN_Calculator.Exceptions
{
    /// <summary>
    /// This class represents an exception for a file that doesn't exists in the file system.
    /// </summary>
    public class InvalidOperationException : Exception
    {
        /// <summary>The name of the file.</summary>

        /// <summary>
        /// The constructor accepts an error message and a file name as parameters.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="operand1">The operand1 that is not allowed to be zero.</param>

        public InvalidOperationException(string message)
            : base($"InvalidOperationException: {message}")
        {
            //Console.Write($"InvalidOperationException: {message}");
        }
    }
}