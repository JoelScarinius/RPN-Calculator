using RPN_Calculator.Controller;
using RPN_Calculator.View;

namespace RPN_Calculator
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            MainView view = new MainView();

            TokenStack stack = new TokenStack();
            CalculatorController controller = new CalculatorController(view, stack);
            controller.Run();
        }
    }
}