namespace AlShamModelSchool.Teachers
{
    partial class frmUpdateTeacher
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
            this.flpSubjects = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbYearsOfExperience = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTeacherSalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.ucPersonInfo1 = new AlShamModelSchool.People.UserControls.ucPersonInfo();
            this.SuspendLayout();
            // 
            // flpSubjects
            // 
            this.flpSubjects.Location = new System.Drawing.Point(22, 404);
            this.flpSubjects.Name = "flpSubjects";
            this.flpSubjects.Size = new System.Drawing.Size(611, 100);
            this.flpSubjects.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 5;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btnSave.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(525, 515);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 36);
            this.btnSave.TabIndex = 107;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 5;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btnClose.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(366, 515);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 36);
            this.btnClose.TabIndex = 106;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(366, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 116;
            this.label3.Text = "Years Of Experience :";
            // 
            // cbYearsOfExperience
            // 
            this.cbYearsOfExperience.BackColor = System.Drawing.Color.Transparent;
            this.cbYearsOfExperience.BorderRadius = 5;
            this.cbYearsOfExperience.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbYearsOfExperience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYearsOfExperience.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbYearsOfExperience.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbYearsOfExperience.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbYearsOfExperience.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbYearsOfExperience.ItemHeight = 30;
            this.cbYearsOfExperience.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.cbYearsOfExperience.Location = new System.Drawing.Point(366, 326);
            this.cbYearsOfExperience.Name = "cbYearsOfExperience";
            this.cbYearsOfExperience.Size = new System.Drawing.Size(108, 36);
            this.cbYearsOfExperience.StartIndex = 0;
            this.cbYearsOfExperience.TabIndex = 3;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.BackColor = System.Drawing.Color.Transparent;
            this.lbError.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(25, 364);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(244, 18);
            this.lbError.TabIndex = 114;
            this.lbError.Tag = "It is not allowed to enter a value greater than 50,000";
            this.lbError.Text = "It is not allowed to enter a value greater than 50,000";
            this.lbError.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(18, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 113;
            this.label1.Text = "Salary   :";
            // 
            // tbTeacherSalary
            // 
            this.tbTeacherSalary.BorderRadius = 5;
            this.tbTeacherSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTeacherSalary.DefaultText = "";
            this.tbTeacherSalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTeacherSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTeacherSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTeacherSalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTeacherSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTeacherSalary.Font = new System.Drawing.Font("Dubai", 9.749999F);
            this.tbTeacherSalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTeacherSalary.Location = new System.Drawing.Point(22, 326);
            this.tbTeacherSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTeacherSalary.Name = "tbTeacherSalary";
            this.tbTeacherSalary.PasswordChar = '\0';
            this.tbTeacherSalary.PlaceholderText = "Enter Teacher Salary";
            this.tbTeacherSalary.SelectedText = "";
            this.tbTeacherSalary.Size = new System.Drawing.Size(274, 36);
            this.tbTeacherSalary.TabIndex = 2;
            this.tbTeacherSalary.TextChanged += new System.EventHandler(this.tbTeacherSalary_TextChanged);
            this.tbTeacherSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTeacherSalary_KeyPress);
            // 
            // ucPersonInfo1
            // 
            this.ucPersonInfo1.Location = new System.Drawing.Point(12, 12);
            this.ucPersonInfo1.Name = "ucPersonInfo1";
            this.ucPersonInfo1.ShowUserIDFiled = false;
            this.ucPersonInfo1.Size = new System.Drawing.Size(671, 272);
            this.ucPersonInfo1.TabIndex = 1;
            this.ucPersonInfo1.Title = "Person Details";
            // 
            // frmUpdateTeacher
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(687, 558);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbYearsOfExperience);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTeacherSalary);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.flpSubjects);
            this.Controls.Add(this.ucPersonInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmUpdateTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateTeacher";
            this.Load += new System.EventHandler(this.frmUpdateTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private People.UserControls.ucPersonInfo ucPersonInfo1;
        private System.Windows.Forms.FlowLayoutPanel flpSubjects;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbYearsOfExperience;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbTeacherSalary;
    }
}