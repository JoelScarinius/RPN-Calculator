using RPN_Calculator.View;

namespace RPN_Calculator.Model
{
    public class Operator : IToken
    {
        private double operand;
        public double Process(IStack stack) { return operand; }

        public string ToString() { return "Operator"; }
    }
}
