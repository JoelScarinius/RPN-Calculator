namespace RPN_Calculator.Model
{
    public class Token
    {
        private string stringToken;
        private int intToken;
        private Token token;
        public Token()
        {
            //intToken = 0;
            //stringToken = expression;

        }

        //public int GetSetInt { get; set; }
        //public string GetSetString { get; set; }

        public static Stack<Token> tokens;
        public virtual Token ConvertToToken(string expression) { return token; }

        /*
        1. Användaren skriver in en expression
        2. Strängen hamnar i en variabel och splitas där ' ' påträffas
        3. För varje tecken avgöra om det är ett giltigt token
        4. Pusha token på stacken tills strängen är tom
        5. Poppa tokens från stacken och mönstermatcha med giltiga operatorer
        6. Gör beräkningarna och printa "Result"
        7. Fortsätta skriva in expression eller terminera?         
        */
    }
}
