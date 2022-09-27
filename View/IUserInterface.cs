namespace RPN_Calculator.View
{
    public interface IUserInterface
    {
        string? ReadInput();

        void PrintResult(double result);

        void PrintResult(string result);

        void Dispose();

    }
}
