namespace RPN_Calculator.Model
{
    public class Teacher
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string TelNumber { get; set; }
        public string Signature { get; set; }

        public Teacher(string fName, string lName, string email, string telNumber, string signature)
        {
            FName = fName;
            LName = lName;
            Email = email;
            TelNumber = telNumber;
            Signature = signature;
        }

        public string GetString()
        {
            return $"First name = {FName}, Last name = {LName}, Email = {Email}, " +
                $"Telephone number = {TelNumber}, Signature = {Signature}";
        }
    }
}
