namespace RPN_Calculator.View.IO
{
    /// <summary>
    /// This Class contains methods that is needed for the console user interface.
    /// The class also inherits method prototypes from IUserInterface
    /// </summary>

    public class ConsoleUI : IUserInterface
    {

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
