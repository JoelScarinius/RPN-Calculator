namespace RPN_Calculator.Model
{
    public class AddOperator : Operator
    {
        private string addOperator;
        public AddOperator(string expression)
        {
            addOperator = expression;
        }

        public override string ToString()
        {
            return $"{addOperator}";
        }

    }
}
