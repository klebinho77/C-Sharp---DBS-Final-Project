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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "Admin" && txtpwd.Text == "12345")
            {
                College frm = new College();
                frm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Username or Password incorrect.", "Invalid Login, please try again ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
