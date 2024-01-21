using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ApplicationClass;







namespace StudentManagement
{
    public partial class frmLogin : Form
    {

        
        public frmLogin()
        {

            InitializeComponent();

            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtUsername.Text))
                {
                    MessageBox.Show("Username required", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (String.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Password required", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    bool loginResult = MainController.Instance.DoLogin(txtUsername.Text, txtPassword.Text);
                    if (loginResult == true)
                    {
                        frmMain objMain = new frmMain();
                        this.Hide();
                        objMain.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login Fail", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
