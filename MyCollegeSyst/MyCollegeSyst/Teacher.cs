using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollegeSyst
{
    class Teacher : Employee
    {
        public string Taught { get; set; }

        public string GetAllTeacher()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.GetAll());
            sb.Append(Salary);
            sb.Append(" ");
            sb.Append(Taught);
            sb.Append(" ");

            return sb.ToString();
        }
    }
}
