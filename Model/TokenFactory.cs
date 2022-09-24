using RPN_Calculator.Exceptions;
using RPN_Calculator.Model;
using RPN_Calculator.Model.Operators;
using Exception = RPN_Calculator.Exceptions.Exception;

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
						throw new InvalidTokenException(expression);
					}
					//catch (InvalidTokenException ex)
					//{
					//    Console.WriteLine($"Exception: {ex.Message}");
					//    Console.WriteLine($"InvalidToken: {ex.InvalidToken}");
					//}
					break;
			}
			return token;
		}
	}
}