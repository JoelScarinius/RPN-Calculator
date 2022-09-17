using System;
using System.IO;

namespace Workshop3.IO
{
    /// <summary>
    /// Represents a class that can write to a text file.
    /// </summary>
    public class TextFileWriter
    {
        /// <summary>Represents the text file to write.</summary>
        private FileInfo file;

        /// <summary>
        /// The constructor accepts a file path as a parameter.
        /// If the directory in the chosen file path doesn't exist in
        /// the file system, a DirectoryNotFoundException is thrown.
        /// </summary>
        /// <param name="fileName"></param>
        public TextFileWriter(string fileName)
        {
            file = new FileInfo(fileName);
            if (file == null || !file.Directory.Exists)
                throw new DirectoryNotFoundException("The directory in the chosen file path does not exist.");
        }

        /// <summary>
        /// This method writes the supplied text to the text file.
        /// </summary>
        /// <param name="text">The text to write to the text file.</param>
        public void WriteFile(string text)
        {
            File.WriteAllText(file.FullName, text);
        }
    }
}