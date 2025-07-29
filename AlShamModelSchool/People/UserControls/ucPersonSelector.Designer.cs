namespace AlShamModelSchool.People.UserControls
{
    partial class ucPersonSelector
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
            this.label9 = new System.Windows.Forms.Label();
            this.cbFIlterItems = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbFilterString = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSerach = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewPerson = new Guna.UI2.WinForms.Guna2Button();
            this.lbFiltervalueRequired = new System.Windows.Forms.Label();
            this.FilterContainer = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.ucPersonInfo1 = new AlShamModelSchool.People.UserControls.ucPersonInfo();
            this.FilterContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "Fillter By :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cbFIlterItems
            // 
            this.cbFIlterItems.BackColor = System.Drawing.Color.Transparent;
            this.cbFIlterItems.BorderRadius = 5;
            this.cbFIlterItems.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFIlterItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFIlterItems.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFIlterItems.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFIlterItems.Font = new System.Drawing.Font("Dubai", 9.749999F);
            this.cbFIlterItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFIlterItems.ItemHeight = 27;
            this.cbFIlterItems.Items.AddRange(new object[] {
            "Person ID",
            "National ID"});
            this.cbFIlterItems.Location = new System.Drawing.Point(80, 7);
            this.cbFIlterItems.Name = "cbFIlterItems";
            this.cbFIlterItems.Size = new System.Drawing.Size(124, 33);
            this.cbFIlterItems.StartIndex = 0;
            this.cbFIlterItems.TabIndex = 32;
            this.cbFIlterItems.SelectedIndexChanged += new System.EventHandler(this.cbFIlterItems_SelectedIndexChanged);
            // 
            // tbFilterString
            // 
            this.tbFilterString.BorderRadius = 5;
            this.tbFilterString.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFilterString.DefaultText = "";
            this.tbFilterString.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFilterString.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFilterString.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFilterString.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFilterString.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFilterString.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbFilterString.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFilterString.Location = new System.Drawing.Point(222, 7);
            this.tbFilterString.Name = "tbFilterString";
            this.tbFilterString.PasswordChar = '\0';
            this.tbFilterString.PlaceholderText = "";
            this.tbFilterString.SelectedText = "";
            this.tbFilterString.Size = new System.Drawing.Size(200, 33);
            this.tbFilterString.TabIndex = 33;
            this.tbFilterString.TextChanged += new System.EventHandler(this.tbFilterString_TextChanged);
            this.tbFilterString.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterString_KeyPress);
            // 
            // btnSerach
            // 
            this.btnSerach.BorderRadius = 6;
            this.btnSerach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSerach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSerach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSerach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSerach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btnSerach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSerach.ForeColor = System.Drawing.Color.White;
            this.btnSerach.Location = new System.Drawing.Point(428, 7);
            this.btnSerach.Name = "btnSerach";
            this.btnSerach.Size = new System.Drawing.Size(81, 33);
            this.btnSerach.TabIndex = 34;
            this.btnSerach.Text = "Serach";
            this.btnSerach.Click += new System.EventHandler(this.btnSerach_Click);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.BorderRadius = 6;
            this.btnAddNewPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewPerson.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.btnAddNewPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPerson.Location = new System.Drawing.Point(631, 7);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(81, 33);
            this.btnAddNewPerson.TabIndex = 35;
            this.btnAddNewPerson.Text = "Add New";
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // lbFiltervalueRequired
            // 
            this.lbFiltervalueRequired.AutoSize = true;
            this.lbFiltervalueRequired.BackColor = System.Drawing.Color.Transparent;
            this.lbFiltervalueRequired.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltervalueRequired.ForeColor = System.Drawing.Color.Red;
            this.lbFiltervalueRequired.Location = new System.Drawing.Point(222, 43);
            this.lbFiltervalueRequired.Name = "lbFiltervalueRequired";
            this.lbFiltervalueRequired.Size = new System.Drawing.Size(42, 18);
            this.lbFiltervalueRequired.TabIndex = 37;
            this.lbFiltervalueRequired.Tag = " ";
            this.lbFiltervalueRequired.Text = ".................";
            this.lbFiltervalueRequired.Visible = false;
            // 
            // FilterContainer
            // 
            this.FilterContainer.Controls.Add(this.btnAddNewPerson);
            this.FilterContainer.Controls.Add(this.tbFilterString);
            this.FilterContainer.Controls.Add(this.label9);
            this.FilterContainer.Controls.Add(this.cbFIlterItems);
            this.FilterContainer.Controls.Add(this.btnSerach);
            this.FilterContainer.FillColor = System.Drawing.Color.Transparent;
            this.FilterContainer.Location = new System.Drawing.Point(3, 3);
            this.FilterContainer.Name = "FilterContainer";
            this.FilterContainer.Size = new System.Drawing.Size(718, 50);
            this.FilterContainer.TabIndex = 38;
            this.FilterContainer.Text = "guna2ContainerControl1";
            // 
            // ucPersonInfo1
            // 
            this.ucPersonInfo1.Location = new System.Drawing.Point(11, 49);
            this.ucPersonInfo1.Name = "ucPersonInfo1";
            this.ucPersonInfo1.ShowUserIDFiled = false;
            this.ucPersonInfo1.Size = new System.Drawing.Size(671, 278);
            this.ucPersonInfo1.TabIndex = 39;
            this.ucPersonInfo1.Title = "Person Details";
            // 
            // ucPersonSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucPersonInfo1);
            this.Controls.Add(this.FilterContainer);
            this.Controls.Add(this.lbFiltervalueRequired);
            this.MinimumSize = new System.Drawing.Size(718, 330);
            this.Name = "ucPersonSelector";
            this.Size = new System.Drawing.Size(718, 330);
            this.FilterContainer.ResumeLayout(false);
            this.FilterContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox cbFIlterItems;
        private Guna.UI2.WinForms.Guna2TextBox tbFilterString;
        private Guna.UI2.WinForms.Guna2Button btnSerach;
        private Guna.UI2.WinForms.Guna2Button btnAddNewPerson;
        private System.Windows.Forms.Label lbFiltervalueRequired;
        private Guna.UI2.WinForms.Guna2ContainerControl FilterContainer;
        public ucPersonInfo ucPersonInfo1;
    }
}
