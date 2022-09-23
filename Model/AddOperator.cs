using RPN_Calculator.View;

namespace RPN_Calculator.Model
{
    public class AddOperator : Operator
    {
        private string addOperator;
        public AddOperator(string expression)
        {
            addOperator = expression;
        }

        public double Process(IStack stack)
        {
            double operand2 = stack.Pop().Process(stack);
            double operand1 = stack.Pop().Process(stack);
            double sum = operand1 + operand2;
            return sum;
        }

        public string ToString()
        {
            return $"{addOperator}";
        }
    }
}
