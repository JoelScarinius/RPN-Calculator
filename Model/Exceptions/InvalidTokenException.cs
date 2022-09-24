﻿namespace RPN_Calculator.Exceptions
{
    /// <summary>
    /// This class represents an exception for a file that doesn't exists in the file system.
    /// </summary>
    public class InvalidTokenException : Exception
    {
        /// <summary>The name of the file.</summary>
        //public string InvalidToken { get; private set; }

        /// <summary>
        /// The constructor accepts an error message and a file name as parameters.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="operand1">The operand1 that is not allowed to be zero.</param>
        public InvalidTokenException(string message)
            : base(message) { }
        //public InvalidTokenException(string message, string invalidToken)
        //    : base(message)
        //{
        //    InvalidToken = invalidToken;
        //}
    }
}