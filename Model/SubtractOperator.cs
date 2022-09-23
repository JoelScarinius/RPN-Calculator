namespace RPN_Calculator.Model
{
    public class SubtractOperator : Operator
    {
        private string subtractOperator;
        public SubtractOperator(string expression)
        {
            subtractOperator = expression;
        }

        public double Process(IStack stack)
        {
            double operand2 = stack.Pop().Process(stack);
            double operand1 = stack.Pop().Process(stack);
            double sum = operand1 - operand2;
            return sum;
        }

        public string ToString()
        {
            return $"{subtractOperator}";
        }
    }
}
