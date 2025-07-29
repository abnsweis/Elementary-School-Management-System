namespace AlShamModelSchool.UserControls
{
    partial class ucClassSubjectTeacherSelector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbSubjectName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectTeacher = new Guna.UI2.WinForms.Guna2Button();
            this.ucTeacherShortInfo1 = new AlShamModelSchool.Teachers.UserControls.ucTeacherShortInfo();
            this.SuspendLayout();
            // 
            // lbSubjectName
            // 
            this.lbSubjectName.AutoSize = true;
            this.lbSubjectName.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lbSubjectName.Location = new System.Drawing.Point(627, 17);
            this.lbSubjectName.Name = "lbSubjectName";
            this.lbSubjectName.Size = new System.Drawing.Size(43, 22);
            this.lbSubjectName.TabIndex = 35;
            this.lbSubjectName.Text = "...........";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(515, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Subject Name :";
            // 
            // btnSelectTeacher
            // 
            this.btnSelectTeacher.BorderRadius = 5;
            this.btnSelectTeacher.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelectTeacher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectTeacher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectTeacher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectTeacher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelectTeacher.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btnSelectTeacher.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectTeacher.ForeColor = System.Drawing.Color.White;
            this.btnSelectTeacher.Location = new System.Drawing.Point(862, 10);
            this.btnSelectTeacher.Name = "btnSelectTeacher";
            this.btnSelectTeacher.Size = new System.Drawing.Size(151, 38);
            this.btnSelectTeacher.TabIndex = 63;
            this.btnSelectTeacher.Text = "Select Teacher";
            this.btnSelectTeacher.Click += new System.EventHandler(this.btnSelectTeacher_Click);
            // 
            // ucTeacherShortInfo1
            // 
            this.ucTeacherShortInfo1.BackColor = System.Drawing.Color.Transparent;
            this.ucTeacherShortInfo1.EnabledViewButton = true;
            this.ucTeacherShortInfo1.Location = new System.Drawing.Point(3, 3);
            this.ucTeacherShortInfo1.Name = "ucTeacherShortInfo1";
            this.ucTeacherShortInfo1.ShowSelectButton = false;
            this.ucTeacherShortInfo1.Size = new System.Drawing.Size(510, 54);
            this.ucTeacherShortInfo1.TabIndex = 64;
            this.ucTeacherShortInfo1.TeacherID = 0;
            // 
            // ucClassSubjectTeacherSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.ucTeacherShortInfo1);
            this.Controls.Add(this.btnSelectTeacher);
            this.Controls.Add(this.lbSubjectName);
            this.Controls.Add(this.label2);
            this.Name = "ucClassSubjectTeacherSelector";
            this.Size = new System.Drawing.Size(1029, 62);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbSubjectName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnSelectTeacher;
        private Teachers.UserControls.ucTeacherShortInfo ucTeacherShortInfo1;
    }
}
