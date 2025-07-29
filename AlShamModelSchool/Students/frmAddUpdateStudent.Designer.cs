namespace AlShamModelSchool.Students
{
    partial class frmAddUpdateStudent
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
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lbFatherNationalID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbMotherNationalID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbParentsID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbFatherName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMotherName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbStudentsNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbAdmissionDate = new System.Windows.Forms.Label();
            this.btnSelectParents = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ucPersonSelector1 = new AlShamModelSchool.People.UserControls.ucPersonSelector();
            this.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(418, 533);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 33);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnSave.Location = new System.Drawing.Point(584, 533);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 31);
            this.btnSave.TabIndex = 87;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbFatherNationalID
            // 
            this.lbFatherNationalID.AutoSize = true;
            this.lbFatherNationalID.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFatherNationalID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lbFatherNationalID.Location = new System.Drawing.Point(513, 322);
            this.lbFatherNationalID.Name = "lbFatherNationalID";
            this.lbFatherNationalID.Size = new System.Drawing.Size(45, 25);
            this.lbFatherNationalID.TabIndex = 86;
            this.lbFatherNationalID.Text = "...........";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(367, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 85;
            this.label6.Text = "Fathe National ID      :";
            // 
            // lbMotherNationalID
            // 
            this.lbMotherNationalID.AutoSize = true;
            this.lbMotherNationalID.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotherNationalID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lbMotherNationalID.Location = new System.Drawing.Point(513, 353);
            this.lbMotherNationalID.Name = "lbMotherNationalID";
            this.lbMotherNationalID.Size = new System.Drawing.Size(45, 25);
            this.lbMotherNationalID.TabIndex = 84;
            this.lbMotherNationalID.Text = "...........";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Indigo;
            this.label9.Location = new System.Drawing.Point(367, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 25);
            this.label9.TabIndex = 83;
            this.label9.Text = "Mother National ID :";
            // 
            // lbParentsID
            // 
            this.lbParentsID.AutoSize = true;
            this.lbParentsID.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParentsID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lbParentsID.Location = new System.Drawing.Point(137, 378);
            this.lbParentsID.Name = "lbParentsID";
            this.lbParentsID.Size = new System.Drawing.Size(45, 25);
            this.lbParentsID.TabIndex = 82;
            this.lbParentsID.Text = "...........";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(32, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 81;
            this.label4.Text = "Parents ID        :";
            // 
            // lbFatherName
            // 
            this.lbFatherName.AutoSize = true;
            this.lbFatherName.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFatherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lbFatherName.Location = new System.Drawing.Point(144, 322);
            this.lbFatherName.Name = "lbFatherName";
            this.lbFatherName.Size = new System.Drawing.Size(45, 25);
            this.lbFatherName.TabIndex = 80;
            this.lbFatherName.Text = "...........";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(29, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 79;
            this.label5.Text = "Father Name    :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(29, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 78;
            this.label1.Text = "Notes     :";
            // 
            // lbMotherName
            // 
            this.lbMotherName.AutoSize = true;
            this.lbMotherName.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lbMotherName.Location = new System.Drawing.Point(139, 353);
            this.lbMotherName.Name = "lbMotherName";
            this.lbMotherName.Size = new System.Drawing.Size(45, 25);
            this.lbMotherName.TabIndex = 77;
            this.lbMotherName.Text = "...........";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(29, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 25);
            this.label8.TabIndex = 76;
            this.label8.Text = "Mother Name    :";
            // 
            // tbStudentsNotes
            // 
            this.tbStudentsNotes.BorderRadius = 5;
            this.tbStudentsNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbStudentsNotes.DefaultText = "";
            this.tbStudentsNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbStudentsNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbStudentsNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbStudentsNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbStudentsNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStudentsNotes.Font = new System.Drawing.Font("Dubai", 9.749999F);
            this.tbStudentsNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStudentsNotes.Location = new System.Drawing.Point(29, 465);
            this.tbStudentsNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbStudentsNotes.Name = "tbStudentsNotes";
            this.tbStudentsNotes.PasswordChar = '\0';
            this.tbStudentsNotes.PlaceholderText = "Enter Notes For Student";
            this.tbStudentsNotes.SelectedText = "";
            this.tbStudentsNotes.Size = new System.Drawing.Size(546, 32);
            this.tbStudentsNotes.TabIndex = 75;
            // 
            // lbAdmissionDate
            // 
            this.lbAdmissionDate.AutoSize = true;
            this.lbAdmissionDate.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdmissionDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lbAdmissionDate.Location = new System.Drawing.Point(165, 406);
            this.lbAdmissionDate.Name = "lbAdmissionDate";
            this.lbAdmissionDate.Size = new System.Drawing.Size(45, 25);
            this.lbAdmissionDate.TabIndex = 72;
            this.lbAdmissionDate.Text = "...........";
            // 
            // btnSelectParents
            // 
            this.btnSelectParents.Animated = true;
            this.btnSelectParents.BorderRadius = 5;
            this.btnSelectParents.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectParents.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectParents.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectParents.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelectParents.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btnSelectParents.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectParents.ForeColor = System.Drawing.Color.White;
            this.btnSelectParents.Location = new System.Drawing.Point(591, 465);
            this.btnSelectParents.Name = "btnSelectParents";
            this.btnSelectParents.Size = new System.Drawing.Size(141, 31);
            this.btnSelectParents.TabIndex = 73;
            this.btnSelectParents.Text = "Select Parents";
            this.btnSelectParents.Click += new System.EventHandler(this.btnSelectParents_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(29, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 71;
            this.label3.Text = "Admission Date     :";
            // 
            // ucPersonSelector1
            // 
            this.ucPersonSelector1.FilterEnabled = true;
            this.ucPersonSelector1.Location = new System.Drawing.Point(7, 3);
            this.ucPersonSelector1.MinimumSize = new System.Drawing.Size(718, 330);
            this.ucPersonSelector1.Name = "ucPersonSelector1";
            this.ucPersonSelector1.Size = new System.Drawing.Size(718, 330);
            this.ucPersonSelector1.TabIndex = 74;
            this.ucPersonSelector1.OnPersonSelected += new System.Action<int>(this.ucPersonSelector1_OnPersonSelected);
            this.ucPersonSelector1.OnPersonCleared += new System.Action(this.ucPersonSelector1_OnPersonCleared);
            this.ucPersonSelector1.Load += new System.EventHandler(this.ucPersonSelector1_Load);
            // 
            // frmAddUpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(744, 580);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbFatherNationalID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbMotherNationalID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbParentsID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbFatherName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMotherName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbStudentsNotes);
            this.Controls.Add(this.ucPersonSelector1);
            this.Controls.Add(this.lbAdmissionDate);
            this.Controls.Add(this.btnSelectParents);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Update Student";
            this.Load += new System.EventHandler(this.frmAddUpdateStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label lbFatherNationalID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbMotherNationalID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbParentsID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbFatherName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMotherName;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox tbStudentsNotes;
        private People.UserControls.ucPersonSelector ucPersonSelector1;
        private System.Windows.Forms.Label lbAdmissionDate;
        private Guna.UI2.WinForms.Guna2Button btnSelectParents;
        private System.Windows.Forms.Label label3;
    }
}