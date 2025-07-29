namespace AlShamModelSchool.Students
{
    partial class frmManageStudents
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStudents = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsManageStudents = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refrashToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inactiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graduatedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.droppedOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expelledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suspendedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showParentsDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterByStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.cbFilterItems = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbFilterString = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewPerson = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnEnrollmentNewStudent = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.cmsManageStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AllowUserToResizeColumns = false;
            this.dgvStudents.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(117)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudents.CausesValidation = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudents.ColumnHeadersHeight = 31;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvStudents.ContextMenuStrip = this.cmsManageStudents;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(117)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStudents.Location = new System.Drawing.Point(23, 153);
            this.dgvStudents.MinimumSize = new System.Drawing.Size(1000, 355);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.RowTemplate.Height = 31;
            this.dgvStudents.Size = new System.Drawing.Size(1172, 355);
            this.dgvStudents.TabIndex = 10;
            this.dgvStudents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStudents.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStudents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.dgvStudents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(117)))), ((int)(((byte)(155)))));
            this.dgvStudents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvStudents.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvStudents.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStudents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
            this.dgvStudents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStudents.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvStudents.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStudents.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvStudents.ThemeStyle.HeaderStyle.Height = 31;
            this.dgvStudents.ThemeStyle.ReadOnly = true;
            this.dgvStudents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.dgvStudents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStudents.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStudents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvStudents.ThemeStyle.RowsStyle.Height = 31;
            this.dgvStudents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(104)))));
            this.dgvStudents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // cmsManageStudents
            // 
            this.cmsManageStudents.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsManageStudents.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsManageStudents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.DeletePersonToolStripMenuItem,
            this.updateToolStripMenuItem1,
            this.showPersonDetailsToolStripMenuItem,
            this.refrashToolStripMenuItem1,
            this.statusToolStripMenuItem,
            this.showParentsDetailsToolStripMenuItem});
            this.cmsManageStudents.Name = "cmsManagePeople";
            this.cmsManageStudents.Size = new System.Drawing.Size(253, 256);
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.Image = global::AlShamModelSchool.Properties.Resources.addNewPerson;
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(252, 36);
            this.addNewStudentToolStripMenuItem.Text = "Add New Students";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // DeletePersonToolStripMenuItem
            // 
            this.DeletePersonToolStripMenuItem.Image = global::AlShamModelSchool.Properties.Resources.DeletePerson;
            this.DeletePersonToolStripMenuItem.Name = "DeletePersonToolStripMenuItem";
            this.DeletePersonToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeletePersonToolStripMenuItem.Size = new System.Drawing.Size(252, 36);
            this.DeletePersonToolStripMenuItem.Text = "Delete";
            this.DeletePersonToolStripMenuItem.Click += new System.EventHandler(this.DeleteStudentsToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Image = global::AlShamModelSchool.Properties.Resources.UpdatePerson;
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(252, 36);
            this.updateToolStripMenuItem1.Text = "Update";
            this.updateToolStripMenuItem1.Click += new System.EventHandler(this.updateToolStripMenuItem1_Click);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Image = global::AlShamModelSchool.Properties.Resources.icons8_info_100;
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(252, 36);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // refrashToolStripMenuItem1
            // 
            this.refrashToolStripMenuItem1.Image = global::AlShamModelSchool.Properties.Resources.Refresh;
            this.refrashToolStripMenuItem1.Name = "refrashToolStripMenuItem1";
            this.refrashToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refrashToolStripMenuItem1.Size = new System.Drawing.Size(252, 36);
            this.refrashToolStripMenuItem1.Text = "Refrash";
            this.refrashToolStripMenuItem1.Click += new System.EventHandler(this.refrashToolStripMenuItem1_Click_1);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeToolStripMenuItem,
            this.inactiveToolStripMenuItem,
            this.graduatedToolStripMenuItem,
            this.droppedOutToolStripMenuItem,
            this.expelledToolStripMenuItem,
            this.suspendedToolStripMenuItem});
            this.statusToolStripMenuItem.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusToolStripMenuItem.Image = global::AlShamModelSchool.Properties.Resources.status_update;
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(252, 36);
            this.statusToolStripMenuItem.Text = "Status";
            // 
            // activeToolStripMenuItem
            // 
            this.activeToolStripMenuItem.Name = "activeToolStripMenuItem";
            this.activeToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.activeToolStripMenuItem.Text = "Active";
            this.activeToolStripMenuItem.Click += new System.EventHandler(this.activeToolStripMenuItem_Click);
            // 
            // inactiveToolStripMenuItem
            // 
            this.inactiveToolStripMenuItem.Name = "inactiveToolStripMenuItem";
            this.inactiveToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.inactiveToolStripMenuItem.Text = "Inactive";
            this.inactiveToolStripMenuItem.Click += new System.EventHandler(this.inactiveToolStripMenuItem_Click);
            // 
            // graduatedToolStripMenuItem
            // 
            this.graduatedToolStripMenuItem.Name = "graduatedToolStripMenuItem";
            this.graduatedToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.graduatedToolStripMenuItem.Text = "Graduated";
            this.graduatedToolStripMenuItem.Click += new System.EventHandler(this.graduatedToolStripMenuItem_Click);
            // 
            // droppedOutToolStripMenuItem
            // 
            this.droppedOutToolStripMenuItem.Name = "droppedOutToolStripMenuItem";
            this.droppedOutToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.droppedOutToolStripMenuItem.Text = "DroppedOut";
            this.droppedOutToolStripMenuItem.Click += new System.EventHandler(this.droppedOutToolStripMenuItem_Click);
            // 
            // expelledToolStripMenuItem
            // 
            this.expelledToolStripMenuItem.Name = "expelledToolStripMenuItem";
            this.expelledToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.expelledToolStripMenuItem.Text = "Expelled";
            this.expelledToolStripMenuItem.Click += new System.EventHandler(this.expelledToolStripMenuItem_Click);
            // 
            // suspendedToolStripMenuItem
            // 
            this.suspendedToolStripMenuItem.Name = "suspendedToolStripMenuItem";
            this.suspendedToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.suspendedToolStripMenuItem.Text = "Suspended";
            this.suspendedToolStripMenuItem.Click += new System.EventHandler(this.suspendedToolStripMenuItem_Click);
            // 
            // showParentsDetailsToolStripMenuItem
            // 
            this.showParentsDetailsToolStripMenuItem.Image = global::AlShamModelSchool.Properties.Resources.Parents;
            this.showParentsDetailsToolStripMenuItem.Name = "showParentsDetailsToolStripMenuItem";
            this.showParentsDetailsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.showParentsDetailsToolStripMenuItem.Size = new System.Drawing.Size(252, 36);
            this.showParentsDetailsToolStripMenuItem.Text = "Show Parents Details";
            this.showParentsDetailsToolStripMenuItem.Click += new System.EventHandler(this.showParentsDetailsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "Manage Students";
            // 
            // cbFilterByStatus
            // 
            this.cbFilterByStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterByStatus.BorderRadius = 6;
            this.cbFilterByStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterByStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterByStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterByStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterByStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterByStatus.ItemHeight = 30;
            this.cbFilterByStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Graduated",
            "DroppedOut",
            "Expelled",
            "Suspended"});
            this.cbFilterByStatus.Location = new System.Drawing.Point(212, 96);
            this.cbFilterByStatus.Name = "cbFilterByStatus";
            this.cbFilterByStatus.Size = new System.Drawing.Size(140, 36);
            this.cbFilterByStatus.TabIndex = 16;
            this.cbFilterByStatus.Visible = false;
            this.cbFilterByStatus.SelectedIndexChanged += new System.EventHandler(this.cbFilterByStatus_SelectedIndexChanged);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(135, 559);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(20, 25);
            this.lblRecordsCount.TabIndex = 15;
            this.lblRecordsCount.Text = "0";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Location = new System.Drawing.Point(20, 559);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(118, 25);
            this.lable1.TabIndex = 14;
            this.lable1.Text = "Students Count :";
            // 
            // cbFilterItems
            // 
            this.cbFilterItems.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterItems.BorderRadius = 6;
            this.cbFilterItems.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterItems.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterItems.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterItems.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterItems.ItemHeight = 30;
            this.cbFilterItems.Items.AddRange(new object[] {
            "None",
            "Student ID",
            "Person ID",
            "Student Number",
            "Full Name",
            "Father Name",
            "Mother Name",
            "Status"});
            this.cbFilterItems.Location = new System.Drawing.Point(23, 96);
            this.cbFilterItems.Name = "cbFilterItems";
            this.cbFilterItems.Size = new System.Drawing.Size(183, 36);
            this.cbFilterItems.TabIndex = 13;
            this.cbFilterItems.SelectedIndexChanged += new System.EventHandler(this.cbFilterItems_SelectedIndexChanged);
            // 
            // tbFilterString
            // 
            this.tbFilterString.BorderRadius = 6;
            this.tbFilterString.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFilterString.DefaultText = "";
            this.tbFilterString.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFilterString.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFilterString.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFilterString.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFilterString.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFilterString.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbFilterString.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFilterString.Location = new System.Drawing.Point(212, 96);
            this.tbFilterString.Name = "tbFilterString";
            this.tbFilterString.PasswordChar = '\0';
            this.tbFilterString.PlaceholderText = "";
            this.tbFilterString.SelectedText = "";
            this.tbFilterString.Size = new System.Drawing.Size(252, 36);
            this.tbFilterString.TabIndex = 12;
            this.tbFilterString.TextChanged += new System.EventHandler(this.tbFilterString_TextChanged);
            this.tbFilterString.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterString_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 6;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1030, 559);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(155, 33);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddNewPerson.HoverState.ImageSize = new System.Drawing.Size(60, 60);
            this.btnAddNewPerson.Image = global::AlShamModelSchool.Properties.Resources.addNewPerson;
            this.btnAddNewPerson.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddNewPerson.ImageRotate = 0F;
            this.btnAddNewPerson.Location = new System.Drawing.Point(1116, 69);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.PressedState.ImageSize = new System.Drawing.Size(62, 62);
            this.btnAddNewPerson.Size = new System.Drawing.Size(79, 78);
            this.btnAddNewPerson.TabIndex = 19;
            this.btnAddNewPerson.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::AlShamModelSchool.Properties.Resources.Students;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(23, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(93, 76);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 17;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnEnrollmentNewStudent
            // 
            this.btnEnrollmentNewStudent.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnEnrollmentNewStudent.HoverState.ImageSize = new System.Drawing.Size(52, 52);
            this.btnEnrollmentNewStudent.Image = global::AlShamModelSchool.Properties.Resources.icons8_registration_100__2_;
            this.btnEnrollmentNewStudent.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnEnrollmentNewStudent.ImageRotate = 0F;
            this.btnEnrollmentNewStudent.ImageSize = new System.Drawing.Size(50, 50);
            this.btnEnrollmentNewStudent.Location = new System.Drawing.Point(1046, 69);
            this.btnEnrollmentNewStudent.Name = "btnEnrollmentNewStudent";
            this.btnEnrollmentNewStudent.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnEnrollmentNewStudent.Size = new System.Drawing.Size(79, 78);
            this.btnEnrollmentNewStudent.TabIndex = 37;
            this.btnEnrollmentNewStudent.Click += new System.EventHandler(this.btnEnrollmentNewStudent_Click);
            // 
            // frmManageStudents
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1214, 604);
            this.Controls.Add(this.btnEnrollmentNewStudent);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnAddNewPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.cbFilterByStatus);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.cbFilterItems);
            this.Controls.Add(this.tbFilterString);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Students";
            this.Load += new System.EventHandler(this.frmManageStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.cmsManageStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvStudents;
        private System.Windows.Forms.ContextMenuStrip cmsManageStudents;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeletePersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refrashToolStripMenuItem1;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddNewPerson;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterByStatus;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label lable1;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterItems;
        private Guna.UI2.WinForms.Guna2TextBox tbFilterString;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inactiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graduatedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem droppedOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expelledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suspendedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showParentsDetailsToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ImageButton btnEnrollmentNewStudent;
    }
}