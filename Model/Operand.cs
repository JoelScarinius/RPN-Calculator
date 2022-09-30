namespace RPN_Calculator.Model
{
    public class Operand : IToken
    {
        private double operand;

        public Operand(double operand)
        {
            this.operand = operand;
        }

        public double Process(IStack stack) => operand;

        public string ToString() => $"{operand}";
    }
}
