namespace RPN_Calculator.Model
{
    public class ModulusOperator : Operator
    {
        private string modulusOperator;
        public ModulusOperator(string expression)
        {
            modulusOperator = expression;
        }

        public override double Calculate(double operand1, double operand2)
        {
            return operand1 % operand2;
        }

        public override string ToString()
        {
            return $"{modulusOperator}";
        }
    }
}
