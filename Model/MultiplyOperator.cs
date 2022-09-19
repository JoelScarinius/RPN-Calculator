namespace RPN_Calculator.Model
{
    public class MultiplyOperator : Operator
    {
        private string multiplyOperator;
        public MultiplyOperator(string expression)
        {
            multiplyOperator = expression;
        }

        public override double Calculate(double operand1, double operand2)
        {
            return operand1 * operand2;
        }

        public override string ToString()
        {
            return $"{multiplyOperator}";
        }
    }
}
