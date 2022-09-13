namespace RPN_Calculator.Model
{
    public class Student
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }

        public Student(string fName, string lName, string email)
        {
            FName = fName;
            LName = lName;
            Email = email;
        }

        public string GetString() { return $"Firstname = {FName}, Lastname = {LName}, Email = {Email}"; }
    }
}
