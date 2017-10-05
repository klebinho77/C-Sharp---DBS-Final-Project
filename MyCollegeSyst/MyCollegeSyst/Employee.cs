using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollegeSyst
{
    class Employee : Person
    {
        public int Salary { get; set; }

        public string GetAllEmployee()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.GetAll());
            sb.Append("");
            sb.Append(Salary);
            sb.Append("");

            return sb.ToString();
        }
    }
}
