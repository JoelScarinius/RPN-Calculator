namespace RPN_Calculator.Model.Operators
{
    public class DivideOperator : Operator
    {
        private string divideOperator;
        public DivideOperator(string expression)
        {
            divideOperator = expression;
        }

        public override double Process(IStack stack)
        {
            double operand2 = stack.Pop().Process(stack);
            double operand1 = stack.Pop().Process(stack);
            double sum = operand1 / operand2;
            return sum;
        }

        public override string ToString()
        {
            return $"{divideOperator}";
        }
    }
}
