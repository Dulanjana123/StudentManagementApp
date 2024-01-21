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
    public partial class frmUser : Form
    {
        private User user;
        public frmUser()
        {
            InitializeComponent();
            user = new User();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                if(txtUserName.Text == "")
                {
                    MessageBox.Show("UserName Required", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    
                }
                else if (txtFirstName.Text == "")
                {
                    MessageBox.Show("FirstName Required", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (txtLastName.Text == "")
                {
                    MessageBox.Show("LastName Required", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Password Required", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

                else
                {
                    user.UserName = txtUserName.Text;
                    user.FirstName =txtFirstName.Text;
                    user.LastName = txtLastName.Text;
                    user.Password = txtPassword.Text;
                    user.IsActive = chkIsActive.Checked;

                    if(user.Id == 0)
                    {
      
                        user.save();
                        this.txtId.Text = user.Id.ToString();
                        MessageBox.Show("User successfully saved", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        
                        
                    }
                    else
                    {
                        user.update();
                        MessageBox.Show("User successfully updated", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }

                    setDataGridValues();
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void lblIsActive_Click(object sender, EventArgs e)
        {

        }

        private void frmUser_Load(object sender, EventArgs e)
        {

            try
            {
                setDataGridValues();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// This method get values from user table
        /// to fill data grid values
        /// </summary>
        private void setDataGridValues()
        {
            dgvUsers.DataSource = MasterFileController.Instance.GetUserDataTable();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            chkIsActive.Checked = false;
            user = new User();

        }

        private void dgvUsers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if(e.RowIndex != -1)
                {
                    user = new User(int.Parse(dgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    txtFirstName.Text = user.FirstName;
                    txtUserName.Text = user.UserName;
                    txtLastName.Text = user.LastName;
                    txtId.Text = user.Id.ToString();
                    txtPassword.Text = user.Password;
                    chkIsActive.Checked = user.IsActive;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
