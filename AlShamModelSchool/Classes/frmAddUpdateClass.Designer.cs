namespace AlShamModelSchool.Classes
{
    partial class frmAddUpdateClass
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
            this.lbFormTitle = new System.Windows.Forms.Label();
            this.tabs = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbAfternoon = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbMorning = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGradeLevel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbRoomNumberRequired = new System.Windows.Forms.Label();
            this.lbClassNameRequired = new System.Windows.Forms.Label();
            this.lbPersonID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRoomNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMaxStudentsNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbClassName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.flpTeachersSelectorPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pbFormTitle = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbMaxStudentsRequierd = new System.Windows.Forms.Label();
            this.ucClassInfo1 = new AlShamModelSchool.Classes.ucClassInfo();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormTitle)).BeginInit();
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
            this.btnClose.Location = new System.Drawing.Point(494, 565);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 38);
            this.btnClose.TabIndex = 50;
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
            this.btnSave.Location = new System.Drawing.Point(653, 565);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 38);
            this.btnSave.TabIndex = 49;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbFormTitle
            // 
            this.lbFormTitle.AutoSize = true;
            this.lbFormTitle.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormTitle.Location = new System.Drawing.Point(73, 21);
            this.lbFormTitle.Name = "lbFormTitle";
            this.lbFormTitle.Size = new System.Drawing.Size(170, 36);
            this.lbFormTitle.TabIndex = 40;
            this.lbFormTitle.Text = "Add Update Class";
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.ItemSize = new System.Drawing.Size(180, 40);
            this.tabs.Location = new System.Drawing.Point(12, 78);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1061, 481);
            this.tabs.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabs.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabs.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabs.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabs.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabs.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabs.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabs.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabs.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabs.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabs.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabs.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabs.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabs.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabs.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabs.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabs.TabIndex = 61;
            this.tabs.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabs.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.tabs.TabMenuVisible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbMaxStudentsRequierd);
            this.tabPage1.Controls.Add(this.ucClassInfo1);
            this.tabPage1.Controls.Add(this.rbAfternoon);
            this.tabPage1.Controls.Add(this.rbMorning);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cbGradeLevel);
            this.tabPage1.Controls.Add(this.lbRoomNumberRequired);
            this.tabPage1.Controls.Add(this.lbClassNameRequired);
            this.tabPage1.Controls.Add(this.lbPersonID);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tbRoomNumber);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbMaxStudentsNumber);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbClassName);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1053, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rbAfternoon
            // 
            this.rbAfternoon.AutoSize = true;
            this.rbAfternoon.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAfternoon.CheckedState.BorderThickness = 0;
            this.rbAfternoon.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAfternoon.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbAfternoon.CheckedState.InnerOffset = -4;
            this.rbAfternoon.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAfternoon.Location = new System.Drawing.Point(102, 282);
            this.rbAfternoon.Name = "rbAfternoon";
            this.rbAfternoon.Size = new System.Drawing.Size(85, 26);
            this.rbAfternoon.TabIndex = 73;
            this.rbAfternoon.Text = "Afternoon";
            this.rbAfternoon.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAfternoon.UncheckedState.BorderThickness = 2;
            this.rbAfternoon.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAfternoon.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbMorning
            // 
            this.rbMorning.AutoSize = true;
            this.rbMorning.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbMorning.CheckedState.BorderThickness = 0;
            this.rbMorning.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbMorning.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbMorning.CheckedState.InnerOffset = -4;
            this.rbMorning.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMorning.Location = new System.Drawing.Point(17, 282);
            this.rbMorning.Name = "rbMorning";
            this.rbMorning.Size = new System.Drawing.Size(75, 26);
            this.rbMorning.TabIndex = 72;
            this.rbMorning.Text = "Morning";
            this.rbMorning.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbMorning.UncheckedState.BorderThickness = 2;
            this.rbMorning.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbMorning.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbMorning.CheckedChanged += new System.EventHandler(this.rbMorning_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 71;
            this.label3.Text = "Grade Level  :";
            // 
            // cbGradeLevel
            // 
            this.cbGradeLevel.BackColor = System.Drawing.Color.Transparent;
            this.cbGradeLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGradeLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGradeLevel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGradeLevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGradeLevel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbGradeLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbGradeLevel.ItemHeight = 30;
            this.cbGradeLevel.Location = new System.Drawing.Point(277, 67);
            this.cbGradeLevel.Name = "cbGradeLevel";
            this.cbGradeLevel.Size = new System.Drawing.Size(264, 36);
            this.cbGradeLevel.TabIndex = 70;
            this.cbGradeLevel.SelectedIndexChanged += new System.EventHandler(this.cbGradeLevel_SelectedIndexChanged);
            // 
            // lbRoomNumberRequired
            // 
            this.lbRoomNumberRequired.AutoSize = true;
            this.lbRoomNumberRequired.BackColor = System.Drawing.Color.Transparent;
            this.lbRoomNumberRequired.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomNumberRequired.ForeColor = System.Drawing.Color.Red;
            this.lbRoomNumberRequired.Location = new System.Drawing.Point(279, 212);
            this.lbRoomNumberRequired.Name = "lbRoomNumberRequired";
            this.lbRoomNumberRequired.Size = new System.Drawing.Size(76, 18);
            this.lbRoomNumberRequired.TabIndex = 69;
            this.lbRoomNumberRequired.Tag = "Room Number";
            this.lbRoomNumberRequired.Text = "Room Number";
            this.lbRoomNumberRequired.Visible = false;
            // 
            // lbClassNameRequired
            // 
            this.lbClassNameRequired.AutoSize = true;
            this.lbClassNameRequired.BackColor = System.Drawing.Color.Transparent;
            this.lbClassNameRequired.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassNameRequired.ForeColor = System.Drawing.Color.Red;
            this.lbClassNameRequired.Location = new System.Drawing.Point(12, 102);
            this.lbClassNameRequired.Name = "lbClassNameRequired";
            this.lbClassNameRequired.Size = new System.Drawing.Size(63, 18);
            this.lbClassNameRequired.TabIndex = 68;
            this.lbClassNameRequired.Tag = "Class Name ";
            this.lbClassNameRequired.Text = "Class Name ";
            this.lbClassNameRequired.Visible = false;
            // 
            // lbPersonID
            // 
            this.lbPersonID.AutoSize = true;
            this.lbPersonID.BackColor = System.Drawing.Color.Transparent;
            this.lbPersonID.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonID.Location = new System.Drawing.Point(84, 12);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(26, 25);
            this.lbPersonID.TabIndex = 67;
            this.lbPersonID.Text = "-1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 66;
            this.label9.Text = "Class ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(284, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 65;
            this.label7.Text = "Room Number :";
            // 
            // tbRoomNumber
            // 
            this.tbRoomNumber.BorderRadius = 3;
            this.tbRoomNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRoomNumber.DefaultText = "";
            this.tbRoomNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbRoomNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbRoomNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbRoomNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbRoomNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbRoomNumber.Font = new System.Drawing.Font("Dubai", 9.749999F);
            this.tbRoomNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbRoomNumber.Location = new System.Drawing.Point(282, 172);
            this.tbRoomNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbRoomNumber.Name = "tbRoomNumber";
            this.tbRoomNumber.PasswordChar = '\0';
            this.tbRoomNumber.PlaceholderText = "";
            this.tbRoomNumber.SelectedText = "";
            this.tbRoomNumber.Size = new System.Drawing.Size(274, 36);
            this.tbRoomNumber.TabIndex = 64;
            this.tbRoomNumber.TextChanged += new System.EventHandler(this.tbRoomNumber_TextChanged);
            this.tbRoomNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 63;
            this.label4.Text = "Max Students Number :";
            // 
            // tbMaxStudentsNumber
            // 
            this.tbMaxStudentsNumber.BorderRadius = 3;
            this.tbMaxStudentsNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMaxStudentsNumber.DefaultText = "";
            this.tbMaxStudentsNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMaxStudentsNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMaxStudentsNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMaxStudentsNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMaxStudentsNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaxStudentsNumber.Font = new System.Drawing.Font("Dubai", 9.749999F);
            this.tbMaxStudentsNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaxStudentsNumber.Location = new System.Drawing.Point(12, 172);
            this.tbMaxStudentsNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaxStudentsNumber.Name = "tbMaxStudentsNumber";
            this.tbMaxStudentsNumber.PasswordChar = '\0';
            this.tbMaxStudentsNumber.PlaceholderText = "";
            this.tbMaxStudentsNumber.SelectedText = "";
            this.tbMaxStudentsNumber.Size = new System.Drawing.Size(261, 36);
            this.tbMaxStudentsNumber.TabIndex = 62;
            this.tbMaxStudentsNumber.TextChanged += new System.EventHandler(this.tbMaxStudentsNumber_TextChanged);
            this.tbMaxStudentsNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 61;
            this.label1.Text = "Class Name :";
            // 
            // tbClassName
            // 
            this.tbClassName.BorderRadius = 3;
            this.tbClassName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbClassName.DefaultText = "";
            this.tbClassName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbClassName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbClassName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbClassName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbClassName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbClassName.Font = new System.Drawing.Font("Dubai", 9.749999F);
            this.tbClassName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbClassName.Location = new System.Drawing.Point(12, 67);
            this.tbClassName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbClassName.Name = "tbClassName";
            this.tbClassName.PasswordChar = '\0';
            this.tbClassName.PlaceholderText = "";
            this.tbClassName.SelectedText = "";
            this.tbClassName.Size = new System.Drawing.Size(251, 36);
            this.tbClassName.TabIndex = 60;
            this.tbClassName.TextChanged += new System.EventHandler(this.tbClassName_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flpTeachersSelectorPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1053, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 5;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.Enabled = false;
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btnNext.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(328, 565);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(151, 38);
            this.btnNext.TabIndex = 62;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // flpTeachersSelectorPanel
            // 
            this.flpTeachersSelectorPanel.AutoScroll = true;
            this.flpTeachersSelectorPanel.AutoSize = true;
            this.flpTeachersSelectorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTeachersSelectorPanel.Location = new System.Drawing.Point(3, 3);
            this.flpTeachersSelectorPanel.Name = "flpTeachersSelectorPanel";
            this.flpTeachersSelectorPanel.Size = new System.Drawing.Size(1047, 466);
            this.flpTeachersSelectorPanel.TabIndex = 61;
            // 
            // pbFormTitle
            // 
            this.pbFormTitle.Image = global::AlShamModelSchool.Properties.Resources.Add1;
            this.pbFormTitle.ImageRotate = 0F;
            this.pbFormTitle.Location = new System.Drawing.Point(-3, 12);
            this.pbFormTitle.Name = "pbFormTitle";
            this.pbFormTitle.Size = new System.Drawing.Size(86, 60);
            this.pbFormTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFormTitle.TabIndex = 39;
            this.pbFormTitle.TabStop = false;
            // 
            // lbMaxStudentsRequierd
            // 
            this.lbMaxStudentsRequierd.AutoSize = true;
            this.lbMaxStudentsRequierd.BackColor = System.Drawing.Color.Transparent;
            this.lbMaxStudentsRequierd.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaxStudentsRequierd.ForeColor = System.Drawing.Color.Red;
            this.lbMaxStudentsRequierd.Location = new System.Drawing.Point(16, 212);
            this.lbMaxStudentsRequierd.Name = "lbMaxStudentsRequierd";
            this.lbMaxStudentsRequierd.Size = new System.Drawing.Size(72, 18);
            this.lbMaxStudentsRequierd.TabIndex = 75;
            this.lbMaxStudentsRequierd.Tag = "Max Students";
            this.lbMaxStudentsRequierd.Text = "Max Students";
            this.lbMaxStudentsRequierd.Visible = false;
            // 
            // ucClassInfo1
            // 
            this.ucClassInfo1.Location = new System.Drawing.Point(591, 12);
            this.ucClassInfo1.Name = "ucClassInfo1";
            this.ucClassInfo1.Size = new System.Drawing.Size(456, 396);
            this.ucClassInfo1.TabIndex = 74;
            // 
            // frmAddUpdateClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1080, 639);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbFormTitle);
            this.Controls.Add(this.pbFormTitle);
            this.Name = "frmAddUpdateClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddUpdateClass";
            this.Load += new System.EventHandler(this.frmAddUpdateClass_Load);
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label lbFormTitle;
        private Guna.UI2.WinForms.Guna2PictureBox pbFormTitle;
        private Guna.UI2.WinForms.Guna2TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI2.WinForms.Guna2RadioButton rbAfternoon;
        private Guna.UI2.WinForms.Guna2RadioButton rbMorning;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbGradeLevel;
        private System.Windows.Forms.Label lbRoomNumberRequired;
        private System.Windows.Forms.Label lbClassNameRequired;
        private System.Windows.Forms.Label lbPersonID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox tbRoomNumber;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbMaxStudentsNumber;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbClassName;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.FlowLayoutPanel flpTeachersSelectorPanel;
        private ucClassInfo ucClassInfo1;
        private System.Windows.Forms.Label lbMaxStudentsRequierd;
    }
}