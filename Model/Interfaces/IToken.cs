namespace RPN_Calculator.Model.Interfaces
{
    public interface IToken
    {
        double Process(IStack stack);

        string ToString();
    }
}