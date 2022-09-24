using RPN_Calculator.Controller;
using RPN_Calculator.View;
//using DivideByZeroException = Calculator.Exceptions.DivideByZeroException;

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

            try
            {
                Console.WriteLine("InvalidInput");
                //DivideOperator divideOperator = new("operand2");
            }
            catch (Workshop3.Exceptions.DivideByZeroException e)
            {
                Console.WriteLine($"Exception: {e.Message}\n");
                Console.WriteLine($"Operand2: {e.Operand2}");
                //Console.Exit()
            }
        }
    }
}