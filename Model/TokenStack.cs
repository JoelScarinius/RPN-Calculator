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