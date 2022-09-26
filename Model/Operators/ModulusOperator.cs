using DivideByZeroException = RPN_Calculator.Exceptions.DivideByZeroException;

namespace RPN_Calculator.Model.Operators
{
    public class ModulusOperator : Operator
    {
        private string modulusOperator;
        public ModulusOperator(string expression)
        {
            modulusOperator = expression;
        }

        public override double Process(IStack stack)
        {
            double operand2 = stack.Pop().Process(stack);
            double operand1 = stack.Pop().Process(stack);
            if (operand2 == 0)
            {
                string message = $"{operand1:f} {ToString()} {operand2:f}";
                throw new DivideByZeroException(message);
            }
            double sum = operand1 % operand2;
            return sum;
        }

        public override string ToString()
        {
            return $"{modulusOperator}";
        }
    }
}
