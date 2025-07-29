namespace AlShamModelSchool.People
{
    partial class frmAddUpdatePerson
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
            this.lbFormTitle = new System.Windows.Forms.Label();
            this.tbFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpDateOfBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNationalID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.pbGenderImageTitle = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbPersonImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbFormTitle = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnChangePersonImage = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemovePersonImage = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lbPersonID = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lbFirstNameRequired = new System.Windows.Forms.Label();
            this.lbLastNameRequired = new System.Windows.Forms.Label();
            this.lbPhoneRequired = new System.Windows.Forms.Label();
            this.lbEmailRequired = new System.Windows.Forms.Label();
            this.lbNationalRequired = new System.Windows.Forms.Label();
            this.lbAddressRequired = new System.Windows.Forms.Label();
            this.PersonImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenderImageTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFormTitle
            // 
            this.lbFormTitle.AutoSize = true;
            this.lbFormTitle.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormTitle.Location = new System.Drawing.Point(118, 36);
            this.lbFormTitle.Name = "lbFormTitle";
            this.lbFormTitle.Size = new System.Drawing.Size(226, 36);
            this.lbFormTitle.TabIndex = 9;
            this.lbFormTitle.Text = "Add Update Person Info";
            // 
            // tbFirstName
            // 
            this.tbFirstName.BorderRadius = 3;
            this.tbFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFirstName.DefaultText = "";
            this.tbFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFirstName.Font = new System.Drawing.Font("Dubai", 9.749999F);
            this.tbFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFirstName.Location = new System.Drawing.Point(12, 144);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PasswordChar = '\0';
            this.tbFirstName.PlaceholderText = "";
            this.tbFirstName.SelectedText = "";
            this.tbFirstName.Size = new System.Drawing.Size(180, 33);
            this.tbFirstName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "First Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name :";
            // 
            // tbLastName
            // 
            this.tbLastName.BorderRadius = 3;
            this.tbLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLastName.DefaultText = "";
            this.tbLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastName.Font = new System.Drawing.Font("Dubai", 9.749999F);
            this.tbLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastName.Location = new System.Drawing.Point(220, 145);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.PasswordChar = '\0';
            this.tbLastName.PlaceholderText = "";
            this.tbLastName.SelectedText = "";
            this.tbLastName.Size = new System.Drawing.Size(180, 33);
            this.tbLastName.TabIndex = 12;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Checked = true;
            this.dtpDateOfBirth.FillColor = System.Drawing.SystemColors.Control;
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(427, 145);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateOfBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(180, 33);
            this.dtpDateOfBirth.TabIndex = 14;
            this.dtpDateOfBirth.Value = new System.DateTime(2025, 3, 9, 13, 39, 12, 622);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Date OF Birth :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Phone :";
            // 
            // tbPhone
            // 
            this.tbPhone.BorderRadius = 3;
            this.tbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhone.DefaultText = "";
            this.tbPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhone.Font = new System.Drawing.Font("Dubai", 9.749999F);
            this.tbPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhone.Location = new System.Drawing.Point(12, 217);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.PasswordChar = '\0';
            this.tbPhone.PlaceholderText = "";
            this.tbPhone.SelectedText = "";
            this.tbPhone.Size = new System.Drawing.Size(180, 33);
            this.tbPhone.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(220, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Email :";
            // 
            // tbEmail
            // 
            this.tbEmail.BorderRadius = 3;
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.DefaultText = "";
            this.tbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.Font = new System.Drawing.Font("Dubai", 9.749999F);
            this.tbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.Location = new System.Drawing.Point(220, 218);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.PlaceholderText = "";
            this.tbEmail.SelectedText = "";
            this.tbEmail.Size = new System.Drawing.Size(180, 33);
            this.tbEmail.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(427, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Date Of Birth :";
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.Color.Transparent;
            this.cbGender.BorderRadius = 4;
            this.cbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGender.Font = new System.Drawing.Font("Dubai", 9.749999F);
            this.cbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbGender.ItemHeight = 26;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(427, 218);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(180, 32);
            this.cbGender.StartIndex = 0;
            this.cbGender.TabIndex = 20;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "National ID  :";
            // 
            // tbNationalID
            // 
            this.tbNationalID.BorderRadius = 3;
            this.tbNationalID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNationalID.DefaultText = "";
            this.tbNationalID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNationalID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNationalID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNationalID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNationalID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNationalID.Font = new System.Drawing.Font("Dubai", 9.749999F);
            this.tbNationalID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNationalID.Location = new System.Drawing.Point(12, 292);
            this.tbNationalID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNationalID.Name = "tbNationalID";
            this.tbNationalID.PasswordChar = '\0';
            this.tbNationalID.PlaceholderText = "";
            this.tbNationalID.SelectedText = "";
            this.tbNationalID.Size = new System.Drawing.Size(180, 33);
            this.tbNationalID.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(220, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Address  :";
            // 
            // tbAddress
            // 
            this.tbAddress.BorderRadius = 3;
            this.tbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddress.DefaultText = "";
            this.tbAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddress.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddress.Location = new System.Drawing.Point(220, 292);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.PasswordChar = '\0';
            this.tbAddress.PlaceholderText = "";
            this.tbAddress.SelectedText = "";
            this.tbAddress.Size = new System.Drawing.Size(387, 33);
            this.tbAddress.TabIndex = 25;
            // 
            // pbGenderImageTitle
            // 
            this.pbGenderImageTitle.BackColor = System.Drawing.Color.Transparent;
            this.pbGenderImageTitle.FillColor = System.Drawing.Color.Transparent;
            this.pbGenderImageTitle.Image = global::AlShamModelSchool.Properties.Resources.MakeIcon;
            this.pbGenderImageTitle.ImageRotate = 0F;
            this.pbGenderImageTitle.Location = new System.Drawing.Point(528, 183);
            this.pbGenderImageTitle.Name = "pbGenderImageTitle";
            this.pbGenderImageTitle.Size = new System.Drawing.Size(51, 34);
            this.pbGenderImageTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGenderImageTitle.TabIndex = 27;
            this.pbGenderImageTitle.TabStop = false;
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.ImageRotate = 0F;
            this.pbPersonImage.Location = new System.Drawing.Point(655, 12);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(142, 127);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 24;
            this.pbPersonImage.TabStop = false;
            // 
            // pbFormTitle
            // 
            this.pbFormTitle.Image = global::AlShamModelSchool.Properties.Resources.UpdatePerson;
            this.pbFormTitle.ImageRotate = 0F;
            this.pbFormTitle.Location = new System.Drawing.Point(12, 12);
            this.pbFormTitle.Name = "pbFormTitle";
            this.pbFormTitle.Size = new System.Drawing.Size(86, 60);
            this.pbFormTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFormTitle.TabIndex = 0;
            this.pbFormTitle.TabStop = false;
            // 
            // btnChangePersonImage
            // 
            this.btnChangePersonImage.BorderRadius = 5;
            this.btnChangePersonImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePersonImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePersonImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangePersonImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangePersonImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btnChangePersonImage.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePersonImage.ForeColor = System.Drawing.Color.White;
            this.btnChangePersonImage.Location = new System.Drawing.Point(655, 152);
            this.btnChangePersonImage.Name = "btnChangePersonImage";
            this.btnChangePersonImage.Size = new System.Drawing.Size(142, 28);
            this.btnChangePersonImage.TabIndex = 28;
            this.btnChangePersonImage.Text = "Chanege Image";
            this.btnChangePersonImage.Click += new System.EventHandler(this.btnChangePersonImage_Click);
            // 
            // btnRemovePersonImage
            // 
            this.btnRemovePersonImage.BorderRadius = 5;
            this.btnRemovePersonImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemovePersonImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemovePersonImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemovePersonImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemovePersonImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemovePersonImage.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePersonImage.ForeColor = System.Drawing.Color.White;
            this.btnRemovePersonImage.Location = new System.Drawing.Point(655, 186);
            this.btnRemovePersonImage.Name = "btnRemovePersonImage";
            this.btnRemovePersonImage.Size = new System.Drawing.Size(142, 28);
            this.btnRemovePersonImage.TabIndex = 29;
            this.btnRemovePersonImage.Text = "Remove Image";
            this.btnRemovePersonImage.Visible = false;
            this.btnRemovePersonImage.Click += new System.EventHandler(this.btnRemovePersonImage_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 25);
            this.label9.TabIndex = 30;
            this.label9.Text = "Person ID :";
            // 
            // lbPersonID
            // 
            this.lbPersonID.AutoSize = true;
            this.lbPersonID.BackColor = System.Drawing.Color.Transparent;
            this.lbPersonID.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonID.Location = new System.Drawing.Point(92, 89);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(26, 25);
            this.lbPersonID.TabIndex = 31;
            this.lbPersonID.Text = "-1";
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
            this.btnSave.Location = new System.Drawing.Point(646, 357);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 38);
            this.btnSave.TabIndex = 32;
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
            this.btnClose.Location = new System.Drawing.Point(478, 357);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 38);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbFirstNameRequired
            // 
            this.lbFirstNameRequired.AutoSize = true;
            this.lbFirstNameRequired.BackColor = System.Drawing.Color.Transparent;
            this.lbFirstNameRequired.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstNameRequired.ForeColor = System.Drawing.Color.Red;
            this.lbFirstNameRequired.Location = new System.Drawing.Point(12, 177);
            this.lbFirstNameRequired.Name = "lbFirstNameRequired";
            this.lbFirstNameRequired.Size = new System.Drawing.Size(61, 18);
            this.lbFirstNameRequired.TabIndex = 34;
            this.lbFirstNameRequired.Tag = "First Name ";
            this.lbFirstNameRequired.Text = "First Name ";
            this.lbFirstNameRequired.Visible = false;
            // 
            // lbLastNameRequired
            // 
            this.lbLastNameRequired.AutoSize = true;
            this.lbLastNameRequired.BackColor = System.Drawing.Color.Transparent;
            this.lbLastNameRequired.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastNameRequired.ForeColor = System.Drawing.Color.Red;
            this.lbLastNameRequired.Location = new System.Drawing.Point(220, 178);
            this.lbLastNameRequired.Name = "lbLastNameRequired";
            this.lbLastNameRequired.Size = new System.Drawing.Size(57, 18);
            this.lbLastNameRequired.TabIndex = 35;
            this.lbLastNameRequired.Tag = "Last Name ";
            this.lbLastNameRequired.Text = "Last Name";
            this.lbLastNameRequired.Visible = false;
            // 
            // lbPhoneRequired
            // 
            this.lbPhoneRequired.AutoSize = true;
            this.lbPhoneRequired.BackColor = System.Drawing.Color.Transparent;
            this.lbPhoneRequired.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneRequired.ForeColor = System.Drawing.Color.Red;
            this.lbPhoneRequired.Location = new System.Drawing.Point(15, 250);
            this.lbPhoneRequired.Name = "lbPhoneRequired";
            this.lbPhoneRequired.Size = new System.Drawing.Size(37, 18);
            this.lbPhoneRequired.TabIndex = 36;
            this.lbPhoneRequired.Tag = "Phone";
            this.lbPhoneRequired.Text = "Phone";
            this.lbPhoneRequired.Visible = false;
            // 
            // lbEmailRequired
            // 
            this.lbEmailRequired.AutoSize = true;
            this.lbEmailRequired.BackColor = System.Drawing.Color.Transparent;
            this.lbEmailRequired.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailRequired.ForeColor = System.Drawing.Color.Red;
            this.lbEmailRequired.Location = new System.Drawing.Point(220, 251);
            this.lbEmailRequired.Name = "lbEmailRequired";
            this.lbEmailRequired.Size = new System.Drawing.Size(34, 18);
            this.lbEmailRequired.TabIndex = 37;
            this.lbEmailRequired.Tag = "Email";
            this.lbEmailRequired.Text = "Email";
            this.lbEmailRequired.Visible = false;
            // 
            // lbNationalRequired
            // 
            this.lbNationalRequired.AutoSize = true;
            this.lbNationalRequired.BackColor = System.Drawing.Color.Transparent;
            this.lbNationalRequired.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNationalRequired.ForeColor = System.Drawing.Color.Red;
            this.lbNationalRequired.Location = new System.Drawing.Point(15, 325);
            this.lbNationalRequired.Name = "lbNationalRequired";
            this.lbNationalRequired.Size = new System.Drawing.Size(60, 18);
            this.lbNationalRequired.TabIndex = 38;
            this.lbNationalRequired.Tag = "National ID";
            this.lbNationalRequired.Text = "National ID";
            this.lbNationalRequired.Visible = false;
            // 
            // lbAddressRequired
            // 
            this.lbAddressRequired.AutoSize = true;
            this.lbAddressRequired.BackColor = System.Drawing.Color.Transparent;
            this.lbAddressRequired.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddressRequired.ForeColor = System.Drawing.Color.Red;
            this.lbAddressRequired.Location = new System.Drawing.Point(220, 325);
            this.lbAddressRequired.Name = "lbAddressRequired";
            this.lbAddressRequired.Size = new System.Drawing.Size(46, 18);
            this.lbAddressRequired.TabIndex = 39;
            this.lbAddressRequired.Tag = "Address";
            this.lbAddressRequired.Text = "Address";
            this.lbAddressRequired.Visible = false;
            // 
            // PersonImageFileDialog
            // 
            this.PersonImageFileDialog.FileName = "openFileDialog1";
            // 
            // frmAddUpdatePerson
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(809, 407);
            this.Controls.Add(this.lbAddressRequired);
            this.Controls.Add(this.lbNationalRequired);
            this.Controls.Add(this.lbEmailRequired);
            this.Controls.Add(this.lbPhoneRequired);
            this.Controls.Add(this.lbLastNameRequired);
            this.Controls.Add(this.lbFirstNameRequired);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbPersonID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRemovePersonImage);
            this.Controls.Add(this.btnChangePersonImage);
            this.Controls.Add(this.pbGenderImageTitle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.pbPersonImage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbNationalID);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbFormTitle);
            this.Controls.Add(this.pbFormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdatePerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmAddUpdatePerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGenderImageTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pbFormTitle;
        private System.Windows.Forms.Label lbFormTitle;
        private Guna.UI2.WinForms.Guna2TextBox tbFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbLastName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbPhone;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox tbEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox tbNationalID;
        private Guna.UI2.WinForms.Guna2PictureBox pbPersonImage;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox tbAddress;
        private Guna.UI2.WinForms.Guna2PictureBox pbGenderImageTitle;
        private Guna.UI2.WinForms.Guna2Button btnChangePersonImage;
        private Guna.UI2.WinForms.Guna2Button btnRemovePersonImage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbPersonID;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lbFirstNameRequired;
        private System.Windows.Forms.Label lbLastNameRequired;
        private System.Windows.Forms.Label lbPhoneRequired;
        private System.Windows.Forms.Label lbEmailRequired;
        private System.Windows.Forms.Label lbNationalRequired;
        private System.Windows.Forms.Label lbAddressRequired;
        private System.Windows.Forms.OpenFileDialog PersonImageFileDialog;
        public Guna.UI2.WinForms.Guna2ComboBox cbGender;
    }
}