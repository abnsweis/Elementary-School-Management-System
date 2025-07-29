using AlShamModelSchool.Properties;
using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlShamModelSchool.Users
{
    public partial class frmAddUpdateUser : Form
    {

        private enum enMode { Add, Update }

        enMode _Mode = enMode.Add;

        clsUser _User;
        int _SelectedPersonID = -1;
        int _UserID = -1;
        public frmAddUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.Add;
            

        }

        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _Mode = enMode.Update;
        }

        private void ucPersonSelector1_OnPersonSelected(int obj)
        {
            MessageBox.Show($"Seleted Person {obj}");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool VerifyFields()
        {
            // Verify Person
            if (_SelectedPersonID == -1)
            {
                MessageBox.Show("Please Select Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (clsUser.IsUserExistByPersonID(_SelectedPersonID) && _Mode == enMode.Add)
            {
                MessageBox.Show("This Person Already Has An Account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verify Username
            if (!clsVerifications.ValidateFieldWithLabel(tbUsername, lbUserNameRequired)) return false;
            if (!clsVerifications.IsValidUsername(tbUsername, lbUserNameRequired)) return false;

            // Verify Password 
            if (!clsVerifications.ValidateFieldWithLabel(tbPassword, lbPasswordRequired)) return false;
            if (!clsVerifications.ValidateFieldWithLabel(tbConfirmPassword, lbConfirmPasswordRequired)) return false; 
            if (!clsVerifications.IsMatchedPassword(tbPassword, tbConfirmPassword,lbConfirmPasswordRequired)) return false; 
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (VerifyFields())
            {

                
                _User.UserName = tbUsername.Text.Trim();
                _User.Password = tbPassword.Text.Trim();
                _User.PersonID = _SelectedPersonID;
                _User.IsActive = cbIsActive.Checked;



                if (_User.Save())
                {
                    MessageBox.Show("User Saved Successfully","Successfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Text = "Update User";
                    _UserID = _User.UserID;
                    ucPersonSelector1.ucPersonInfo1.lbUserID.Text = _UserID.ToString();

                    _Mode = enMode.Update;
                } else
                {
                    MessageBox.Show("Error Saving Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            ucPersonSelector1.ucPersonInfo1.ShowUserIDFiled = true;

            if (_Mode == enMode.Update)
            {
                _LoadData();
                return;
            }

            _User = new clsUser();
            this.Text = "Add New User";
        }

        private void _LoadData()
        {
            if (_Mode == enMode.Add)
            {
                this.Text = "Add New User";
                _User = new clsUser();
                return;
            }


            this.Text = "Update User";
            btnSave.Text = "Update";

            // Hidden password fields to prevent password modification during the modification process.
            tbPassword.Visible = false;
            tbConfirmPassword.Visible = false;
            lbPasswordTitle.Visible = false;
            lbConfirmPasswordTitle.Visible = false;

            if (clsUser.IsUserExist(_UserID))
            {
                _User = clsUser.Find(_UserID);
                if (_User != null)
                {
                    ucPersonSelector1.LoadPerson(_User.PersonID);
                    tbUsername.Text = _User.UserName;
                    tbPassword.Text = _User.Password;

                    tbConfirmPassword.Text = _User.Password;
                    cbIsActive.Checked = _User.IsActive;
                    _SelectedPersonID = _User.PersonID;
                }
            } else {

                MessageBox.Show("User Not Found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ucPersonSelector1_OnPersonSelected_1(int obj)
        {
            _SelectedPersonID = obj;
        }

        
    }
}
