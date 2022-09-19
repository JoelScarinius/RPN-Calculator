namespace RPN_Calculator.Model
{
    public class SubtractOperator : Operator
    {
        private string subtractOperator;
        public SubtractOperator(string expression)
        {
            subtractOperator = expression;
        }

        public override double Calculate(double operand1, double operand2)
        {
            return operand1 - operand2;
        }

        public override string ToString()
        {
            return $"{subtractOperator}";
        }
    }
}
