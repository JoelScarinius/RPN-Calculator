using RPN_Calculator.Controller;
using RPN_Calculator.Model;
using RPN_Calculator.View;

namespace RPN_Calculator
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            Database database = new Database();

            DatabaseController dbController = new DatabaseController(database);

            MainView view = new MainView();

            MainController controller = new MainController(view, dbController);


        }
    }
}