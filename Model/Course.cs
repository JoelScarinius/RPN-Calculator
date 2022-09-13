namespace RPN_Calculator.Model
{
    public class Course : IStringRepresentable
    {
        public string Name { get; protected set; }
        public string Code { get; protected set; }
        public int Up { get; protected set; }

        public Course(string name, string code, int up)
        {
            Name = name;
            Code = code;
            Up = up;
        }

        public string GetString() { return $"Name = {Name}, Code = {Code}"; }
    }
}
