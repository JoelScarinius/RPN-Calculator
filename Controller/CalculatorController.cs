using RPN_Calculator.View;

namespace RPN_Calculator.Controller
{
    public class CalculatorController
    {
        public MainView View { get; protected set; }
        private bool isDone = false;
        private string? stringToken;
        private string[] stringTokenList;
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
                View.ReadInput(ref stringToken);
                if (stringToken == "" || stringToken == null)
                {
                    isDone = true;
                    continue;
                }
                TrimInput(stringToken, ref stringTokenList);

                foreach (string tokenExpression in stringTokenList)
                {
                    IToken token = TokenFactory.GetToken(tokenExpression);
                    stack.Push(token);
                }
                try
                {
                    result = stack.Pop().Process(stack);
                    View.PrintResult(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: " + ex.Message);
                }

                View.DisplayPause();
            }
            View.WriteLine("\nThe user exited the application");
        }

        private void TrimInput(string stringToken, ref string[] stringTokenList)
        {
            stringTokenList = stringToken.Split(' ', stringToken.Length);
        }

    }
}
