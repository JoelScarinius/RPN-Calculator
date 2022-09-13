using RPN_Calculator.View;

namespace RPN_Calculator.Controller
{
    public class CalculatorController
    {
        public MainView View { get; protected set; }
        private bool isDone;
        private byte option;
        /// <param name="vy">Mainview</param>
        /// <param name="dbHanterare">Databasecontroller</param>

        public CalculatorController(MainView view)
        {
            View = view;
            isDone = false;
            Run();
        }
        private void Run()
        {
            while (!isDone)
                DisplayStartMessage();
            View.WriteLine("\nThe user exited the application");
        }
        private void DisplayStartMessage()
        {
            View.Clear();
            View.Write("Enter RPN-expression <return> (empty string = exit): ");

            string? expression = View.ReadLine();
            //if (byte.TryParse(expression, out option))
            //{
            View.Clear();
            if (expression == "") isDone = true;
            DisplayPause();
            //}
            View.Write("Result: ");
        }
        private void DisplayPause()
        {
            View.WriteLine("Press \"Enter\" to continue...");
            View.ReadLine();
        }
    }
}
