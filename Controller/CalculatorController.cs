using RPN_Calculator.Model;
using RPN_Calculator.View;

namespace RPN_Calculator.Controller
{
    public class CalculatorController
    {
        public MainView View { get; protected set; }
        private bool isDone;
        private string? expression;
        private string[] expressionList;

        /// <param name="view">Mainview</param>

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
                if (expression == "") isDone = true;
                TrimInput(expression, ref expressionList);
                ValidateInput(expressionList);
                // Kolla efer operatorer först innan du gör tryparse
                //Token tokens = new Token()
                DisplayPause();
                View.Write("Result: ");
            }
            View.WriteLine("\nThe user exited the application");
        }
        private void DisplayStartMessage()
        {
            //View.Clear();
            View.Write("Enter RPN-expression <return> (empty string = exit): ");
        }
        private void ReadInput(ref string? expression)
        {
            //View.Clear();
            expression = View.ReadLine();
        }

        private void TrimInput(string expression, ref string[] expressionList)
        {
            expressionList = expression.Split(' ', expression.Length);
        }

        private void ValidateInput(string[] expressionList)
        {
            foreach (string expression in expressionList)
            {
                SummationOperator sumOperator = new SummationOperator();

                Token token = sumOperator.ConvertToToken(expression);
                Token.tokens.Push(token);
                View.WriteLine(Token.tokens.Pop().ToString());

                //        Token.tokens.Push(new Token());
            }
        }
        private void DisplayPause()
        {
            View.WriteLine("Press \"Enter\" to continue...");
            View.ReadLine();
        }
    }
}
