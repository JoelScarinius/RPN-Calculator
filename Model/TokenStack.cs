public class TokenStack : IStack
{
    private Stack<IToken> tStack;

    public TokenStack()
    {
        tStack = new Stack<IToken>();
    }

    public void Push(IToken token)
    {
        tStack.Push(token);
    }

    public IToken Pop()
    {
        return tStack.Pop();
    }

}