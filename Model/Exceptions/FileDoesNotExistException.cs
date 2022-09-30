namespace RPN_Calculator.Exceptions
{
    /// <summary>
    /// This class represents an exception for when a file doesn't exists in the file system.
    /// </summary>
    public class FileDoesNotExistException : Exception
    {
        /// <summary>The name of the file.</summary>
        public string FileName { get; private set; }

        /// <summary>
        /// The constructor accepts an error message and a file name as parameters.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="fileName">The name of the file.</param>
        public FileDoesNotExistException(string message, string fileName)
            : base(message)
        {
            FileName = fileName;
        }
    }
}