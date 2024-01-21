
namespace StudentManagement
{
    partial class frmLecturer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpPermanent = new System.Windows.Forms.TabPage();
            this.lblRecruiteDate = new System.Windows.Forms.Label();
            this.tpTemporary = new System.Windows.Forms.TabPage();
            this.lblCost = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.rbtTemporary = new System.Windows.Forms.RadioButton();
            this.rbtPermanent = new System.Windows.Forms.RadioButton();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtNic = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblNic = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dtpRecruiteDate = new System.Windows.Forms.DateTimePicker();
            this.lblCostForMonth = new System.Windows.Forms.Label();
            this.txtCostForMonth = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.tabControl.SuspendLayout();
            this.tpPermanent.SuspendLayout();
            this.tpTemporary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpPermanent);
            this.tabControl.Controls.Add(this.tpTemporary);
            this.tabControl.Location = new System.Drawing.Point(37, 85);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(346, 162);
            this.tabControl.TabIndex = 60;
            // 
            // tpPermanent
            // 
            this.tpPermanent.Controls.Add(this.txtCostForMonth);
            this.tpPermanent.Controls.Add(this.lblCostForMonth);
            this.tpPermanent.Controls.Add(this.dtpRecruiteDate);
            this.tpPermanent.Controls.Add(this.lblRecruiteDate);
            this.tpPermanent.Location = new System.Drawing.Point(4, 22);
            this.tpPermanent.Name = "tpPermanent";
            this.tpPermanent.Size = new System.Drawing.Size(338, 136);
            this.tpPermanent.TabIndex = 0;
            this.tpPermanent.Text = "Permanent";
            this.tpPermanent.UseVisualStyleBackColor = true;
            // 
            // lblRecruiteDate
            // 
            this.lblRecruiteDate.AutoSize = true;
            this.lblRecruiteDate.Location = new System.Drawing.Point(5, 61);
            this.lblRecruiteDate.Name = "lblRecruiteDate";
            this.lblRecruiteDate.Size = new System.Drawing.Size(73, 13);
            this.lblRecruiteDate.TabIndex = 0;
            this.lblRecruiteDate.Text = "Recruite Date";
            // 
            // tpTemporary
            // 
            this.tpTemporary.Controls.Add(this.dtpEndDate);
            this.tpTemporary.Controls.Add(this.dtpStartDate);
            this.tpTemporary.Controls.Add(this.lblEndDate);
            this.tpTemporary.Controls.Add(this.lblStartDate);
            this.tpTemporary.Controls.Add(this.txtCost);
            this.tpTemporary.Controls.Add(this.lblCost);
            this.tpTemporary.Location = new System.Drawing.Point(4, 22);
            this.tpTemporary.Name = "tpTemporary";
            this.tpTemporary.Size = new System.Drawing.Size(338, 136);
            this.tpTemporary.TabIndex = 1;
            this.tpTemporary.Text = "Temporary";
            this.tpTemporary.UseVisualStyleBackColor = true;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(12, 12);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 0;
            this.lblCost.Text = "Cost";
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(511, 185);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(286, 21);
            this.cmbCourse.TabIndex = 47;
            // 
            // rbtTemporary
            // 
            this.rbtTemporary.AutoSize = true;
            this.rbtTemporary.Location = new System.Drawing.Point(37, 51);
            this.rbtTemporary.Name = "rbtTemporary";
            this.rbtTemporary.Size = new System.Drawing.Size(75, 17);
            this.rbtTemporary.TabIndex = 50;
            this.rbtTemporary.Text = "Temporary";
            this.rbtTemporary.UseVisualStyleBackColor = true;
            this.rbtTemporary.CheckedChanged += new System.EventHandler(this.rbtTemporary_CheckedChanged);
            // 
            // rbtPermanent
            // 
            this.rbtPermanent.AutoSize = true;
            this.rbtPermanent.Checked = true;
            this.rbtPermanent.Location = new System.Drawing.Point(37, 28);
            this.rbtPermanent.Name = "rbtPermanent";
            this.rbtPermanent.Size = new System.Drawing.Size(76, 17);
            this.rbtPermanent.TabIndex = 49;
            this.rbtPermanent.TabStop = true;
            this.rbtPermanent.Text = "Permanent";
            this.rbtPermanent.UseVisualStyleBackColor = true;
            this.rbtPermanent.CheckedChanged += new System.EventHandler(this.rbtPermanent_CheckedChanged);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(37, 273);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(851, 205);
            this.dgvUsers.TabIndex = 59;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(677, 239);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 52;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(581, 239);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Location = new System.Drawing.Point(511, 223);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(15, 14);
            this.chkIsActive.TabIndex = 48;
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(511, 145);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(286, 20);
            this.txtLastName.TabIndex = 46;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(511, 104);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(286, 20);
            this.txtFirstName.TabIndex = 45;
            // 
            // txtNic
            // 
            this.txtNic.Location = new System.Drawing.Point(511, 62);
            this.txtNic.Name = "txtNic";
            this.txtNic.Size = new System.Drawing.Size(286, 20);
            this.txtNic.TabIndex = 44;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(511, 27);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(145, 20);
            this.txtId.TabIndex = 43;
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Location = new System.Drawing.Point(421, 224);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(48, 13);
            this.lblIsActive.TabIndex = 53;
            this.lblIsActive.Text = "Is Active";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(421, 193);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(40, 13);
            this.lblCourse.TabIndex = 54;
            this.lblCourse.Text = "Course";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(421, 152);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 55;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(421, 111);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 56;
            this.lblFirstName.Text = "First Name";
            // 
            // lblNic
            // 
            this.lblNic.AutoSize = true;
            this.lblNic.Location = new System.Drawing.Point(421, 65);
            this.lblNic.Name = "lblNic";
            this.lblNic.Size = new System.Drawing.Size(25, 13);
            this.lblNic.TabIndex = 57;
            this.lblNic.Text = "NIC";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(421, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 58;
            this.lblId.Text = "Id";
            // 
            // dtpRecruiteDate
            // 
            this.dtpRecruiteDate.Location = new System.Drawing.Point(85, 59);
            this.dtpRecruiteDate.Name = "dtpRecruiteDate";
            this.dtpRecruiteDate.Size = new System.Drawing.Size(240, 20);
            this.dtpRecruiteDate.TabIndex = 1;
            // 
            // lblCostForMonth
            // 
            this.lblCostForMonth.AutoSize = true;
            this.lblCostForMonth.Location = new System.Drawing.Point(10, 20);
            this.lblCostForMonth.Name = "lblCostForMonth";
            this.lblCostForMonth.Size = new System.Drawing.Size(28, 13);
            this.lblCostForMonth.TabIndex = 2;
            this.lblCostForMonth.Text = "Cost";
            // 
            // txtCostForMonth
            // 
            this.txtCostForMonth.Location = new System.Drawing.Point(85, 19);
            this.txtCostForMonth.Name = "txtCostForMonth";
            this.txtCostForMonth.Size = new System.Drawing.Size(240, 20);
            this.txtCostForMonth.TabIndex = 3;
            this.txtCostForMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostForMonth_KeyPress);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(48, 11);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(277, 20);
            this.txtCost.TabIndex = 1;
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            this.txtCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCost_KeyPress);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(12, 55);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(12, 88);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "End Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(76, 49);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(249, 20);
            this.dtpStartDate.TabIndex = 4;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(79, 88);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(245, 20);
            this.dtpEndDate.TabIndex = 5;
            // 
            // frmLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 490);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.rbtTemporary);
            this.Controls.Add(this.rbtPermanent);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtNic);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblIsActive);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblNic);
            this.Controls.Add(this.lblId);
            this.Name = "frmLecturer";
            this.Text = "frmLecturer";
            this.Load += new System.EventHandler(this.frmLecturer_Load);
            this.tabControl.ResumeLayout(false);
            this.tpPermanent.ResumeLayout(false);
            this.tpPermanent.PerformLayout();
            this.tpTemporary.ResumeLayout(false);
            this.tpTemporary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpPermanent;
        private System.Windows.Forms.Label lblRecruiteDate;
        private System.Windows.Forms.TabPage tpTemporary;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.RadioButton rbtTemporary;
        private System.Windows.Forms.RadioButton rbtPermanent;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtNic;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblNic;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtCostForMonth;
        private System.Windows.Forms.Label lblCostForMonth;
        private System.Windows.Forms.DateTimePicker dtpRecruiteDate;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
    }
}