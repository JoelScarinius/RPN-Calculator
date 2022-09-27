using RPN_Calculator.Controller;
using RPN_Calculator.Model;
using RPN_Calculator.Model.Interfaces;
using RPN_Calculator.View;

namespace RPN_Calculator
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            IUserInterface view = UIFactory.GetUI(args);

            ICalculator calc = new RPNCalculator();

            CalculatorController controller = new CalculatorController(view, calc);
            controller.Run();
        }
    }
}