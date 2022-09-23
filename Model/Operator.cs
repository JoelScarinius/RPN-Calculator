namespace RPN_Calculator.Model
{
    public class Operator : IToken
    {
        private double operand;
        public virtual double Process(IStack stack) { return operand; }

        public virtual string ToString() { return "Operator"; }
    }
}
