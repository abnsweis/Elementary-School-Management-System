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
    public partial class frmManageUsers : Form
    {
        private static DataTable _dtAllUsers = clsUser.GetAllUsers();
        private DataTable _dtUsers = _dtAllUsers.DefaultView.ToTable();
        public frmManageUsers()
        {
            InitializeComponent();
        }
        private void _RefreshUsersList()
        {
            _dtAllUsers = clsUser.GetAllUsers();
            _dtUsers = _dtAllUsers.DefaultView.ToTable(false);

            cbFilterItems.SelectedIndex = 0;
            dgvUsers.DataSource = _dtUsers;
            lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
        }
        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = _dtUsers;
            cbFilterItems.SelectedIndex = 0;
            cbFilterByActivity.SelectedIndex = 0;
            lblRecordsCount.Text = _dtUsers.Rows.Count.ToString();

        }
        private void tbFilterString_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterItems.Text)
            {
                case "User ID":
                    FilterColumn = "UserID";
                    break;
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "Username":
                    FilterColumn = "Username";
                    break;


                default:
                    FilterColumn = "None";
                    break;

            }




            //Reset the filters in case nothing selected or filter value conains nothing.
            if (tbFilterString.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtUsers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "UserID" || FilterColumn == "PersonID")
                //in this case we deal with integer not string.

                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tbFilterString.Text.Trim());
            else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tbFilterString.Text.Trim());

            lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
        }

        private void cbFilterItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dtUsers = _dtAllUsers.DefaultView.ToTable(false);
            dgvUsers.DataSource = _dtUsers;
            string FilterColumn = cbFilterItems.Text;

            if (FilterColumn == "None")
            {
                tbFilterString.Visible = false;
                cbFilterByActivity.Visible = false;
                _RefreshUsersList();
            } else if (FilterColumn == "Is Active")
            {
                tbFilterString.Visible = false;
                cbFilterByActivity.Visible = true;
            } else
            {
                tbFilterString.Visible = true;
                cbFilterByActivity.Visible = false;
                tbFilterString.Text = "";
                tbFilterString.Focus();
            }
        }

        private void cbFilterByActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterItems.Text.Trim() == "Is Active")
            {
                if (cbFilterByActivity.SelectedIndex == 0)
                {
                    _dtUsers.DefaultView.RowFilter = "";
                    lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
                    return;

                }

                bool isActive = cbFilterByActivity.Text.Trim() == "Active" ? true : false;
                _dtUsers.DefaultView.RowFilter = $"[IsActive] = {isActive}";
                lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
                return;
            }
        }

        private void tbFilterString_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (cbFilterItems.Text == "User ID" || cbFilterItems.Text == "Person ID")
            {
                 
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; 
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refrashToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _RefreshUsersList();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateUser();
            frm.ShowDialog();
            _RefreshUsersList();
        }

        private void updateUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = new frmAddUpdateUser(Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value));
            form.ShowDialog();
            _RefreshUsersList();
        }

        private void DeleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure do you want to delete this User", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsUser.Delete((int)dgvUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshUsersList();
                } else
                    MessageBox.Show("User was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void showUserDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmUserDetails((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
