using IStack = RPN_Calculator.Model.Interfaces.IStack;

namespace RPN_Calculator.Model.Operators
{
    /// <summary>
    /// MultiplyOperator class takes care of calculations regarding multiplication
    /// </summary>
    public class MultiplyOperator : Operator
    {
        private string multiplyOperator;
        public MultiplyOperator(string expression)
        {
            multiplyOperator = expression;
        }

        /// <summary>
        /// This recursive method Process overrides the virtual Process method in the Operator super class
        /// and performs multiplication calculations on the tokens that gets popped from the token stack.
        /// </summary>
        /// <param name="stack">The token stack containing the RPN tokens</param>
        /// <return>Returns the calculated value from the calculation process</return>
        public override double Process(IStack stack)
        {
            double operand2 = stack.Pop().Process(stack);
            double operand1 = stack.Pop().Process(stack);
            double sum = operand1 * operand2;
            return sum;
        }

        public override string ToString() => $"{multiplyOperator}";
    }
}
