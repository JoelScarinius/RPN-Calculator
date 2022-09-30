using RPN_Calculator.View.IO;

namespace RPN_Calculator.View
{
    public class UIFactory
    {
        private UIFactory() { }

        public static IUserInterface GetUI(string[] args)
        {
            IUserInterface ui = null;
            if (args.Length == 0)
            {
                ui = new ConsoleUI(args);
            }
            else
            {
                ui = new FileUI(args);
            }
            return ui;
        }
    }
}
