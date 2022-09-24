using RPN_Calculator.Exceptions;
using RPN_Calculator.View;
using DivideByZeroException = RPN_Calculator.Exceptions.DivideByZeroException;

namespace RPN_Calculator.Controller
{
    public class CalculatorController
    {
        public MainView View { get; protected set; }
        private bool isDone = false;
        private string? expression;
        private string[] expressionList;
        private double result = 0;
        private TokenStack stack;

        /// <param name="view">Mainview</param>

        public CalculatorController(MainView view, TokenStack stack)
        {
            View = view;
            this.stack = stack;
            //Run();
        }

        public void Run()
        {
            while (!isDone)
            {
                View.Clear();
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
                    stack.Push(token);
                }
                try
                {
                    result = stack.Pop().Process(stack);
                    View.PrintResult(result);
                }

                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    Console.WriteLine($"Operand2: {ex.Operand2}");
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
