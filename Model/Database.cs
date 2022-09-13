namespace Workshop2.Model
{
    public class Database
    {
        public List<Student> Students { get; protected set; }
        public List<Teacher> Teachers { get; protected set; }
        public List<Course> Courses { get; protected set; }
        public List<Program> Programs { get; protected set; }

        public Database()
        {
            Students = new List<Student>();
            Teachers = new List<Teacher>();
            Courses = new List<Course>();
            Programs = new List<Program>();
        }
    }
}
