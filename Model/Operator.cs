namespace RPN_Calculator.Model
{
    public class Operator : Token
    {
        public virtual double Calculate(double operand1, double operand2)
        {
            return operand1;
        }
    }
}
