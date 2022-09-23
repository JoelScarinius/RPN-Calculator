using RPN_Calculator.View;

public interface IToken
{
    double Process(IStack stack);

    string ToString();
}