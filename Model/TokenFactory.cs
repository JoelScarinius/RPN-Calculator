using RPN_Calculator.Exceptions;
using RPN_Calculator.Model;
using RPN_Calculator.Model.Operators;

namespace RPN_Calculator.Controller
{
	public class TokenFactory
	{
		//private TokenStack stack;

		public static IToken GetToken(string stringToken)
		{
			IToken token = null;
			switch (stringToken)
			{
				case "+": token = new AddOperator(stringToken); break;
				case "-": token = new SubtractOperator(stringToken); break;
				case "*": token = new MultiplyOperator(stringToken); break;
				case "/": token = new DivideOperator(stringToken); break;
				case "%": token = new ModulusOperator(stringToken); break;
				default:
					try
					{
						token = new Operand(double.Parse(stringToken));
					}
					catch (Exception)
					{
						throw new InvalidTokenException(stringToken);
					}
					break;
			}
			return token;
		}
	}
}