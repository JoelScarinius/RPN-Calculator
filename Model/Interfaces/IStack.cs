namespace RPN_Calculator.Model.Interfaces
{
    public interface IStack
    {
        void Push(IToken item);

        IToken Pop();

    }
}