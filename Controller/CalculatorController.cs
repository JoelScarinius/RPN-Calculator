using RPN_Calculator.Model.Interfaces;
using RPN_Calculator.View;

namespace RPN_Calculator.Controller
{
    public class CalculatorController
    {
        public IUserInterface View;
        private bool isDone = false;
        private ICalculator calc;

        /// <param name="view">Mainview</param>

        public CalculatorController(IUserInterface view, ICalculator calc)
        {
            View = view;
            this.calc = calc;
        }

        public void Run()
        {
            while (!isDone)
            {
                string? stringToken = View.ReadInput();
                if (stringToken == "" || stringToken == null)
                {
                    isDone = true;
                    continue;
                }

                try
                {
                    double result = calc.Calculate(stringToken);
                    View.PrintResult(result);
                }
                catch (Exception ex)
                {
                    View.PrintResult($"Exception: " + ex.Message);
                }
            }
            View.Dispose();
        }
    }
}
