namespace RPN_Calculator.Model
{
    public class Operator : IToken
    {

        public virtual double Process(IStack stack) { double operand = default; return operand; }

        public virtual string ToString() => "Operator";
    }
}
