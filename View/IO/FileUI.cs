using FileDoesNotExistException = RPN_Calculator.Exceptions.FileDoesNotExistException;

namespace RPN_Calculator.View.IO
{
    public class FileUI : IUserInterface
    {
        /// <summary>Represents the text file to read.</summary>

        public StreamReader input;
        public StreamWriter output;

        private string inputFileName;
        private string outputFileName;

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

        public void Dispose()
        {
            input.Dispose();
            output.Dispose();
        }
    }
}
