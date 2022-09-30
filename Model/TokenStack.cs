using RPN_Calculator.Model.Interfaces;

namespace RPN_Calculator.Model
{
    /// <summary>
    /// This class overrides the in-built methods for a stack and implements them. 
    /// The class also inherits from IStack where the prototypes for the stack are.
    /// </summary>

    public class TokenStack : IStack
    {
        private Stack<IToken> tokenStack;

        public TokenStack()
        {
            tokenStack = new Stack<IToken>();
        }

        public void Push(IToken token)
        {
            tokenStack.Push(token);
        }

        public IToken Pop()
        {
            return tokenStack.Pop();
        }

    }
}