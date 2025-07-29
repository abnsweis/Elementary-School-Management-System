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

namespace AlShamModelSchool.People
{
    public partial class frmManagePeople : Form
    {

        private static DataTable _dtAllPeople = clsPerson.GetAllPeople();
        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable();
        public frmManagePeople()
        {
            InitializeComponent();
        }
    

        private void _RefreshPeopleList()
        {
            _dtAllPeople = clsPerson.GetAllPeople();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false);

            cbFilterItems.SelectedIndex = 0;
            dgvPeople.DataSource = _dtPeople;
            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
        }
        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            dgvPeople.DataSource = _dtPeople;
            cbFilterItems.SelectedIndex = 0;
            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();

            if (dgvPeople.Rows.Count > 0)
            {
                dgvPeople.Columns[0].HeaderText = "Person ID";
                dgvPeople.Columns[0].Width = 80;

                dgvPeople.Columns[1].HeaderText = "Full Name";
                dgvPeople.Columns[1].Width = 150;

                dgvPeople.Columns[2].HeaderText = "Birth Date";
                dgvPeople.Columns[2].Width = 110;


                dgvPeople.Columns[3].HeaderText = "Gender";
                dgvPeople.Columns[3].Width = 60;

                dgvPeople.Columns[4].HeaderText = "Phone";
                dgvPeople.Columns[4].Width = 110;

                dgvPeople.Columns[5].HeaderText = "Email";
                dgvPeople.Columns[5].Width = 160;

                dgvPeople.Columns[6].HeaderText = "Address";
                dgvPeople.Columns[6].Width = 130;
                
                dgvPeople.Columns[7].HeaderText = "NationalID";
                dgvPeople.Columns[7].Width = 120;
            }
        }

        private void dgvPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbFilterString_TextChanged(object sender, EventArgs e)
        { 
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterItems.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Gendor":
                    FilterColumn = "GendorCaption";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;
                case "Address":
                    FilterColumn = "Address";
                    break;
                case "NationalID":
                    FilterColumn = "NationalID";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }


            

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (tbFilterString.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "PersonID")
                //in this case we deal with integer not string.

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tbFilterString.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tbFilterString.Text.Trim());

            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();

        }

        private void cbFilterItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = cbFilterItems.Text;

            if (FilterColumn == "None")
            {
                tbFilterString.Visible = false;
                cbFilterByGender.Visible = false;
                _RefreshPeopleList();
            } else if (FilterColumn == "Gender")
            {
                tbFilterString.Visible = false;
                cbFilterByGender.Visible = true;
            } else
            {
                tbFilterString.Visible = true;
                cbFilterByGender.Visible = false;
                tbFilterString.Text = "";
                tbFilterString.Focus();
            }
        }


        private void cbFilterByGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterItems.Text.Trim() == "Gender")
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", cbFilterItems.Text.Trim(), cbFilterByGender.Text.Trim());
                lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
                return;
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void updatePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson(Convert.ToInt32(dgvPeople.SelectedRows[0].Cells[0].Value));
            frm.ShowDialog();

            _RefreshPeopleList();
             
        }

 

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void DeletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure do you want to delete this person","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                if (clsPerson.Delete((int)dgvPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeopleList();
                    
                } else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void refrashToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _RefreshPeopleList();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmPersonDetails(Convert.ToInt32(dgvPeople.SelectedRows[0].Cells[0].Value));
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void tbFilterString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterItems.Text == "PersonID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            
        }
    
    }
}
