using RPN_Calculator.Controller;

namespace RPN_Calculator.Model
{
    public class RPNCalculator : ICalculator
    {

        private string? stringToken;
        private string[] stringTokenList;

        private RPNCalculator() { }

        public double Calculate()
        {
            TokenStack stack = new TokenStack();

            TrimInput(stringToken, ref stringTokenList);

            foreach (string tokenExpression in stringTokenList)
            {
                IToken token = TokenFactory.GetToken(tokenExpression);
                stack.Push(token);
            }

            return stack.Pop().Process(stack);
        }

        private static void TrimInput(string stringToken, ref string[] stringTokenList)
        {
            stringTokenList = stringToken.Split(' ', stringToken.Length);
        }
    }
}
