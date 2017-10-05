using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollegeSyst
{
    class ListClass
    {
        public List<Student> Students;
        public List<Employee> Employees;
        public List<Teacher> Teachers;

        public ListClass()
        {
            Students = new List<Student>();
            Employees = new List<Employee>();
            Teachers = new List<Teacher>();
        }

        public string AddStudent(int id, string name, string phone, string email, string status)
        {
            Student s = new Student();
            s.StudID = id;
            s.Name = name;
            s.Phone = phone;
            s.Email = email;
            s.Status = status;

            Students.Add(s);

            return "Added student to list";
        }

        public string AddEmployee(string name, string phone, string email, int salary)
        {
            Employee em = new Employee();
            em.Name = name;
            em.Phone = phone;
            em.Email = email;
            em.Salary = salary;

            Employees.Add(em);

            return "Added employee to list";
        }

        public string AddTeacher(string name, string phone, string email, int salary, string taught)
        {
            Teacher tea = new Teacher();
            tea.Name = name;
            tea.Phone = phone;
            tea.Email = email;
            tea.Salary = salary;
            tea.Taught = taught;

            Teachers.Add(tea);

            return "Added employee to list";
        }
    }
}
