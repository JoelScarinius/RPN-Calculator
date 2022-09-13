using Workshop2.Model;

namespace Workshop2.Controller
{
    public class DatabaseController
    {
        private Database database;

        //param name = "database"; 

        public DatabaseController(Database database) { this.database = database; }

        public Program AddProgram(Program program) { database.Programs.Add(program); return program; }

        public void RemoveProgram() { }
        public Student AddStudent(Student student) { database.Students.Add(student); return student; }
        public Teacher AddTeacher(Teacher teacher) { database.Teachers.Add(teacher); return teacher; }
        public void RemovePerson() { }
        public void AddRoom(string roomName) { }
        public void RemoveRoom(string roomName) { }
        public void AddCourseMoment() { }
        public void RemoveCourseMoment(string courseMoment) { }
        public void AddSchedule() { }
        public void RemoveSchedule(string scheduleName) { }


        public List<Student> GetStudents() { return database.Students; }
        public List<Program> GetPrograms() { return database.Programs; }

        public List<Teacher> GetTeachers() { return database.Teachers; }

    }

}

