namespace RPN_Calculator.Model
{
    public class ModulusOperator : Operator
    {
        private string modulusOperator;
        public ModulusOperator(string expression)
        {
            modulusOperator = expression;
        }

        public double Process(IStack stack)
        {
            double operand2 = stack.Pop().Process(stack);
            double operand1 = stack.Pop().Process(stack);
            double sum = operand1 % operand2;
            return sum;
        }

        public string ToString()
        {
            return $"{modulusOperator}";
        }
    }
}
