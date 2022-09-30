using RPN_Calculator.Model.Interfaces;
using RPN_Calculator.View;

namespace RPN_Calculator.Controller
{
    /// <summary>
    /// CalculatorController manages the program's execution
    /// </summary>
    public class CalculatorController
    {
        public IUserInterface View;
        private bool isDone = false;
        private ICalculator calc;

        public CalculatorController(IUserInterface view, ICalculator calc)
        {
            View = view;
            this.calc = calc;
        }

        /// <summary>
        /// Run method initiates UI prompts and RPN calculations.
        /// </summary>
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
