using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlShamModelSchool.Users
{
    public partial class frmUserDetails : Form
    {
        int _UserID= -1;
        int _PersonID = -1;
        clsUser _User;

        public frmUserDetails(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }
        public frmUserDetails(int PersonID,bool IsPerosID)
        {
            InitializeComponent();
            _PersonID = PersonID;

            if (clsUser.IsUserExistByPersonID(_PersonID))
            {
                _User = clsUser.FindByPersonID(_PersonID);
                _UserID = _User.UserID;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            ucPersonInfo1.ShowUserIDFiled = true;

            if (clsUser.IsUserExist(_UserID))
            {

                _User = clsUser.Find(_UserID);
                ucPersonInfo1.lbUserID.Text = _UserID.ToString();
                ucPersonInfo1.LoadPerson(_User.PersonID);
                lbUsername.Text = _User.UserName;
                lbIsActive.Text = _User.IsActive ? "Yes" : "No";
                this.Text = _User.Person.FullName;

            } else
            {
                MessageBox.Show($"Not Found With ID {_User}","User Not Found",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ucPersonInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
