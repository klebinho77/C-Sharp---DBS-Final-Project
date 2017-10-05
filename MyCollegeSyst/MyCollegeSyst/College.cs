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
    public partial class College : Form
    {
        public College()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
        }

        private void calcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegTeacher frmcT = new RegTeacher();
            frmcT.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegEmployee frmcE = new RegEmployee();
            frmcE.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void estudanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterStudent frmcS = new RegisterStudent();
            frmcS.Show();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            Tools frmcT = new Tools();
            frmcT.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frmcT = new About();
            frmcT.Show();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            About frmcT = new About();
            frmcT.Show();
        }
    }
}
