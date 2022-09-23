namespace RPN_Calculator.Model
{
    public class MultiplyOperator : Operator
    {
        private string multiplyOperator;
        public MultiplyOperator(string expression)
        {
            multiplyOperator = expression;
        }

        public double Process(IStack stack)
        {
            double operand2 = stack.Pop().Process(stack);
            double operand1 = stack.Pop().Process(stack);
            double sum = operand1 * operand2;
            return sum;
        }

        public string ToString()
        {
            return $"{multiplyOperator}";
        }
    }
}
