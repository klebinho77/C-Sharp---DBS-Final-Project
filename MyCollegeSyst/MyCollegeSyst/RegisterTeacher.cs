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
    public partial class RegTeacher : Form
    {
        ListClass tea = new ListClass();

        public RegTeacher()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegTeacher_Click(object sender, EventArgs e)
        {
        }

        private void btnTeaDisplay_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAddStud_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtTeaName.Text;
                string phone = txtTeaPhone.Text;
                string email = txtTeaEmail.Text;
                int salary = int.Parse(txtTeaSalary.Text);
                string taught = txtTeaTaught.Text;
               

                lblRemarks.Text = tea.AddTeacher(name, phone, email, salary, taught);
            }
            catch
            {
                MessageBox.Show("Fill all fields");
            }
            txtTeaName.Text = " ";
            txtTeaPhone.Text = " ";
            txtTeaEmail.Text = " ";
            txtTeaSalary.Text = " ";
            txtTeaTaught.Text = " ";


        }

        private void btnStudDisplay_Click(object sender, EventArgs e)
        {
          
        }

        private void btnTeaDisplay_Click_1(object sender, EventArgs e)
        {
            listBox1Teacher.Items.Clear();
            foreach(Teacher tea in tea.Teachers)
            {
                listBox1Teacher.Items.Add(tea.GetAllTeacher());
            }
        }
    }
}
