namespace AlShamModelSchool.Teachers
{
    partial class frmManageTeachers
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
            this.dgvTeachers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsManageTeachers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewpersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refrashToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.activityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActivateTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeactivateTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbActivity = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbFilterItems = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbFilterString = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.cbSpecializations = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTeachersCount = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2ContainerControl3 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.lbActiveTeachers = new System.Windows.Forms.Label();
            this.guna2ContainerControl2 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.lable12 = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbDeactivateTeachers = new System.Windows.Forms.Label();
            this.guna2ContainerControl4 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbTotalSalary = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewTeacher = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.cmsManageTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2ContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.guna2ContainerControl3.SuspendLayout();
            this.guna2ContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.guna2ContainerControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.AllowUserToAddRows = false;
            this.dgvTeachers.AllowUserToDeleteRows = false;
            this.dgvTeachers.AllowUserToResizeColumns = false;
            this.dgvTeachers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(117)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTeachers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTeachers.CausesValidation = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeachers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTeachers.ColumnHeadersHeight = 31;
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTeachers.ContextMenuStrip = this.cmsManageTeachers;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(117)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTeachers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTeachers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTeachers.Location = new System.Drawing.Point(12, 197);
            this.dgvTeachers.MinimumSize = new System.Drawing.Size(1000, 355);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.ReadOnly = true;
            this.dgvTeachers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeachers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTeachers.RowHeadersVisible = false;
            this.dgvTeachers.RowTemplate.Height = 31;
            this.dgvTeachers.Size = new System.Drawing.Size(1242, 385);
            this.dgvTeachers.TabIndex = 10;
            this.dgvTeachers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTeachers.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTeachers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.dgvTeachers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(117)))), ((int)(((byte)(155)))));
            this.dgvTeachers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTeachers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTeachers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTeachers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
            this.dgvTeachers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTeachers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvTeachers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTeachers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTeachers.ThemeStyle.HeaderStyle.Height = 31;
            this.dgvTeachers.ThemeStyle.ReadOnly = true;
            this.dgvTeachers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.dgvTeachers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTeachers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTeachers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTeachers.ThemeStyle.RowsStyle.Height = 31;
            this.dgvTeachers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(104)))));
            this.dgvTeachers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // cmsManageTeachers
            // 
            this.cmsManageTeachers.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsManageTeachers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewpersonToolStripMenuItem,
            this.DeletePersonToolStripMenuItem,
            this.updateToolStripMenuItem1,
            this.showPersonDetailsToolStripMenuItem,
            this.refrashToolStripMenuItem1,
            this.activityToolStripMenuItem});
            this.cmsManageTeachers.Name = "cmsManagePeople";
            this.cmsManageTeachers.Size = new System.Drawing.Size(224, 220);
            this.cmsManageTeachers.Opening += new System.ComponentModel.CancelEventHandler(this.cmsManageTeachers_Opening);
            // 
            // addNewpersonToolStripMenuItem
            // 
            this.addNewpersonToolStripMenuItem.Image = global::AlShamModelSchool.Properties.Resources.icons8_teachers_100__1_;
            this.addNewpersonToolStripMenuItem.Name = "addNewpersonToolStripMenuItem";
            this.addNewpersonToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addNewpersonToolStripMenuItem.Size = new System.Drawing.Size(223, 36);
            this.addNewpersonToolStripMenuItem.Text = "Add New Teacher";
            this.addNewpersonToolStripMenuItem.Click += new System.EventHandler(this.addNewpersonToolStripMenuItem_Click);
            // 
            // DeletePersonToolStripMenuItem
            // 
            this.DeletePersonToolStripMenuItem.Image = global::AlShamModelSchool.Properties.Resources.Delete;
            this.DeletePersonToolStripMenuItem.Name = "DeletePersonToolStripMenuItem";
            this.DeletePersonToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeletePersonToolStripMenuItem.Size = new System.Drawing.Size(223, 36);
            this.DeletePersonToolStripMenuItem.Text = "Delete";
            this.DeletePersonToolStripMenuItem.Click += new System.EventHandler(this.DeleteTeacherToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Image = global::AlShamModelSchool.Properties.Resources.Update;
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(223, 36);
            this.updateToolStripMenuItem1.Text = "Update";
            this.updateToolStripMenuItem1.Click += new System.EventHandler(this.updateToolStripMenuItem1_Click);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Image = global::AlShamModelSchool.Properties.Resources.icons8_info_100;
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(223, 36);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // refrashToolStripMenuItem1
            // 
            this.refrashToolStripMenuItem1.Image = global::AlShamModelSchool.Properties.Resources.Refresh;
            this.refrashToolStripMenuItem1.Name = "refrashToolStripMenuItem1";
            this.refrashToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refrashToolStripMenuItem1.Size = new System.Drawing.Size(223, 36);
            this.refrashToolStripMenuItem1.Text = "Refrash";
            this.refrashToolStripMenuItem1.Click += new System.EventHandler(this.refrashToolStripMenuItem1_Click);
            // 
            // activityToolStripMenuItem
            // 
            this.activityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActivateTeacherToolStripMenuItem,
            this.DeactivateTeacherToolStripMenuItem});
            this.activityToolStripMenuItem.Image = global::AlShamModelSchool.Properties.Resources.icons8_settings_100;
            this.activityToolStripMenuItem.Name = "activityToolStripMenuItem";
            this.activityToolStripMenuItem.Size = new System.Drawing.Size(223, 36);
            this.activityToolStripMenuItem.Text = "Activity";
            // 
            // ActivateTeacherToolStripMenuItem
            // 
            this.ActivateTeacherToolStripMenuItem.Image = global::AlShamModelSchool.Properties.Resources.icons8_turn_on_100;
            this.ActivateTeacherToolStripMenuItem.Name = "ActivateTeacherToolStripMenuItem";
            this.ActivateTeacherToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ActivateTeacherToolStripMenuItem.Text = "Activate";
            this.ActivateTeacherToolStripMenuItem.Click += new System.EventHandler(this.ActivateTeacherToolStripMenuItem_Click);
            // 
            // DeactivateTeacherToolStripMenuItem
            // 
            this.DeactivateTeacherToolStripMenuItem.Image = global::AlShamModelSchool.Properties.Resources.icons8_block_100;
            this.DeactivateTeacherToolStripMenuItem.Name = "DeactivateTeacherToolStripMenuItem";
            this.DeactivateTeacherToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.DeactivateTeacherToolStripMenuItem.Text = "Deactivate";
            this.DeactivateTeacherToolStripMenuItem.Click += new System.EventHandler(this.DeactivateTeacherToolStripMenuItem_Click);
            // 
            // cbActivity
            // 
            this.cbActivity.BackColor = System.Drawing.Color.Transparent;
            this.cbActivity.BorderRadius = 6;
            this.cbActivity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActivity.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbActivity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbActivity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbActivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbActivity.ItemHeight = 30;
            this.cbActivity.Items.AddRange(new object[] {
            "Active ",
            "Not Active"});
            this.cbActivity.Location = new System.Drawing.Point(189, 149);
            this.cbActivity.Name = "cbActivity";
            this.cbActivity.Size = new System.Drawing.Size(140, 36);
            this.cbActivity.TabIndex = 16;
            this.cbActivity.Visible = false;
            this.cbActivity.SelectedIndexChanged += new System.EventHandler(this.cbActivity_SelectedIndexChanged);
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
            "Full Name",
            "National ID",
            "Specializations",
            "Is Active"});
            this.cbFilterItems.Location = new System.Drawing.Point(12, 149);
            this.cbFilterItems.Name = "cbFilterItems";
            this.cbFilterItems.Size = new System.Drawing.Size(140, 36);
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
            this.tbFilterString.Location = new System.Drawing.Point(189, 149);
            this.tbFilterString.Name = "tbFilterString";
            this.tbFilterString.PasswordChar = '\0';
            this.tbFilterString.PlaceholderText = "";
            this.tbFilterString.SelectedText = "";
            this.tbFilterString.Size = new System.Drawing.Size(252, 36);
            this.tbFilterString.TabIndex = 12;
            this.tbFilterString.Visible = false;
            this.tbFilterString.TextChanged += new System.EventHandler(this.tbFilterString_TextChanged);
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
            this.btnClose.Location = new System.Drawing.Point(1099, 595);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(155, 33);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbSpecializations
            // 
            this.cbSpecializations.BackColor = System.Drawing.Color.Transparent;
            this.cbSpecializations.BorderRadius = 6;
            this.cbSpecializations.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSpecializations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpecializations.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSpecializations.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSpecializations.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSpecializations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSpecializations.ItemHeight = 30;
            this.cbSpecializations.Location = new System.Drawing.Point(189, 149);
            this.cbSpecializations.Name = "cbSpecializations";
            this.cbSpecializations.Size = new System.Drawing.Size(140, 36);
            this.cbSpecializations.TabIndex = 19;
            this.cbSpecializations.Visible = false;
            this.cbSpecializations.SelectedIndexChanged += new System.EventHandler(this.cbSpecializations_SelectedIndexChanged);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::AlShamModelSchool.Properties.Resources.icons8_teachers_100;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(140, 9);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(74, 78);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 17;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.BorderRadius = 6;
            this.guna2ContainerControl1.Controls.Add(this.label3);
            this.guna2ContainerControl1.Controls.Add(this.lbTeachersCount);
            this.guna2ContainerControl1.Controls.Add(this.guna2PictureBox1);
            this.guna2ContainerControl1.Location = new System.Drawing.Point(12, 46);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(234, 92);
            this.guna2ContainerControl1.TabIndex = 20;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 36);
            this.label3.TabIndex = 22;
            this.label3.Text = "Teachers";
            // 
            // lbTeachersCount
            // 
            this.lbTeachersCount.AutoSize = true;
            this.lbTeachersCount.BackColor = System.Drawing.Color.Transparent;
            this.lbTeachersCount.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeachersCount.Location = new System.Drawing.Point(19, 42);
            this.lbTeachersCount.Name = "lbTeachersCount";
            this.lbTeachersCount.Size = new System.Drawing.Size(35, 45);
            this.lbTeachersCount.TabIndex = 21;
            this.lbTeachersCount.Text = "0";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::AlShamModelSchool.Properties.Resources.icons8_turn_on_100;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(159, 14);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(61, 60);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 17;
            this.guna2PictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 32);
            this.label4.TabIndex = 23;
            this.label4.Text = "Active";
            // 
            // guna2ContainerControl3
            // 
            this.guna2ContainerControl3.BorderRadius = 6;
            this.guna2ContainerControl3.Controls.Add(this.label4);
            this.guna2ContainerControl3.Controls.Add(this.guna2PictureBox2);
            this.guna2ContainerControl3.Controls.Add(this.lbActiveTeachers);
            this.guna2ContainerControl3.Location = new System.Drawing.Point(277, 46);
            this.guna2ContainerControl3.Name = "guna2ContainerControl3";
            this.guna2ContainerControl3.Size = new System.Drawing.Size(234, 92);
            this.guna2ContainerControl3.TabIndex = 23;
            this.guna2ContainerControl3.Text = "guna2ContainerControl3";
            // 
            // lbActiveTeachers
            // 
            this.lbActiveTeachers.AutoSize = true;
            this.lbActiveTeachers.BackColor = System.Drawing.Color.Transparent;
            this.lbActiveTeachers.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActiveTeachers.Location = new System.Drawing.Point(12, 42);
            this.lbActiveTeachers.Name = "lbActiveTeachers";
            this.lbActiveTeachers.Size = new System.Drawing.Size(35, 45);
            this.lbActiveTeachers.TabIndex = 21;
            this.lbActiveTeachers.Text = "0";
            // 
            // guna2ContainerControl2
            // 
            this.guna2ContainerControl2.BorderRadius = 6;
            this.guna2ContainerControl2.Controls.Add(this.lable12);
            this.guna2ContainerControl2.Controls.Add(this.guna2PictureBox3);
            this.guna2ContainerControl2.Controls.Add(this.lbDeactivateTeachers);
            this.guna2ContainerControl2.Location = new System.Drawing.Point(536, 46);
            this.guna2ContainerControl2.Name = "guna2ContainerControl2";
            this.guna2ContainerControl2.Size = new System.Drawing.Size(234, 92);
            this.guna2ContainerControl2.TabIndex = 24;
            this.guna2ContainerControl2.Text = "guna2ContainerControl2";
            // 
            // lable12
            // 
            this.lable12.AutoSize = true;
            this.lable12.BackColor = System.Drawing.Color.Transparent;
            this.lable12.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable12.Location = new System.Drawing.Point(12, 15);
            this.lable12.Name = "lable12";
            this.lable12.Size = new System.Drawing.Size(99, 32);
            this.lable12.TabIndex = 23;
            this.lable12.Text = "Deactivate";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = global::AlShamModelSchool.Properties.Resources.icons8_block_100;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(159, 14);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(61, 60);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 17;
            this.guna2PictureBox3.TabStop = false;
            // 
            // lbDeactivateTeachers
            // 
            this.lbDeactivateTeachers.AutoSize = true;
            this.lbDeactivateTeachers.BackColor = System.Drawing.Color.Transparent;
            this.lbDeactivateTeachers.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeactivateTeachers.Location = new System.Drawing.Point(12, 42);
            this.lbDeactivateTeachers.Name = "lbDeactivateTeachers";
            this.lbDeactivateTeachers.Size = new System.Drawing.Size(35, 45);
            this.lbDeactivateTeachers.TabIndex = 21;
            this.lbDeactivateTeachers.Text = "0";
            // 
            // guna2ContainerControl4
            // 
            this.guna2ContainerControl4.BorderRadius = 6;
            this.guna2ContainerControl4.Controls.Add(this.label5);
            this.guna2ContainerControl4.Controls.Add(this.guna2PictureBox4);
            this.guna2ContainerControl4.Controls.Add(this.lbTotalSalary);
            this.guna2ContainerControl4.Location = new System.Drawing.Point(798, 46);
            this.guna2ContainerControl4.Name = "guna2ContainerControl4";
            this.guna2ContainerControl4.Size = new System.Drawing.Size(234, 92);
            this.guna2ContainerControl4.TabIndex = 26;
            this.guna2ContainerControl4.Text = "guna2ContainerControl4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 32);
            this.label5.TabIndex = 23;
            this.label5.Text = "Total Salary";
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox4.Image = global::AlShamModelSchool.Properties.Resources.icons8_salary_100;
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(159, 14);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(61, 60);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 17;
            this.guna2PictureBox4.TabStop = false;
            // 
            // lbTotalSalary
            // 
            this.lbTotalSalary.AutoSize = true;
            this.lbTotalSalary.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalSalary.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbTotalSalary.Location = new System.Drawing.Point(12, 42);
            this.lbTotalSalary.Name = "lbTotalSalary";
            this.lbTotalSalary.Size = new System.Drawing.Size(30, 40);
            this.lbTotalSalary.TabIndex = 21;
            this.lbTotalSalary.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 36);
            this.label1.TabIndex = 27;
            this.label1.Text = "Manage Teachers";
            // 
            // btnAddNewTeacher
            // 
            this.btnAddNewTeacher.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddNewTeacher.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnAddNewTeacher.Image = global::AlShamModelSchool.Properties.Resources.Add;
            this.btnAddNewTeacher.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddNewTeacher.ImageRotate = 0F;
            this.btnAddNewTeacher.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddNewTeacher.Location = new System.Drawing.Point(1209, 143);
            this.btnAddNewTeacher.Name = "btnAddNewTeacher";
            this.btnAddNewTeacher.PressedState.ImageSize = new System.Drawing.Size(47, 47);
            this.btnAddNewTeacher.Size = new System.Drawing.Size(45, 48);
            this.btnAddNewTeacher.TabIndex = 28;
            this.btnAddNewTeacher.Click += new System.EventHandler(this.btnAddNewTeacher_Click);
            // 
            // frmManageTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1275, 642);
            this.Controls.Add(this.btnAddNewTeacher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ContainerControl4);
            this.Controls.Add(this.guna2ContainerControl2);
            this.Controls.Add(this.guna2ContainerControl3);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Controls.Add(this.cbSpecializations);
            this.Controls.Add(this.cbActivity);
            this.Controls.Add(this.cbFilterItems);
            this.Controls.Add(this.tbFilterString);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvTeachers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageTeachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Teachers";
            this.Load += new System.EventHandler(this.frmManageTeachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.cmsManageTeachers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2ContainerControl1.ResumeLayout(false);
            this.guna2ContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.guna2ContainerControl3.ResumeLayout(false);
            this.guna2ContainerControl3.PerformLayout();
            this.guna2ContainerControl2.ResumeLayout(false);
            this.guna2ContainerControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.guna2ContainerControl4.ResumeLayout(false);
            this.guna2ContainerControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvTeachers;
        private System.Windows.Forms.ContextMenuStrip cmsManageTeachers;
        private System.Windows.Forms.ToolStripMenuItem addNewpersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeletePersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refrashToolStripMenuItem1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbActivity;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterItems;
        private Guna.UI2.WinForms.Guna2TextBox tbFilterString;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2ComboBox cbSpecializations;
        private System.Windows.Forms.ToolStripMenuItem activityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ActivateTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeactivateTeacherToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private System.Windows.Forms.Label lbTeachersCount;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl3;
        private System.Windows.Forms.Label lbActiveTeachers;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl2;
        private System.Windows.Forms.Label lable12;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Label lbDeactivateTeachers;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private System.Windows.Forms.Label lbTotalSalary;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddNewTeacher;
    }
}