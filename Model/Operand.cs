namespace RPN_Calculator.Model
{
    public class Operand : Token
    {
        private int intOperand;
        private double doubleOperand;
        private bool validString;

        public Operand() { }

        public Operand(int intOperand)
        {
            this.intOperand = intOperand;
        }
        public Operand(double doubleOperand)
        {
            this.doubleOperand = doubleOperand;
        }

        public int GetOperand() => intOperand;
        public double GetDoubleOperand() => doubleOperand;

        public override string ToString()
        {
            return $"{intOperand}";
        }
    }
}
