﻿namespace RPN_Calculator.Model
{
    public class AddOperator : Operator
    {
        private string addOperator;
        public AddOperator(string expression)
        {
            addOperator = expression;
        }

        public override double Calculate(double operand1, double operand2)
        {
            return operand1 + operand2;
        }

        public override string ToString()
        {
            return $"{addOperator}";
        }
    }
}
