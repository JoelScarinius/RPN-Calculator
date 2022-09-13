using RPN_Calculator.Controller;
using RPN_Calculator.View;

namespace RPN_Calculator
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            //Database database = new Database();

            //DatabaseController dbController = new DatabaseController(database);

            MainView view = new MainView();

            CalculatorController controller = new CalculatorController(view);


        }
    }
}