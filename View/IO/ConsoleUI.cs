namespace RPN_Calculator.View.IO
{
    public class ConsoleUI : IUserInterface
    {
        // Ha kvar?
        //private TextReader input;
        //private TextWriter output;

        public ConsoleUI(string[] args) { }

        public void PrintResult(double result)
        {
            Console.WriteLine($"Result: {result:f}");
            DisplayPause();
        }

        public void PrintResult(string result)
        {
            Console.WriteLine($"{result}");
            DisplayPause();
        }

        private void DisplayStartMessage()
        {
            Console.Write("Enter RPN-expression <return> (empty string = exit): ");
        }

        public string? ReadInput()
        {
            Console.Clear();
            DisplayStartMessage();
            return Console.ReadLine();
        }

        private void DisplayPause()
        {
            Console.WriteLine("Press <Enter> to continue...");
            Console.ReadLine();
        }

        public void Dispose()
        {
            Console.WriteLine("\nThe user exited the application");
        }
    }
}
