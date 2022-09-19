using RPN_Calculator.Model;
using RPN_Calculator.View;

namespace RPN_Calculator.Controller
{
	public class CalculatorController
	{
		public MainView View { get; protected set; }
		private bool isDone;
		private string? expression;
		private string[] expressionList;
		private double result = 0;

		/// <param name="view">Mainview</param>

		public CalculatorController(MainView view)
		{
			View = view;
			isDone = false;
			Run();
		}

		private void Run()
		{
			while (!isDone)
			{
				View.Clear();
				DisplayStartMessage();
				ReadInput(ref expression);
				if (expression == "")
				{
					isDone = true;
					continue;
				}
				TrimInput(expression, ref expressionList);
				ValidateInput(expressionList);
				// Kolla efer operatorer först innan du gör tryparse
				//Token tokens = new Token()
				DisplayPause();
			}
			View.WriteLine("\nThe user exited the application");
		}

		private void DisplayStartMessage()
		{
			//View.Clear();
			View.Write("Enter RPN-expression <return> (empty string = exit): ");
		}

		private void ReadInput(ref string? expression)
		{
			//View.Clear();
			expression = View.ReadLine();
		}

		private void TrimInput(string expression, ref string[] expressionList)
		{
			expressionList = expression.Split(' ', expression.Length);
		}

		private void ValidateInput(string[] expressionList)
		{
			Operator operators = new Operator();
			Token token = operators;

			foreach (string expression in expressionList)
			{

				switch (expression)
				{
					case "+":
						AddOperator addOperator = new AddOperator(expression);
						token = addOperator;
						Token.tokens.Push(token);
						break;
					case "-":
						SubtractOperator subtractOperator = new SubtractOperator(expression);
						token = subtractOperator;
						Token.tokens.Push(token);
						break;
					case "*":
						MultiplyOperator multiplyOperator = new MultiplyOperator(expression);
						token = multiplyOperator;
						Token.tokens.Push(token);
						break;
					case "/":
						DivideOperator divideOperator = new DivideOperator(expression);
						token = divideOperator;
						Token.tokens.Push(token);
						break;
					case "%":

						ModulusOperator modulusOperator = new ModulusOperator(expression);
						token = modulusOperator;
						Token.tokens.Push(token);
						break;
					default:
						try
						{
							if (double.TryParse(expression, out double operand2))
							{
								Operand operand = new Operand(operand2);
								token = operand;
								Token.tokens.Push(token);
							}
							else throw new Exception();
						}
						catch (Exception)
						{

							throw;
						}
						break;
				}
			}
			result = AlltDengörALLt();
			View.PrintResult(result);
			result = 0;
		}

		private double AlltDengörALLt()
		{
			Token op = Token.tokens.Pop();
			//Operand operand = new Operand();

			//View.WriteLine(op.GetType().ToString());
			if (typeof(Operand) == op.GetType())
			{
				Operand operand = (Operand)op;
				return operand.GetOperand();
			}
			else
			{
				Operator operators = (Operator)op;
				//View.WriteLine(operators.GetType().ToString());

				double rightOperand = AlltDengörALLt();
				double leftOperand = AlltDengörALLt();

				result = operators.Calculate(leftOperand, rightOperand);
			}
			return result;
		}

		private void DisplayPause()
		{
			View.WriteLine("Press \"Enter\" to continue...");
			View.ReadLine();
		}
	}
}
