public interface IStack
{
    void Push(IToken item);

    IToken Pop();

}