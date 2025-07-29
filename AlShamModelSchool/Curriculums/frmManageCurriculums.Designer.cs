namespace AlShamModelSchool.Curriculums
{
    partial class frmManageCurriculums
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.cmsManageCurriculm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewCurriculumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refrashToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvCurriculums = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAddNewCurriculum = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cmsManageCurriculm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurriculums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 36);
            this.label1.TabIndex = 28;
            this.label1.Text = "Curriculums List";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(154, 424);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(20, 25);
            this.lblRecordsCount.TabIndex = 25;
            this.lblRecordsCount.Text = "0";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Location = new System.Drawing.Point(20, 424);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(132, 25);
            this.lable1.TabIndex = 24;
            this.lable1.Text = "Curriculum Count :";
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
            this.btnClose.Location = new System.Drawing.Point(800, 424);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(155, 33);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmsManageCurriculm
            // 
            this.cmsManageCurriculm.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsManageCurriculm.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsManageCurriculm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCurriculumToolStripMenuItem,
            this.updateToolStripMenuItem1,
            this.DeleteToolStripMenuItem,
            this.refrashToolStripMenuItem1});
            this.cmsManageCurriculm.Name = "cmsManagePeople";
            this.cmsManageCurriculm.Size = new System.Drawing.Size(252, 148);
            // 
            // addNewCurriculumToolStripMenuItem
            // 
            this.addNewCurriculumToolStripMenuItem.Image = global::AlShamModelSchool.Properties.Resources.icons8_binders_100;
            this.addNewCurriculumToolStripMenuItem.Name = "addNewCurriculumToolStripMenuItem";
            this.addNewCurriculumToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addNewCurriculumToolStripMenuItem.Size = new System.Drawing.Size(251, 36);
            this.addNewCurriculumToolStripMenuItem.Text = "Add New Curriculum";
            this.addNewCurriculumToolStripMenuItem.Click += new System.EventHandler(this.addNewCurriculumToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Image = global::AlShamModelSchool.Properties.Resources.icons8_binders_100__1_;
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(251, 36);
            this.updateToolStripMenuItem1.Text = "Update";
            this.updateToolStripMenuItem1.Click += new System.EventHandler(this.updateToolStripMenuItem1_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Image = global::AlShamModelSchool.Properties.Resources.icons8_binders_100__2_;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(251, 36);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // refrashToolStripMenuItem1
            // 
            this.refrashToolStripMenuItem1.Image = global::AlShamModelSchool.Properties.Resources.Refresh;
            this.refrashToolStripMenuItem1.Name = "refrashToolStripMenuItem1";
            this.refrashToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refrashToolStripMenuItem1.Size = new System.Drawing.Size(251, 36);
            this.refrashToolStripMenuItem1.Text = "Refrash";
            // 
            // dgvCurriculums
            // 
            this.dgvCurriculums.AllowUserToAddRows = false;
            this.dgvCurriculums.AllowUserToDeleteRows = false;
            this.dgvCurriculums.AllowUserToResizeColumns = false;
            this.dgvCurriculums.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(117)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCurriculums.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCurriculums.CausesValidation = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCurriculums.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCurriculums.ColumnHeadersHeight = 31;
            this.dgvCurriculums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCurriculums.ContextMenuStrip = this.cmsManageCurriculm;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(117)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCurriculums.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCurriculums.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCurriculums.Location = new System.Drawing.Point(23, 113);
            this.dgvCurriculums.MinimumSize = new System.Drawing.Size(800, 300);
            this.dgvCurriculums.Name = "dgvCurriculums";
            this.dgvCurriculums.ReadOnly = true;
            this.dgvCurriculums.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCurriculums.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCurriculums.RowHeadersVisible = false;
            this.dgvCurriculums.RowTemplate.Height = 31;
            this.dgvCurriculums.Size = new System.Drawing.Size(932, 300);
            this.dgvCurriculums.TabIndex = 20;
            this.dgvCurriculums.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCurriculums.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCurriculums.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.dgvCurriculums.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(117)))), ((int)(((byte)(155)))));
            this.dgvCurriculums.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCurriculums.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCurriculums.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCurriculums.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
            this.dgvCurriculums.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCurriculums.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvCurriculums.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCurriculums.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCurriculums.ThemeStyle.HeaderStyle.Height = 31;
            this.dgvCurriculums.ThemeStyle.ReadOnly = true;
            this.dgvCurriculums.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.dgvCurriculums.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCurriculums.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCurriculums.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCurriculums.ThemeStyle.RowsStyle.Height = 31;
            this.dgvCurriculums.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(104)))));
            this.dgvCurriculums.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::AlShamModelSchool.Properties.Resources.curriculum;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(23, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(70, 80);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 27;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnAddNewCurriculum
            // 
            this.btnAddNewCurriculum.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddNewCurriculum.HoverState.ImageSize = new System.Drawing.Size(52, 52);
            this.btnAddNewCurriculum.Image = global::AlShamModelSchool.Properties.Resources.icons8_binders_100;
            this.btnAddNewCurriculum.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddNewCurriculum.ImageRotate = 0F;
            this.btnAddNewCurriculum.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddNewCurriculum.Location = new System.Drawing.Point(876, 20);
            this.btnAddNewCurriculum.Name = "btnAddNewCurriculum";
            this.btnAddNewCurriculum.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddNewCurriculum.Size = new System.Drawing.Size(79, 78);
            this.btnAddNewCurriculum.TabIndex = 29;
            this.btnAddNewCurriculum.Click += new System.EventHandler(this.btnAddNewCurriculum_Click);
            // 
            // frmManageCurriculums
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(975, 463);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddNewCurriculum);
            this.Controls.Add(this.dgvCurriculums);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageCurriculums";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Curriculums";
            this.Load += new System.EventHandler(this.frmCurriculumsList_Load);
            this.cmsManageCurriculm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurriculums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label lable1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddNewCurriculum;
        private System.Windows.Forms.ToolStripMenuItem refrashToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCurriculumToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsManageCurriculm;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCurriculums;
    }
}