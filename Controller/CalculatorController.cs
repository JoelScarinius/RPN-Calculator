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
        private double result = 0;

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
                View.DisplayStartMessage();
                View.ReadInput(ref expression);
                if (expression == "" || expression == null)
                {
                    isDone = true;
                    continue;
                }
                TrimInput(expression, ref expressionList);
                foreach (string tokenExpression in expressionList)
                {
                    IToken token = TokenFactory.GetToken(tokenExpression);
                    //IStack.stack.Push(token);
                }
                View.DisplayPause();
            }
            View.WriteLine("\nThe user exited the application");
        }

        private void TrimInput(string expression, ref string[] expressionList)
        {
            expressionList = expression.Split(' ', expression.Length);
        }

    }
}
