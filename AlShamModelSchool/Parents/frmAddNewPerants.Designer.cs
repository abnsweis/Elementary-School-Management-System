namespace AlShamModelSchool.Parents
{
    partial class frmAddNewPerants
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
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbSelectorTitle = new System.Windows.Forms.Label();
            this.btnAddNewFather = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewMother = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ucMotherInfo = new AlShamModelSchool.People.UserControls.ucPersonShortInfo();
            this.ucFatherInfo = new AlShamModelSchool.People.UserControls.ucPersonShortInfo();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(114, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 36);
            this.label2.TabIndex = 36;
            this.label2.Text = "Add New Perants";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::AlShamModelSchool.Properties.Resources.addNewPeoples;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(96, 70);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 38;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lbSelectorTitle
            // 
            this.lbSelectorTitle.AutoSize = true;
            this.lbSelectorTitle.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectorTitle.ForeColor = System.Drawing.Color.Indigo;
            this.lbSelectorTitle.Location = new System.Drawing.Point(24, 90);
            this.lbSelectorTitle.Name = "lbSelectorTitle";
            this.lbSelectorTitle.Size = new System.Drawing.Size(131, 32);
            this.lbSelectorTitle.TabIndex = 39;
            this.lbSelectorTitle.Text = "Select Father  :";
            // 
            // btnAddNewFather
            // 
            this.btnAddNewFather.BorderRadius = 5;
            this.btnAddNewFather.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddNewFather.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewFather.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewFather.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewFather.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewFather.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddNewFather.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewFather.ForeColor = System.Drawing.Color.White;
            this.btnAddNewFather.Location = new System.Drawing.Point(26, 402);
            this.btnAddNewFather.Name = "btnAddNewFather";
            this.btnAddNewFather.Size = new System.Drawing.Size(296, 40);
            this.btnAddNewFather.TabIndex = 65;
            this.btnAddNewFather.Text = "Add New Father";
            this.btnAddNewFather.Click += new System.EventHandler(this.btnAddNewFather_Click);
            // 
            // btnAddNewMother
            // 
            this.btnAddNewMother.BorderRadius = 5;
            this.btnAddNewMother.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddNewMother.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewMother.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewMother.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewMother.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewMother.FillColor = System.Drawing.Color.Crimson;
            this.btnAddNewMother.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewMother.ForeColor = System.Drawing.Color.White;
            this.btnAddNewMother.Location = new System.Drawing.Point(347, 401);
            this.btnAddNewMother.Name = "btnAddNewMother";
            this.btnAddNewMother.Size = new System.Drawing.Size(296, 40);
            this.btnAddNewMother.TabIndex = 68;
            this.btnAddNewMother.Text = "Add New Mother";
            this.btnAddNewMother.Click += new System.EventHandler(this.btnAddNewMother_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(345, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 67;
            this.label1.Text = "Select Mother  :";
            // 
            // ucMotherInfo
            // 
            this.ucMotherInfo.AutoSize = true;
            this.ucMotherInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ucMotherInfo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ucMotherInfo.Location = new System.Drawing.Point(347, 122);
            this.ucMotherInfo.MaximumSize = new System.Drawing.Size(296, 269);
            this.ucMotherInfo.MinimumSize = new System.Drawing.Size(296, 269);
            this.ucMotherInfo.Name = "ucMotherInfo";
            this.ucMotherInfo.PersonID = -1;
            this.ucMotherInfo.Size = new System.Drawing.Size(296, 269);
            this.ucMotherInfo.TabIndex = 69;
            // 
            // ucFatherInfo
            // 
            this.ucFatherInfo.AutoSize = true;
            this.ucFatherInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ucFatherInfo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ucFatherInfo.Location = new System.Drawing.Point(26, 122);
            this.ucFatherInfo.MaximumSize = new System.Drawing.Size(296, 269);
            this.ucFatherInfo.MinimumSize = new System.Drawing.Size(296, 269);
            this.ucFatherInfo.Name = "ucFatherInfo";
            this.ucFatherInfo.PersonID = -1;
            this.ucFatherInfo.Size = new System.Drawing.Size(296, 269);
            this.ucFatherInfo.TabIndex = 66;
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
            this.btnClose.Location = new System.Drawing.Point(324, 520);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 38);
            this.btnClose.TabIndex = 71;
            this.btnClose.Text = "Close";
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
            this.btnSave.Location = new System.Drawing.Point(492, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 38);
            this.btnSave.TabIndex = 70;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddNewPerants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 570);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ucMotherInfo);
            this.Controls.Add(this.btnAddNewMother);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucFatherInfo);
            this.Controls.Add(this.btnAddNewFather);
            this.Controls.Add(this.lbSelectorTitle);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label2);
            this.Name = "frmAddNewPerants";
            this.Text = "frmAddNewPerants";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lbSelectorTitle;
        private Guna.UI2.WinForms.Guna2Button btnAddNewFather;
        private People.UserControls.ucPersonShortInfo ucFatherInfo;
        private People.UserControls.ucPersonShortInfo ucMotherInfo;
        private Guna.UI2.WinForms.Guna2Button btnAddNewMother;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}