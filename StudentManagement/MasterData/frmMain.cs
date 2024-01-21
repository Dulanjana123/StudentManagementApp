using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationClass;

namespace StudentManagement
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "User:" + MainController.Instance.LoggedUser.UserName;
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser objMain = new frmUser();
            objMain.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudent objMain = new frmStudent();
            objMain.Show();
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourse objMain = new frmCourse();
            objMain.Show();
        }

        private void lecturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLecturer objMain = new frmLecturer();
            objMain.Show();
        }
    }
}
