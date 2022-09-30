using DivideByZeroException = RPN_Calculator.Model.Exceptions.DivideByZeroException;
using IStack = RPN_Calculator.Model.Interfaces.IStack;

namespace RPN_Calculator.Model.Operators
{
    /// <summary>
    /// ModulusOperator class takes care of calculations regarding modulus
    /// </summary>
    public class ModulusOperator : Operator
    {
        private string modulusOperator;
        public ModulusOperator(string expression)
        {
            modulusOperator = expression;
        }

        /// <summary>
        /// This recursive method Process overrides the virtual Process method in the Operator super class
        /// and performs modulus calculations on the tokens that gets popped from the token stack.
        /// </summary>
        /// <param name="stack">The token stack containing the RPN tokens</param>
        /// <return>Returns the calculated value from the calculation process</return>
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

        public override string ToString() => $"{modulusOperator}";
    }
}
