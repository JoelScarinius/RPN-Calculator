using RPN_Calculator.Controller;
using RPN_Calculator.Model;
using RPN_Calculator.Model.Interfaces;
using RPN_Calculator.View;

namespace RPN_Calculator
{
    /// <summary>
    /// This class contains the main Method which creates the interfaces needed to 
    /// run the program by calling on the run method.
    /// </summary>
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