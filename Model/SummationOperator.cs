namespace RPN_Calculator.Model
{
    public class SummationOperator : Operator
    {
        //private Operator summationOperator;

        //public override string ToString()
        //{

        //}
        public override Token ConvertToToken(string expression)
        {
            if (String.Compare(expression, "+") == 0)
            {
                Token summationOperator = new Token();
                return summationOperator;
            }
            return null;
        }
        public int Sum(Operand operand1, Operand operand2)
        {
            int.TryParse(operand1.ToString(), out int x);
            int.TryParse(operand2.ToString(), out int y);
            return x + y;
        }
    }
}
