namespace AlShamModelSchool.Students.UserControls
{
    partial class ucStudentInfo
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
            this.ucPersonInfo1 = new AlShamModelSchool.People.UserControls.ucPersonInfo();
            this.lbFatherName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbMotherName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbStudentNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ucPersonInfo1
            // 
            this.ucPersonInfo1.Location = new System.Drawing.Point(3, 3);
            this.ucPersonInfo1.Name = "ucPersonInfo1";
            this.ucPersonInfo1.ShowUserIDFiled = false;
            this.ucPersonInfo1.Size = new System.Drawing.Size(671, 273);
            this.ucPersonInfo1.TabIndex = 0;
            this.ucPersonInfo1.Title = "Person Details";
            // 
            // lbFatherName
            // 
            this.lbFatherName.AutoSize = true;
            this.lbFatherName.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFatherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lbFatherName.Location = new System.Drawing.Point(121, 279);
            this.lbFatherName.Name = "lbFatherName";
            this.lbFatherName.Size = new System.Drawing.Size(45, 25);
            this.lbFatherName.TabIndex = 15;
            this.lbFatherName.Text = "...........";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(16, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Father Name   :";
            // 
            // lbMotherName
            // 
            this.lbMotherName.AutoSize = true;
            this.lbMotherName.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lbMotherName.Location = new System.Drawing.Point(121, 311);
            this.lbMotherName.Name = "lbMotherName";
            this.lbMotherName.Size = new System.Drawing.Size(45, 25);
            this.lbMotherName.TabIndex = 17;
            this.lbMotherName.Text = "...........";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(16, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mother Name  :";
            // 
            // lbStudentNumber
            // 
            this.lbStudentNumber.AutoSize = true;
            this.lbStudentNumber.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lbStudentNumber.Location = new System.Drawing.Point(520, 278);
            this.lbStudentNumber.Name = "lbStudentNumber";
            this.lbStudentNumber.Size = new System.Drawing.Size(45, 25);
            this.lbStudentNumber.TabIndex = 19;
            this.lbStudentNumber.Text = "...........";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(396, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Student Number  :";
            // 
            // ucStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbStudentNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMotherName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFatherName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ucPersonInfo1);
            this.Name = "ucStudentInfo";
            this.Size = new System.Drawing.Size(749, 354);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private People.UserControls.ucPersonInfo ucPersonInfo1;
        private System.Windows.Forms.Label lbFatherName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbMotherName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbStudentNumber;
        private System.Windows.Forms.Label label3;
    }
}
