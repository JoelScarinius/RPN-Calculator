using RPN_Calculator.View;

namespace RPN_Calculator.Controller
{
    public class CalculatorController
    {
        //public IUserInterface View { get; protected set; }
        private MainView View;
        //private MainView View { get; protected set; }
        private bool isDone = false;
        private string? stringToken;
        private string[] stringTokenList;
        //private double result = 0;
        //private ICalculator calc;
        private TokenStack stack;

        /// <param name="view">Mainview</param>

        public CalculatorController(MainView view, TokenStack stack)
        //public CalculatorController(IUserInterface view, TokenStack stack)
        {
            View = view;
            this.stack = stack;
            //this.calc = calc;
            //Run();
        }

        public void Run()
        {
            while (!isDone)
            {
                View.Clear();
                View.DisplayStartMessage();
                View.ReadInput(ref stringToken);
                //string stringToken = View.ReadInput();
                if (stringToken == "" || stringToken == null)
                {
                    isDone = true;
                    continue;
                }

                //calc.Calculate(stringToken);

                TrimInput(stringToken, ref stringTokenList);

                foreach (string tokenExpression in stringTokenList)
                {
                    IToken token = TokenFactory.GetToken(tokenExpression);
                    stack.Push(token);
                }
                try
                {
                    double result = stack.Pop().Process(stack);
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
