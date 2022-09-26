using RPN_Calculator.Controller;
using RPN_Calculator.View;

namespace RPN_Calculator
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            MainView view = new MainView();

            //IUserInterface view = UIFactory.GetUI(args);




            TokenStack stack = new TokenStack();
            CalculatorController controller = new CalculatorController(view, stack);
            controller.Run(); // Fråga


        }
    }
}