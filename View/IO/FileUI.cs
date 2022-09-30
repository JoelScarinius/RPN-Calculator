using FileDoesNotExistException = RPN_Calculator.Exceptions.FileDoesNotExistException;

namespace RPN_Calculator.View.IO
{
    /// <summary>
    /// This class contains all methods and attributes needed for writing to 
    /// and reading to a file. 
    /// The class also inherits method prototypes from IUserInterface
    /// </summary>

    public class FileUI : IUserInterface
    {

        public StreamReader input;
        public StreamWriter output;

        private string inputFileName;
        private string outputFileName;

        /// <summary>
        /// This constructor opens a input file to read from 
        /// and creates an output file to write to.
        /// </summary>

        public FileUI(string[] args)
        {
            inputFileName = args[0];
            outputFileName = args[1];

            FileInfo file = new FileInfo(inputFileName);

            if (!file.Exists)
                throw new FileDoesNotExistException($"The file {inputFileName} does not exist.", inputFileName);

            input = file.OpenText();
            output = new FileInfo(outputFileName).CreateText();
        }

        public void PrintResult(double result)
        {
            // Print to file
            output.WriteLine($"{result:f}");
        }

        public void PrintResult(string result)
        {
            // Print to file
            output.WriteLine(result);
        }

        public string? ReadInput()
        {
            // Read from file
            string? line = input.ReadLine();
            return line;
        }

        /// <summary>
        /// This Method is used to close the opened files.
        /// </summary>

        public void Dispose()
        {
            input.Dispose();
            output.Dispose();
        }
    }
}
