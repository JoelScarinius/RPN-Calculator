namespace RPN_Calculator.View
{
    public class MainView
    {
        public MainView() { }
        public void Write(string message) { Console.Write(message); }
        public void WriteLine(string message) { Console.WriteLine(message); }
        public string ReadLine() => Console.ReadLine();
        public void Clear() { Console.Clear(); }
        public void PrintResult(double result) { Console.WriteLine($"Result: {result:f}"); }

    }
}
