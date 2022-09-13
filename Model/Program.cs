﻿using Workshop2.Model;

namespace Workshop2
{
    public class Program : IStringRepresentable
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public ProgramType Programtype { get; set; }
        public DateTime StartDate { get; set; }

        public Program(string name, ProgramType programtype, DateTime startDate)
        {
            Name = name;
            Programtype = programtype;
            StartDate = startDate;

            string semester = (StartDate.Month >= 9 && StartDate.Month <= 12) ? "h" : "v";
            string startYear = StartDate.Year.ToString().Substring(2, 2);
            Code = string.Format("{0}{1}{2}", Enum.GetName(Programtype.GetType(), Programtype), startYear, semester);
        }

        public string GetString()
        {
            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine($"Name = {Name}, Code = {Code}, Programtype = {Programtype}, Startdate = {StartDate}");
            //foreach (Student s in students)
            //{
            //    sb.AppendLine(s.GetString());
            //}
            //return sb.ToString();
            return Code;
        }
    }
}