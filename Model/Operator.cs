using RPN_Calculator.Model.Interfaces;

namespace RPN_Calculator.Model
{
    /// <summary>
    /// The Operator class represents the different operators that is used for performing the calculations.
    /// It inherits the type IToken from the IToken interface which is used to collectively store Operator
    /// and Operands on the token stack.
    /// </summary>
    public class Operator : IToken
    {
        /// <summary>
        /// This is the virtual method for the recursive Process method that gets overridden by the 
        /// Operator subclasses.
        /// </summary>
        /// <param name="stack">The token stack containing the RPN tokens</param>
        /// <return>Returns the calculated value from the calculation process</return>
        public virtual double Process(IStack stack) { double operand = default; return operand; }

        /// <summary>
        /// This is the virtual method ToString that gets overridden by the 
        /// Operator subclasses.
        /// </summary>
        /// <return>Returns a string representing the current operator</return>
        public virtual string ToString() => "Operator";
    }
}
