using RPN_Calculator.Controller;
using RPN_Calculator.Model.Interfaces;
using InvalidOperationException = RPN_Calculator.Exceptions.InvalidOperationException;

namespace RPN_Calculator.Model
{
    public class RPNCalculator : ICalculator
    {
        private string[] stringTokenList;

        public RPNCalculator() { }

        public double Calculate(string stringToken)
        {
            TokenStack stack = new TokenStack();

            TrimInput(stringToken, ref stringTokenList);

            IToken token = null;
            foreach (string tokenExpression in stringTokenList)
            {
                token = TokenFactory.GetToken(tokenExpression);
                stack.Push(token);
            }

            // Simplify?
            string stringT = stringToken;
            char tokenChar = stringT[stringT.Length - 1];
            if (char.IsDigit(tokenChar))
            {
                throw new InvalidOperationException();
            }

            token = stack.Pop();

            return token.Process(stack);
        }

        private static void TrimInput(string stringToken, ref string[] stringTokenList)
        {
            stringToken = stringToken.Replace(".", ",");
            stringTokenList = stringToken.Split(' ', stringToken.Length);
        }
    }
}
