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
    public partial class frmLecturer : Form
    {
        public frmLecturer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }



        private void rbtPermanent_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtPermanent.Checked)
            {
                tabControl.TabPages.Add(tpPermanent);
                tabControl.TabPages.Remove(tpTemporary);
            }
        }



        private void frmLecturer_Load(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tpTemporary);
        }

        private void rbtTemporary_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTemporary.Checked)
            {
                tabControl.TabPages.Add(tpTemporary);
                tabControl.TabPages.Remove(tpPermanent);
            }
        }

        private void txtCostForMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
