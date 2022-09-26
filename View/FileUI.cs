using RPN_Calculator.Exceptions;

namespace RPN_Calculator.View
{
    public class FileUI : IUserInterface
    {
        /// <summary>Represents the text file to read.</summary>
        private FileInfo file;

        public StreamReader input;
        public StreamWriter output;

        private string inputFileName;
        private string outputFileName;

        public FileUI(string[] args)
        {
            inputFileName = args[0];
            outputFileName = args[1];

            file = new FileInfo(inputFileName);
            if (!file.Exists)
                throw new FileDoesNotExistException($"The file {inputFileName} does not exist.", inputFileName);
        }

        public void PrintResult(double result)
        {
            //Print to file
            using (StreamWriter sw = new StreamWriter(outputFileName))
            {
                sw.WriteLine(result);
            }
        }

        public string? ReadInput()
        {
            using (StreamReader sr = new StreamReader(inputFileName))
            {
                string line = sr.ReadLine();

                if (line != null)
                {
                    outputFileName = line;
                }
            }

            return outputFileName;
        }

        public void Dispose()
        {
            input.Dispose();
            output.Dispose();
        }








        /// <summary>
        /// The constructor accepts a file path as a parameter.
        /// If the file doesn't exist in the file system,
        /// a FileDoesNotExistException is thrown.
        /// </summary>
        /// <param name= "fileName" > The path to the file.</param>
        //public void TextFileReader(string fileName)
        //{
        //    file = new FileInfo(fileName);
        //    if (!file.Exists)
        //        throw new FileDoesNotExistException($"The file {fileName} does not exist.", fileName);
        //}

        /// <summary>
        /// This method reads the chosen text file,
        /// and returns its contents as a string.
        /// </summary>
        /// <returns>The contents of the text file.</returns>
        //public string ReadFile()
        //{
        //    string fileContents;
        //    using (StreamReader reader = new StreamReader(file.FullName))
        //    {
        //        fileContents = reader.ReadToEnd();
        //    }
        //    return fileContents;
        //}



    }
}
