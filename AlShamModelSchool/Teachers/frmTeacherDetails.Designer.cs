namespace AlShamModelSchool.Teachers
{
    partial class frmTeacherDetails
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
            this.usTeacherDetails1 = new AlShamModelSchool.Teachers.UserControls.usTeacherDetails();
            this.SuspendLayout();
            // 
            // usTeacherDetails1
            // 
            this.usTeacherDetails1.Location = new System.Drawing.Point(12, 12);
            this.usTeacherDetails1.Name = "usTeacherDetails1";
            this.usTeacherDetails1.Size = new System.Drawing.Size(691, 475);
            this.usTeacherDetails1.TabIndex = 0;
            // 
            // frmTeacherDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.usTeacherDetails1);
            this.Name = "frmTeacherDetails";
            this.Text = "frmTeacherDetails";
            this.Load += new System.EventHandler(this.frmTeacherDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.usTeacherDetails usTeacherDetails1;
    }
}