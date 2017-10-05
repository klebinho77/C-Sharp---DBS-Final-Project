using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCollegeSyst
{
    public partial class RegEmployee : Form
    {

        ListClass em = new ListClass();

        public RegEmployee()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnRegEmp_Click(object sender, EventArgs e)
        {
          
        }

        private void btnEmpDisplay_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtEmpName.Text;
                string phone = txtEmpPhone.Text;
                string email = txtEmpEmail.Text;
                int salary = int.Parse(txtEmpSalary.Text);

                lblRemarks.Text = em.AddEmployee(name, phone, email, salary);
            }
            catch
            {
                MessageBox.Show("Fill all fields");
            }
            txtEmpName.Text = " ";
            txtEmpPhone.Text = " ";
            txtEmpEmail.Text = " ";
            txtEmpSalary.Text = " ";
        }

        private void btnEmpDisplay_Click_1(object sender, EventArgs e)
        {
            listBox1Employee.Items.Clear();
            foreach (Employee em in em.Employees)
            {
                listBox1Employee.Items.Add(em.GetAllEmployee());
            }
        }
    }
}
