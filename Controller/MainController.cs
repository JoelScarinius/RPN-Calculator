using Workshop2.View;

namespace Workshop2.Controller
{
    public class MainController
    {
        public MainView View { get; protected set; }
        public DatabaseController DbController { get; protected set; }
        private bool isDone;
        private byte option;
        /// <param name="vy">Mainview</param>
        /// <param name="dbHanterare">Databasecontroller</param>

        public MainController(MainView view, DatabaseController dbController)
        {
            View = view;
            DbController = dbController;
            isDone = false;
            Run();
        }
        private void Run()
        {
            while (!isDone)
                DisplayMainMenu();
        }
        private void DisplayMainMenu()
        {
            View.Clear();

            View.WriteLine("Welcome to JU main menu!");
            View.WriteLine("1. Program");
            View.WriteLine("2. Students");
            View.WriteLine("3. Teachers");
            View.WriteLine("4. Room");
            View.WriteLine("5. Premises");
            View.WriteLine("6. Courses");
            View.WriteLine("7. Course moments");
            View.WriteLine("8. Schedule");
            View.WriteLine("9. Update database");
            View.WriteLine("0. Exit");

            View.Write("Your choice? : ");

            string? optionString = View.ReadLine();
            if (byte.TryParse(optionString, out option))
            {
                View.Clear();
                switch (option)
                {
                    case 1: DisplayPrograms(); break;
                    case 2: DisplayStudents(); break;
                    case 3: DisplayTeachers(); break;
                    //case 4: Display... break;
                    //case 5: Display... break;
                    //case 6: Display... break;
                    //case 7: Display... break;
                    //case 8: Display... break;
                    //case 9: Display... break;
                    case 0:
                        View.WriteLine("See you soon, bye!");
                        isDone = true;
                        return;
                    default:
                        View.WriteLine("Not a valid option, please try again!\n");
                        return;
                }
                DisplayPause();
            }
        }
        private void DisplayPrograms()
        {
            View.WriteLine("PROGRAMS\n");
            View.WriteLine(string.Format("{0, -35 } {1, -20}", "Name", "Code"));
            foreach (Program p in DbController.GetPrograms())
            {
                View.WriteLine(string.Format("{0, -35 } {1, -20}", p.Name, p.GetString()));
            }
            View.WriteLine("");
        }
        private void DisplayStudents()
        {
            View.WriteLine("PROGRAMS\n");
            View.WriteLine(string.Format("{0, -35 } {1, -20}", "Name", "Code"));
            foreach (Program p in DbController.GetPrograms())
            {
                View.WriteLine(string.Format("{0, -35 } {1, -20}", p.Name, p.GetString()));
            }
            View.WriteLine("");
        }
        private void DisplayTeachers()
        {
            View.WriteLine("PROGRAMS\n");
            View.WriteLine(string.Format("{0, -35 } {1, -20}", "Name", "Code"));
            foreach (Program p in DbController.GetPrograms())
            {
                View.WriteLine(string.Format("{0, -35 } {1, -20}", p.Name, p.GetString()));
            }
            View.WriteLine("");
        }

        private void DisplayPause()
        {
            View.WriteLine("Press \"Enter\" to continue...");
            View.ReadLine();
        }
    }
}
