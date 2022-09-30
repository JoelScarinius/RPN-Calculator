using RPN_Calculator.Model.Interfaces;
using InvalidOperationException = RPN_Calculator.Exceptions.InvalidOperationException;

namespace RPN_Calculator.Model
{
    /// <summary>
    /// This Method creates an instance of the operator class matching the token string.
    /// If the token string is a number an instance of the operand class is created.
    /// If an invalid token string is encountered an exception will be thrown.
    /// </summary>

    public class RPNCalculator : ICalculator
    {
        private string[] stringTokenList;

        public RPNCalculator() { }

        /// <summary>
		/// This Method first creates an instance of the token stack.
        /// Then the method calls another method (trim input) that deletes the whitespaces
        /// in string token. After that the token factory is called. 
        /// Token factory then creates tokens from all the parts of the string token.
        /// After that the tokens are pushed onto the stack. 
        /// Then we have a check with an exception to see if the expression was written in
        /// a correct manner.
        /// At last the method pops a token from the stack and returns with a method
        /// call to process.
		/// If the token string is a number an instance of the operand class is created.
		/// If an invalid token string is encountered an exception will be thrown.
		/// </summary>
		/// <param name="stringToken">  
		/// The parameter string token is a string containing one part of an RPN-expression. 
		/// </param>
		/// <returns> 
		/// Returns a double (the result after the method process has returned).
		/// </returns>

        public double Calculate(string stringToken)
        {
            TokenStack stack = new TokenStack();

            TrimInput(stringToken, ref stringTokenList);

            IToken token = null;
            foreach (string tokenExpression in stringTokenList)
            {
                token = TokenFactory.GetToken(tokenExpression);
                stack.Push(token);
            }

            string stringT = stringToken;
            char tokenChar = stringT[stringT.Length - 1];
            if (char.IsDigit(tokenChar))
            {
                throw new InvalidOperationException();
            }

            token = stack.Pop();

            return token.Process(stack);
        }

        /// <summary>
		/// This Method trims a string by removing all whitespaces and splitting the string
        /// into different parts divided by the removed whitespace.
        /// The method does this by using the built-in method split.
		/// </summary>
		/// <param name="stringToken" name="stringTokenList">  
		/// The parameter string token is a string containing the RPN-expression. 
        /// The parameter string token list is a list with the divided RPN-expression.
		/// </param>
		/// <returns> 
		/// Returns void and because string token list is ref its values have been changed
        /// in memory.
		/// </returns>

        private static void TrimInput(string stringToken, ref string[] stringTokenList)
        {
            stringToken = stringToken.Replace(".", ",");
            stringTokenList = stringToken.Split(' ', stringToken.Length);
        }
    }
}
