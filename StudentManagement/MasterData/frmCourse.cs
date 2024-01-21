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
    public partial class frmCourse : Form
    {
        private Course course;
        public frmCourse()
        {
            InitializeComponent();
            course = new Course();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCourseName.Text == "")
                {
                    MessageBox.Show("CourseName Required", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (txtHours.Text == "")
                {
                    MessageBox.Show("Hours Required", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (txtDiscription.Text == "")
                {
                    MessageBox.Show("Discription Required", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

                else
                {
                    course.CourseName = txtCourseName.Text;
                    course.CourseHours = txtHours.Text;
                    course.Description = txtDiscription.Text;
                    course.IsActive = chkIsActive.Checked;

                    if (course.Id == 0)
                    {
                       
                            course.save();
                            this.txtId.Text = course.Id.ToString();
                            MessageBox.Show("Course successfully saved", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        

                    }
                    else
                    {
                        course.update();
                        MessageBox.Show("Course successfully updated", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
            dgvCourse.DataSource = MasterFileController.Instance.GetCourseDataTable();

        }

        private void frmCourse_Load(object sender, EventArgs e)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtCourseName.Text = "";
            txtDiscription.Text = "";
            txtHours.Text = "";
            chkIsActive.Checked = false;
           
            course = new Course();
        }

        private void dgvCourse_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    course = new Course(int.Parse(dgvCourse.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    txtId.Text = course.Id.ToString();
                    txtCourseName.Text = course.CourseName;
                    txtHours.Text = course.CourseHours;
                    txtDiscription.Text = course.Description;
                    chkIsActive.Checked = course.IsActive;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
