using System;
using System.IO;
using Workshop3.Exceptions;

namespace Workshop3.IO
{
    /// <summary>
    /// Represents a class that can read from a text file.
    /// </summary>
    public class TextFileReader
    {
        /// <summary>Represents the text file to read.</summary>
        private FileInfo file;

        /// <summary>
        /// The constructor accepts a file path as a parameter.
        /// If the file doesn't exist in the file system,
        /// a FileDoesNotExistException is thrown.
        /// </summary>
        /// <param name="fileName">The path to the file.</param>
        public TextFileReader(string fileName)
        {
            file = new FileInfo(fileName);
            if (!file.Exists)
                throw new FileDoesNotExistException($"The file {fileName} does not exist.", fileName);
        }

        /// <summary>
        /// This method reads the chosen text file,
        /// and returns its contents as a string.
        /// </summary>
        /// <returns>The contents of the text file.</returns>
        public string ReadFile()
        {
            string fileContents;
            using (StreamReader reader = new StreamReader(file.FullName))
            {
                fileContents = reader.ReadToEnd();
            }
            return fileContents;
        }
    }
}