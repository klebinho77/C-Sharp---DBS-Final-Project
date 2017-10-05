using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollegeSyst
{
    public class Person
    {
        public int StudentID { get; set; }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public string Status { get; set; }//dropbox
        public string Taught { get; set; }
        public string Salary { get; set; }

        public string GetAll()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(StudentID);
            sb.Append(" ");
            sb.Append(Name);
            sb.Append(" ");
            sb.Append(Phone);
            sb.Append(" ");
            sb.Append(Email);
            sb.Append(" ");
            sb.Append(Status);
            sb.Append(" ");
            sb.Append(Taught);
            sb.Append(" ");
            sb.Append(Salary);
            sb.Append(" ");
            return sb.ToString();
        }

        public string GetStudent()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(StudentID);
            sb.Append(" ");
            sb.Append(Name);
            sb.Append(" ");
            sb.Append(Phone);
            sb.Append(" ");
            sb.Append(Email);
            sb.Append(" ");
            sb.Append(Status);
            sb.Append(" ");
            return sb.ToString();
        }


        public string GetEmployee()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" ");
            sb.Append(Phone);
            sb.Append(" ");
            sb.Append(Email);
            sb.Append(" ");
            sb.Append(Salary);
            sb.Append(" ");
            return sb.ToString();
        }

        public string GetTeacher()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" ");
            sb.Append(Phone);
            sb.Append(" ");
            sb.Append(Email);
            sb.Append(" ");
            sb.Append(Salary);
            sb.Append(" ");
            sb.Append(Taught);
            sb.Append(" ");
            return sb.ToString();
        }

    }
}