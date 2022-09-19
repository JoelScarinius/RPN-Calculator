namespace RPN_Calculator.Model
{
    public class Operand : Token
    {
        private double doubleOperand;

        public Operand() { }

        public Operand(double doubleOperand)
        {
            this.doubleOperand = doubleOperand;
        }

        public double GetOperand() => doubleOperand;

        public override string ToString()
        {
            return $"{doubleOperand}";
        }
    }
}
