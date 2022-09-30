using RPN_Calculator.Exceptions;
using RPN_Calculator.Model.Operators;

namespace RPN_Calculator.Model
{

	public class TokenFactory
	{
		/// <summary>
		/// This Method creates an instance of the operator class matching the token string.
		/// If the token string is a number an instance of the operand class is created.
		/// If an invalid token string is encountered an exception will be thrown.
		/// </summary>
		/// <param name="stringToken">  
		/// The parameter string token is a string containing one part of an RPN-expression. 
		/// </param>
		/// <returns> 
		/// Returns an IToken (operand or operator) ready to be pushed to the token stack.
		/// </returns>

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