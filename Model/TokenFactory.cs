using RPN_Calculator.Model;
using RPN_Calculator.Model.Operators;


namespace RPN_Calculator.Controller
{
	public class TokenFactory
	{
		//private TokenStack stack;

		public static IToken GetToken(string expression)
		{
			IToken token = null;
			switch (expression)
			{
				case "+": token = new AddOperator(expression); break;
				case "-": token = new SubtractOperator(expression); break;
				case "*": token = new MultiplyOperator(expression); break;
				case "/": token = new DivideOperator(expression); break;
				case "%": token = new ModulusOperator(expression); break;
				default:
					try
					{
						token = new Operand(double.Parse(expression));
					}
					catch (Exception)
					{

					}
					break;
			}
			return token;
		}
	}
}