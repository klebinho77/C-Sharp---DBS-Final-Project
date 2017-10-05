using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollegeSyst
{
    class Student : Person
    {
        public int StudID { get; set; }
        public String Status { get; set; }

        public string GetAllStudents()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(StudID);
            sb.Append(" ");
            sb.Append(base.GetAll());
            sb.Append(Status);
            sb.Append(" ");

            return sb.ToString();

        }
       
    }
}
