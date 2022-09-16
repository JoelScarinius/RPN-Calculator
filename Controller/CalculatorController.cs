using RPN_Calculator.View;

namespace RPN_Calculator.Controller
{
    public class CalculatorController
    {
        public MainView View { get; protected set; }
        private bool isDone;
        private string? expression;

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
            {
                DisplayStartMessage();
                ReadInput(ref expression);
                // Kolla efer operatorer först innan du gör tryparse
                //Token tokens = new Token()
                DisplayPause();
                View.Write("Result: ");
            }
            View.WriteLine("\nThe user exited the application");
        }
        private void DisplayStartMessage()
        {
            View.Clear();
            View.Write("Enter RPN-expression <return> (empty string = exit): ");
        }
        private void ReadInput(ref string? expression)
        {
            View.Clear();
            expression = View.ReadLine();
            if (expression == "") isDone = true;
        }

        private void ValidateInput(string expression)
        {
            string[] expressionList = expression.Split(' ', expression.Length);
            //foreach (string in expressionList)
            //{
            //    if (int.TryParse(expressionList[i], out int intTokens)); //push operand
            //    else; //push operator
            //}
        }
        private void DisplayPause()
        {
            View.WriteLine("Press \"Enter\" to continue...");
            View.ReadLine();
        }
    }
}
