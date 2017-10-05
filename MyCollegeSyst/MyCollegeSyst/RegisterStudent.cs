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
    public partial class RegisterStudent : Form
    {
        ListClass stud = new ListClass();

        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void btnAddStud_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtStudID.Text);
                string name = txtStudName.Text;
                string phone = txtStudPhone.Text;
                string email = txtStudEmail.Text;
                string status = cbxStudStatus.Text;

                lblRemarks.Text = stud.AddStudent(id, name, phone, email, status);
            }
            catch
            {
                MessageBox.Show("Fill all fields");
            }
            txtStudID.Text = " ";
            txtStudName.Text = " ";
            txtStudPhone.Text = " ";
            txtStudEmail.Text = " ";
            cbxStudStatus.Text = " ";
        }

        private void btnStudDisplay_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(Student s in stud.Students)
            {
                listBox1.Items.Add(s.GetAllStudents());
            }
        }
    }
}
