using RPN_Calculator.Controller;
using RPN_Calculator.View;

namespace RPN_Calculator
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            MainView view = new MainView();

            CalculatorController controller = new CalculatorController(view);

            Stack<IToken> stack = new Stack<IToken>();
        }
    }
}