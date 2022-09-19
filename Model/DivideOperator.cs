namespace RPN_Calculator.Model
{
    public class DivideOperator : Operator
    {
        private string divideOperator;
        public DivideOperator(string expression)
        {
            divideOperator = expression;
        }

        public override double Calculate(double operand1, double operand2)
        {
            return operand1 / operand2;
        }

        public override string ToString()
        {
            return $"{divideOperator}";
        }
    }
}
