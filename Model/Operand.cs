namespace RPN_Calculator.Model
{
    public class Operand : IToken
    {
        private double operand;


        //public Operand() { }

        public Operand(double operand)
        {
            this.operand = operand;
        }


        //public double GetOperand() => operand;

        public string ToString()
        {
            return $"{operand}";
        }

        public double Process(IStack stack) { return operand; }
    }
}
