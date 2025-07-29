namespace AlShamModelSchool.Parents
{
    partial class frmParentsList
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
            this.cmsManageParents = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewpersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showParentsDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refrashToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNewParents = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.cbFilterItems = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbFatherFilterString = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.cbMotherFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbFatherFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvParents = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tbMotherFilterString = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmsManageParents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParents)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsManageParents
            // 
            this.cmsManageParents.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsManageParents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewpersonToolStripMenuItem,
            this.DeletePersonToolStripMenuItem,
            this.updateToolStripMenuItem1,
            this.showParentsDetailsToolStripMenuItem,
            this.refrashToolStripMenuItem1});
            this.cmsManageParents.Name = "cmsManagePeople";
            this.cmsManageParents.Size = new System.Drawing.Size(220, 184);
            // 
            // addNewpersonToolStripMenuItem
            // 
            this.addNewpersonToolStripMenuItem.Image = global::AlShamModelSchool.Properties.Resources.addNewPerson;
            this.addNewpersonToolStripMenuItem.Name = "addNewpersonToolStripMenuItem";
            this.addNewpersonToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addNewpersonToolStripMenuItem.Size = new System.Drawing.Size(219, 36);
            this.addNewpersonToolStripMenuItem.Text = "Add New Person";
            // 
            // DeletePersonToolStripMenuItem
            // 
            this.DeletePersonToolStripMenuItem.Image = global::AlShamModelSchool.Properties.Resources.DeletePerson;
            this.DeletePersonToolStripMenuItem.Name = "DeletePersonToolStripMenuItem";
            this.DeletePersonToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeletePersonToolStripMenuItem.Size = new System.Drawing.Size(219, 36);
            this.DeletePersonToolStripMenuItem.Text = "Delete";
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Image = global::AlShamModelSchool.Properties.Resources.UpdatePerson;
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(219, 36);
            this.updateToolStripMenuItem1.Text = "Update";
            // 
            // showParentsDetailsToolStripMenuItem
            // 
            this.showParentsDetailsToolStripMenuItem.Image = global::AlShamModelSchool.Properties.Resources.icons8_info_100;
            this.showParentsDetailsToolStripMenuItem.Name = "showParentsDetailsToolStripMenuItem";
            this.showParentsDetailsToolStripMenuItem.Size = new System.Drawing.Size(219, 36);
            this.showParentsDetailsToolStripMenuItem.Text = "Show Parents  Details";
            this.showParentsDetailsToolStripMenuItem.Click += new System.EventHandler(this.showParentsDetailsToolStripMenuItem_Click);
            // 
            // refrashToolStripMenuItem1
            // 
            this.refrashToolStripMenuItem1.Image = global::AlShamModelSchool.Properties.Resources.Refresh;
            this.refrashToolStripMenuItem1.Name = "refrashToolStripMenuItem1";
            this.refrashToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refrashToolStripMenuItem1.Size = new System.Drawing.Size(219, 36);
            this.refrashToolStripMenuItem1.Text = "Refrash";
            // 
            // btnAddNewParents
            // 
            this.btnAddNewParents.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddNewParents.HoverState.ImageSize = new System.Drawing.Size(60, 60);
            this.btnAddNewParents.Image = global::AlShamModelSchool.Properties.Resources.addNewPeoples;
            this.btnAddNewParents.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddNewParents.ImageRotate = 0F;
            this.btnAddNewParents.Location = new System.Drawing.Point(912, 54);
            this.btnAddNewParents.Name = "btnAddNewParents";
            this.btnAddNewParents.PressedState.ImageSize = new System.Drawing.Size(62, 62);
            this.btnAddNewParents.Size = new System.Drawing.Size(79, 78);
            this.btnAddNewParents.TabIndex = 19;
            this.btnAddNewParents.Click += new System.EventHandler(this.btnAddNewParents_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "Manage Parents";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::AlShamModelSchool.Properties.Resources.People2;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(23, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(93, 76);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 17;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(125, 612);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(20, 25);
            this.lblRecordsCount.TabIndex = 15;
            this.lblRecordsCount.Text = "0";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Location = new System.Drawing.Point(18, 612);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(110, 25);
            this.lable1.TabIndex = 14;
            this.lable1.Text = "Parents Count :";
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
            "Father",
            "Mother",
            "Father & Mother"});
            this.cbFilterItems.Location = new System.Drawing.Point(23, 96);
            this.cbFilterItems.Name = "cbFilterItems";
            this.cbFilterItems.Size = new System.Drawing.Size(163, 36);
            this.cbFilterItems.StartIndex = 0;
            this.cbFilterItems.TabIndex = 13;
            this.cbFilterItems.SelectedIndexChanged += new System.EventHandler(this.cbFilterItems_SelectedIndexChanged);
            // 
            // tbFatherFilterString
            // 
            this.tbFatherFilterString.BorderRadius = 6;
            this.tbFatherFilterString.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFatherFilterString.DefaultText = "";
            this.tbFatherFilterString.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFatherFilterString.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFatherFilterString.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFatherFilterString.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFatherFilterString.Enabled = false;
            this.tbFatherFilterString.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFatherFilterString.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbFatherFilterString.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFatherFilterString.Location = new System.Drawing.Point(205, 165);
            this.tbFatherFilterString.Name = "tbFatherFilterString";
            this.tbFatherFilterString.PasswordChar = '\0';
            this.tbFatherFilterString.PlaceholderText = "";
            this.tbFatherFilterString.SelectedText = "";
            this.tbFatherFilterString.Size = new System.Drawing.Size(292, 36);
            this.tbFatherFilterString.TabIndex = 12;
            this.tbFatherFilterString.TextChanged += new System.EventHandler(this.tbFilterString_TextChanged);
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
            this.btnClose.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(856, 605);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 39);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbMotherFilter
            // 
            this.cbMotherFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbMotherFilter.BorderRadius = 6;
            this.cbMotherFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMotherFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMotherFilter.Enabled = false;
            this.cbMotherFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMotherFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMotherFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMotherFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMotherFilter.ItemHeight = 30;
            this.cbMotherFilter.Items.AddRange(new object[] {
            "None",
            "Mother ID",
            "Mother NationalID",
            "Mother Name"});
            this.cbMotherFilter.Location = new System.Drawing.Point(513, 165);
            this.cbMotherFilter.Name = "cbMotherFilter";
            this.cbMotherFilter.Size = new System.Drawing.Size(163, 36);
            this.cbMotherFilter.StartIndex = 0;
            this.cbMotherFilter.TabIndex = 20;
            this.cbMotherFilter.SelectedIndexChanged += new System.EventHandler(this.cFilter_SelectedIndexChanged);
            // 
            // cbFatherFilter
            // 
            this.cbFatherFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFatherFilter.BorderRadius = 6;
            this.cbFatherFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFatherFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFatherFilter.Enabled = false;
            this.cbFatherFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFatherFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFatherFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFatherFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFatherFilter.ItemHeight = 30;
            this.cbFatherFilter.Items.AddRange(new object[] {
            "None",
            "Father ID",
            "Father NationalID",
            "Father Name"});
            this.cbFatherFilter.Location = new System.Drawing.Point(18, 165);
            this.cbFatherFilter.Name = "cbFatherFilter";
            this.cbFatherFilter.Size = new System.Drawing.Size(171, 36);
            this.cbFatherFilter.StartIndex = 0;
            this.cbFatherFilter.TabIndex = 21;
            this.cbFatherFilter.SelectedIndexChanged += new System.EventHandler(this.cFilter_SelectedIndexChanged);
            // 
            // dgvParents
            // 
            this.dgvParents.AllowUserToAddRows = false;
            this.dgvParents.AllowUserToDeleteRows = false;
            this.dgvParents.AllowUserToResizeColumns = false;
            this.dgvParents.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(117)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvParents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvParents.CausesValidation = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvParents.ColumnHeadersHeight = 31;
            this.dgvParents.ContextMenuStrip = this.cmsManageParents;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(117)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParents.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvParents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvParents.Location = new System.Drawing.Point(23, 233);
            this.dgvParents.Name = "dgvParents";
            this.dgvParents.ReadOnly = true;
            this.dgvParents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParents.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvParents.RowHeadersVisible = false;
            this.dgvParents.RowTemplate.Height = 31;
            this.dgvParents.Size = new System.Drawing.Size(970, 355);
            this.dgvParents.TabIndex = 22;
            this.dgvParents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvParents.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvParents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.dgvParents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(117)))), ((int)(((byte)(155)))));
            this.dgvParents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvParents.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvParents.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvParents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
            this.dgvParents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvParents.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvParents.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvParents.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvParents.ThemeStyle.HeaderStyle.Height = 31;
            this.dgvParents.ThemeStyle.ReadOnly = true;
            this.dgvParents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.dgvParents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvParents.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvParents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvParents.ThemeStyle.RowsStyle.Height = 31;
            this.dgvParents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(104)))));
            this.dgvParents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvParents.DoubleClick += new System.EventHandler(this.dgvParents_DoubleClick);
            // 
            // tbMotherFilterString
            // 
            this.tbMotherFilterString.BorderRadius = 6;
            this.tbMotherFilterString.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMotherFilterString.DefaultText = "";
            this.tbMotherFilterString.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMotherFilterString.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMotherFilterString.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMotherFilterString.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMotherFilterString.Enabled = false;
            this.tbMotherFilterString.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMotherFilterString.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbMotherFilterString.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMotherFilterString.Location = new System.Drawing.Point(689, 165);
            this.tbMotherFilterString.Name = "tbMotherFilterString";
            this.tbMotherFilterString.PasswordChar = '\0';
            this.tbMotherFilterString.PlaceholderText = "";
            this.tbMotherFilterString.SelectedText = "";
            this.tbMotherFilterString.Size = new System.Drawing.Size(302, 36);
            this.tbMotherFilterString.TabIndex = 23;
            this.tbMotherFilterString.TextChanged += new System.EventHandler(this.tbFilterString_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(514, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mother Filter :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Father Filter :";
            // 
            // frmParentsList
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1015, 654);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMotherFilterString);
            this.Controls.Add(this.dgvParents);
            this.Controls.Add(this.cbFatherFilter);
            this.Controls.Add(this.cbMotherFilter);
            this.Controls.Add(this.btnAddNewParents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.cbFilterItems);
            this.Controls.Add(this.tbFatherFilterString);
            this.Controls.Add(this.btnClose);
            this.MaximumSize = new System.Drawing.Size(1031, 693);
            this.MinimumSize = new System.Drawing.Size(1031, 693);
            this.Name = "frmParentsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parents List";
            this.Load += new System.EventHandler(this.frmParentsList_Load);
            this.cmsManageParents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsManageParents;
        private System.Windows.Forms.ToolStripMenuItem addNewpersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeletePersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showParentsDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refrashToolStripMenuItem1;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddNewParents;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label lable1;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterItems;
        private Guna.UI2.WinForms.Guna2TextBox tbFatherFilterString;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2ComboBox cbMotherFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cbFatherFilter;
        private Guna.UI2.WinForms.Guna2DataGridView dgvParents;
        private Guna.UI2.WinForms.Guna2TextBox tbMotherFilterString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}