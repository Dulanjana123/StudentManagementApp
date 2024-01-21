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
    public partial class frmStudent : Form
    {
        private Student student;
        public frmStudent()
        {
            InitializeComponent();
            student = new Student();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtStudentname.Text == "")
                {
                    MessageBox.Show("Student Name Required", "Error",  MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (txtFirstName.Text == "")
                {
                    MessageBox.Show("FirstName Required", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (txtLastName.Text == "")
                {
                    MessageBox.Show("LastName Required", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (txtPhone.Text == "")
                {
                    MessageBox.Show("Phone number Required", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (txtAddress.Text == "")
                {
                    MessageBox.Show("Address Required", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (cmbGender.Text == "")
                {
                    MessageBox.Show("Gender Required", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

                else
                {
                    student.StudentName = txtStudentname.Text;
                    student.FirstName = txtFirstName.Text;
                    student.LastName = txtLastName.Text;
                    student.Phone = txtPhone.Text;
                    student.Address = txtAddress.Text;
                    student.Gender = cmbGender.Text;
                    student.IsActive = chkIsActive.Checked;

                    if (student.Id == 0)
                    {

                        student.save();
                        this.txtId.Text = student.Id.ToString();
                        MessageBox.Show("student successfully saved", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    else
                    {
                        student.update();
                        MessageBox.Show("student successfully updated", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }

                    setDataGridValues();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setDataGridValues()
        {
            dgvStudents.DataSource = MasterFileController.Instance.GetStudentDataTable();

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtStudentname.Text = "";
            txtPhone.Text = "";
            chkIsActive.Checked = false;
            cmbGender.Text = "";
            txtAddress.Text = "";
            
            student = new Student();
        }

        private void frmStudent_Load(object sender, EventArgs e)
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

        private void dgvStudents_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    student = new Student(int.Parse(dgvStudents.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    txtId.Text = student.Id.ToString();
                    txtStudentname.Text = student.StudentName;
                    txtFirstName.Text = student.FirstName;
                    txtLastName.Text = student.LastName;
                    txtAddress.Text = student.Address;
                    txtPhone.Text = student.Phone;
                    cmbGender.Text = student.Gender;
                   
                    chkIsActive.Checked = student.IsActive;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
