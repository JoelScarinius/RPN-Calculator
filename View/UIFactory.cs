using RPN_Calculator.View.IO;

namespace RPN_Calculator.View
{
    /// <summary>
    /// Reads the command line arguments to decide if the program should read from a file
    /// or if it should run through console.
    /// </summary>
    public class UIFactory
    {

        private UIFactory() { }
        /// <summary>
        /// This Method creates an instance of either the ConsoleUI or the FileUI.
        /// </summary>
        /// <param name="args">  
        /// args is a list of command line arguments, represented as strings.
        /// </param>
        /// <returns> 
        /// Returns instance of type IUserInterface.
        /// </returns>
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
