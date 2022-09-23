namespace RPN_Calculator.Model.Operators
{
    public class SubtractOperator : Operator
    {
        private string subtractOperator;
        public SubtractOperator(string expression)
        {
            subtractOperator = expression;
        }

        public override double Process(IStack stack)
        {
            double operand2 = stack.Pop().Process(stack);
            double operand1 = stack.Pop().Process(stack);
            double sum = operand1 - operand2;
            return sum;
        }

        public override string ToString()
        {
            return $"{subtractOperator}";
        }
    }
}
