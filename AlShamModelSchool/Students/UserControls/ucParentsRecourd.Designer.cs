namespace AlShamModelSchool.Students.UserControls
{
    partial class ucParentsRecourd
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
            this.FatherBox = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.lbFatherNationalID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblParentType = new System.Windows.Forms.Label();
            this.lbFatherName = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbMotherName = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbMatherNationalID = new System.Windows.Forms.Label();
            this.MotherBox = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.FatherBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.MotherBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FatherBox
            // 
            this.FatherBox.BorderRadius = 5;
            this.FatherBox.Controls.Add(this.lbFatherNationalID);
            this.FatherBox.Controls.Add(this.label9);
            this.FatherBox.Controls.Add(this.lblParentType);
            this.FatherBox.Controls.Add(this.lbFatherName);
            this.FatherBox.Controls.Add(this.guna2PictureBox1);
            this.FatherBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FatherBox.Location = new System.Drawing.Point(0, 3);
            this.FatherBox.Name = "FatherBox";
            this.FatherBox.Size = new System.Drawing.Size(426, 46);
            this.FatherBox.TabIndex = 53;
            this.FatherBox.Text = "guna2ContainerControl1";
            this.FatherBox.Click += new System.EventHandler(this.FatherBox_Click);
            // 
            // lbFatherNationalID
            // 
            this.lbFatherNationalID.AutoSize = true;
            this.lbFatherNationalID.BackColor = System.Drawing.Color.Transparent;
            this.lbFatherNationalID.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lbFatherNationalID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lbFatherNationalID.Location = new System.Drawing.Point(337, 13);
            this.lbFatherNationalID.Name = "lbFatherNationalID";
            this.lbFatherNationalID.Size = new System.Drawing.Size(43, 22);
            this.lbFatherNationalID.TabIndex = 51;
            this.lbFatherNationalID.Text = "...........";
            this.lbFatherNationalID.Click += new System.EventHandler(this.FatherBox_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Indigo;
            this.label9.Location = new System.Drawing.Point(255, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 22);
            this.label9.TabIndex = 50;
            this.label9.Text = "National ID  :";
            this.label9.Click += new System.EventHandler(this.FatherBox_Click);
            // 
            // lblParentType
            // 
            this.lblParentType.AutoSize = true;
            this.lblParentType.BackColor = System.Drawing.Color.Transparent;
            this.lblParentType.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentType.ForeColor = System.Drawing.Color.Indigo;
            this.lblParentType.Location = new System.Drawing.Point(54, 13);
            this.lblParentType.Name = "lblParentType";
            this.lblParentType.Size = new System.Drawing.Size(47, 22);
            this.lblParentType.TabIndex = 47;
            this.lblParentType.Text = "Name :";
            this.lblParentType.Click += new System.EventHandler(this.FatherBox_Click);
            // 
            // lbFatherName
            // 
            this.lbFatherName.AutoSize = true;
            this.lbFatherName.BackColor = System.Drawing.Color.Transparent;
            this.lbFatherName.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFatherName.ForeColor = System.Drawing.Color.Indigo;
            this.lbFatherName.Location = new System.Drawing.Point(97, 13);
            this.lbFatherName.Name = "lbFatherName";
            this.lbFatherName.Size = new System.Drawing.Size(86, 22);
            this.lbFatherName.TabIndex = 49;
            this.lbFatherName.Text = "Father Name :";
            this.lbFatherName.Click += new System.EventHandler(this.FatherBox_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::AlShamModelSchool.Properties.Resources.MalePersonDefaultImage;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(52, 46);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 52;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.FatherBox_Click);
            // 
            // lbMotherName
            // 
            this.lbMotherName.AutoSize = true;
            this.lbMotherName.BackColor = System.Drawing.Color.Transparent;
            this.lbMotherName.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotherName.ForeColor = System.Drawing.Color.Indigo;
            this.lbMotherName.Location = new System.Drawing.Point(97, 13);
            this.lbMotherName.Name = "lbMotherName";
            this.lbMotherName.Size = new System.Drawing.Size(91, 22);
            this.lbMotherName.TabIndex = 49;
            this.lbMotherName.Text = "Mother Name :";
            this.lbMotherName.Click += new System.EventHandler(this.FatherBox_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Indigo;
            this.label14.Location = new System.Drawing.Point(54, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 22);
            this.label14.TabIndex = 47;
            this.label14.Text = "Name :";
            this.label14.Click += new System.EventHandler(this.FatherBox_Click);
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox4.Image = global::AlShamModelSchool.Properties.Resources.FemalePersonDefaultImage;
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(4, 2);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(53, 46);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 48;
            this.guna2PictureBox4.TabStop = false;
            this.guna2PictureBox4.Click += new System.EventHandler(this.FatherBox_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Indigo;
            this.label13.Location = new System.Drawing.Point(255, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 22);
            this.label13.TabIndex = 50;
            this.label13.Text = "National ID  :";
            this.label13.Click += new System.EventHandler(this.FatherBox_Click);
            // 
            // lbMatherNationalID
            // 
            this.lbMatherNationalID.AutoSize = true;
            this.lbMatherNationalID.BackColor = System.Drawing.Color.Transparent;
            this.lbMatherNationalID.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lbMatherNationalID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lbMatherNationalID.Location = new System.Drawing.Point(337, 13);
            this.lbMatherNationalID.Name = "lbMatherNationalID";
            this.lbMatherNationalID.Size = new System.Drawing.Size(43, 22);
            this.lbMatherNationalID.TabIndex = 51;
            this.lbMatherNationalID.Text = "...........";
            this.lbMatherNationalID.Click += new System.EventHandler(this.FatherBox_Click);
            // 
            // MotherBox
            // 
            this.MotherBox.Controls.Add(this.lbMatherNationalID);
            this.MotherBox.Controls.Add(this.label13);
            this.MotherBox.Controls.Add(this.guna2PictureBox4);
            this.MotherBox.Controls.Add(this.label14);
            this.MotherBox.Controls.Add(this.lbMotherName);
            this.MotherBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MotherBox.Location = new System.Drawing.Point(426, 2);
            this.MotherBox.Name = "MotherBox";
            this.MotherBox.Size = new System.Drawing.Size(426, 46);
            this.MotherBox.TabIndex = 55;
            this.MotherBox.Text = "guna2ContainerControl3";
            this.MotherBox.Click += new System.EventHandler(this.FatherBox_Click);
            // 
            // ucParentsRecourd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MotherBox);
            this.Controls.Add(this.FatherBox);
            this.Name = "ucParentsRecourd";
            this.Size = new System.Drawing.Size(874, 50);
            this.Load += new System.EventHandler(this.ucParentsRecourd_Load);
            this.FatherBox.ResumeLayout(false);
            this.FatherBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.MotherBox.ResumeLayout(false);
            this.MotherBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContainerControl FatherBox;
        private System.Windows.Forms.Label lbFatherNationalID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblParentType;
        private System.Windows.Forms.Label lbFatherName;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lbMotherName;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbMatherNationalID;
        private Guna.UI2.WinForms.Guna2ContainerControl MotherBox;
    }
}
