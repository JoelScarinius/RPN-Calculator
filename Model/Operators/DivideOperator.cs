using Workshop3.Exceptions;

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
            if (operand2 == 0)
            {
                throw new Workshop3.Exceptions.DivideByZeroException($"Not possible to divide by zero", operand2);
            }
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
