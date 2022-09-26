
namespace RPN_Calculator.View
{
    public class ConsoleUI : IUserInterface
    {
        private TextReader input;
        private TextWriter output;

        public ConsoleUI(string[] args)
        {
            //if (args == null)
            //{

            //}
        }
        public void PrintResult(double result)
        {
            Console.WriteLine($"Result: {result:f}");
            DisplayPause();
        }

        //public void ReadInput(ref string? expression)
        //{
        //    expression = Console.ReadLine();
        //}

        //private void Clear() { Console.Clear(); }

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
    }
}
