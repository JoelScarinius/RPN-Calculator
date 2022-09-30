using RPN_Calculator.Model.Interfaces;

namespace RPN_Calculator.Model
{
    /// <summary>
    /// Operand class represents an operand token cointaining the values used in the calculations.
    /// It inherits the type IToken from the IToken interface which is used to collectively store Operand
    /// and Operators on the token stack.
    /// </summary>
    public class Operand : IToken
    {
        private double operand;

        public Operand(double operand)
        {
            this.operand = operand;
        }

        /// <summary>
        /// This method Process illustrates the base case of the recursive Process method and 
        /// cancles the recursion by only returning the operand value for the calculation.
        /// </summary>
        /// <param name="stack">The token stack containing the RPN tokens</param>
        /// <return>Returns the value of the operand</return>
        public double Process(IStack stack) => operand;

        /// <summary>
        /// This method ToString converts the operand value to a string.
        /// </summary>
        /// <return>Returns a string representing the operand value</return>
        public string ToString() => $"{operand}";
    }
}
