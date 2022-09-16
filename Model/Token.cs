namespace RPN_Calculator.Model
{
    public class Token
    {
        public static Stack<Token> tokens;

        public Token(Stack<Token> tokens)
        {
            Token.tokens = tokens;
        }
    }
}
