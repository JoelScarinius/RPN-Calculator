using RPN_Calculator.Model;
using RPN_Calculator.View;

namespace RPN_Calculator.Controller
{
    public class CalculatorController
    {
        public MainView View { get; protected set; }
        private bool isDone;
        private string? expression;
        private string[] expressionList;

        /// <param name="view">Mainview</param>

        public CalculatorController(MainView view)
        {
            View = view;
            isDone = false;
            Run();
        }
        private void Run()
        {
            while (!isDone)
            {
                View.Clear();
                DisplayStartMessage();
                ReadInput(ref expression);
                if (expression == "") isDone = true;
                TrimInput(expression, ref expressionList);
                ValidateInput(expressionList);
                // Kolla efer operatorer först innan du gör tryparse
                //Token tokens = new Token()
                DisplayPause();
                View.Write("Result: \n");
            }
            View.WriteLine("\nThe user exited the application");
        }
        private void DisplayStartMessage()
        {
            //View.Clear();
            View.Write("Enter RPN-expression <return> (empty string = exit): ");
        }
        private void ReadInput(ref string? expression)
        {
            //View.Clear();
            expression = View.ReadLine();
        }

        private void TrimInput(string expression, ref string[] expressionList)
        {
            expressionList = expression.Split(' ', expression.Length);
        }

        private void ValidateInput(string[] expressionList)
        {
            Operand operand = new Operand();
            Operator operators = new Operator();
            AddOperator addOperator = new AddOperator(expression);
            Token token = operators;

            foreach (string expression in expressionList)
            {

                switch (expression)
                {
                    case "+":
                        addOperator = new AddOperator(expression);
                        token = addOperator;
                        Token.tokens.Push(token);
                        break;
                    case "-": break;
                    case "*": break;
                    case "/": break;
                    case "%": break;
                    default:
                        try
                        {
                            if (int.TryParse(expression, out int operand1))
                            {
                                operand = new Operand(operand1);
                                token = operand;
                                Token.tokens.Push(token);
                            }
                            else if (double.TryParse(expression, out double operand2))
                            {
                                operand = new Operand(operand2);
                                token = operand;
                                Token.tokens.Push(token);
                            }
                            else throw new Exception();
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        break;
                }
            }

            //if (addOperator.IsValidOperator(expression))
            //{
            //    Token.tokens.Push(token);
            //}
            //else if (addOperand.IsValidOperator(expression))
            //    //if (Token.tokens.Pop() == operators) // Kolla vad som poppas och jämför det för att göra rätt utsskrift.
            // Polymorfism när man poppar.
            addOperator = (AddOperator)Token.tokens.Pop();
            View.WriteLine(addOperator.ToString()); //Skriver ut plustecknet
            operand = (Operand)Token.tokens.Pop();
            View.WriteLine(operand.ToString()); //Skriver ut plustecknet
            operand = (Operand)Token.tokens.Pop();
            View.WriteLine(operand.ToString()); //Skriver ut plustecknet
            //operators = addOperator;
            //addOperator = (AddOperator)operators;     
        }
        //public int Sum(double operand1, double operand2)
        //{
        //        Operand operand = new Operand(operand1);
        //        Token token = Token.tokens.Pop();
        //        token = operand;
        //        operand1 = operand.GetOperand();
        //        token = Token.tokens.Pop();
        //        operand2 = operand.GetOperand();
        //    return x + y;
        //}
        private void DisplayPause()
        {
            View.WriteLine("Press \"Enter\" to continue...");
            View.ReadLine();
        }
    }
}
