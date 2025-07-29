using AlShamModelSchool.People;
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

namespace AlShamModelSchool.Teachers
{
    public partial class frmManageTeachers : Form
    {
        private static DataTable _dtAllTeachers ;
        private DataTable _dtTeachers ;
        public frmManageTeachers()
        {
            InitializeComponent();
        }


        private void _RefreshTeachersList()
        {
            _dtAllTeachers = clsTeacher.GetAllTeachers();
            _dtTeachers = _dtAllTeachers.DefaultView.ToTable(false);
             
            dgvTeachers.DataSource = _dtTeachers;
            CustomizeHeader();
            cbFilterItems.SelectedIndex = 0; 
        }
        private void frmManageTeachers_Load(object sender, EventArgs e)
        {
            frmAddUpdateTeacher.FillcbSubjectsinCombobox(cbSpecializations);
            cbSpecializations.SelectedIndex = -1;
            dgvTeachers.DataSource = _dtTeachers;
            _RefreshTeachersList();
            CustomizeHeader();
             

            if (dgvTeachers.Rows.Count > 0)
            {
                dgvTeachers.Columns[0].HeaderText = "ID";
                dgvTeachers.Columns[0].Width = 80;

                dgvTeachers.Columns[1].HeaderText = "Full Name";
                dgvTeachers.Columns[1].Width = 150;

                dgvTeachers.Columns[2].HeaderText = "National ID";
                dgvTeachers.Columns[2].Width = 130;

                          
                dgvTeachers.Columns[3].HeaderText = "Hire Date";
                dgvTeachers.Columns[3].Width = 110;

                dgvTeachers.Columns[4].HeaderText = "Salary";
                dgvTeachers.Columns[4].Width = 110;

                dgvTeachers.Columns[5].HeaderText = "Specializations";
                dgvTeachers.Columns[5].Width = 230;

                dgvTeachers.Columns[6].HeaderText = "Experience";
                dgvTeachers.Columns[6].Width = 100;

                dgvTeachers.Columns[7].HeaderText = "Is Active";
                dgvTeachers.Columns[7].Width = 80;                
                
                dgvTeachers.Columns[8].HeaderText = "Termination Date";
                dgvTeachers.Columns[8].Width = 150;                
                 
            }
        }

        private void CustomizeHeader()
        {
            lbTeachersCount.Text = _dtAllTeachers.DefaultView.Count.ToString();
            lbActiveTeachers.Text = clsTeacher.GetTeachersCounts(true).ToString();
            lbDeactivateTeachers.Text = clsTeacher.GetTeachersCounts(false).ToString();
            lbTotalSalary.Text = clsTeacher.GetTotalSalary().ToString("C");

            

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilterItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dtTeachers = _dtAllTeachers.DefaultView.ToTable(false);
            dgvTeachers.DataSource = _dtTeachers;
            string FilterColumn = cbFilterItems.Text;

            if (FilterColumn == "None")
            {
                tbFilterString.Visible = false;
                cbActivity.Visible = false;
                cbSpecializations.Visible = false;
                _RefreshTeachersList();
            } else if (FilterColumn == "Is Active")
            {
                tbFilterString.Visible = false;
                cbSpecializations.Visible = false;
                cbActivity.Visible = true;
                cbActivity.SelectedIndex = 0;
            } else if (FilterColumn == "Specializations")
            {
                tbFilterString.Visible = false;
                cbActivity.Visible = false;
                cbSpecializations.Visible = true;
                cbSpecializations.SelectedIndex = 0;
            } else
            {
                tbFilterString.Visible = true;
                cbActivity.Visible = false;
                cbSpecializations.Visible = false;
                tbFilterString.Text = "";
                tbFilterString.Focus();
            }
        }

        private void cbActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterItems.Text.Trim() == "Is Active")
            {
                bool isActive = cbActivity.Text.Trim() == "Active" ? true : false;
                _dtTeachers.DefaultView.RowFilter = $"[IsActive] = {isActive}"; 
                return;
            }
        }

        private void tbFilterString_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
           
            switch (cbFilterItems.Text)
            {
                case "ID":
                    FilterColumn = "TeacherID";
                    break;


                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "National ID":
                    FilterColumn = "NationalID";
                    break;

                case "Specializations":
                    FilterColumn = "Specializations";
                    break;

                case "Is Active":
                    FilterColumn = "IsActive";
                    break;
 

                default:
                    FilterColumn = "None";
                    break;

            }




            //Reset the filters in case nothing selected or filter value conains nothing.
            if (tbFilterString.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtTeachers.DefaultView.RowFilter = ""; 
                return;
            }


            if (FilterColumn == "TeacherID" )
                //in this case we deal with integer not string.

                _dtTeachers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tbFilterString.Text.Trim());
            else
                _dtTeachers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tbFilterString.Text.Trim());
             
        }

        private void refrashToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _RefreshTeachersList();
        }

        private void DeleteTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TeacherID = (int)dgvTeachers.CurrentRow.Cells["TeacherID"].Value;
            if (MessageBox.Show("Are you sure you want to delete this teacher?", "Confirm Delete",MessageBoxButtons.OK,MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsTeacher.IsTeacherExist(TeacherID))
                {
                    if (clsTeacher.Delete(TeacherID))
                    {
                        MessageBox.Show("Teacher Deleted Successfully");
                        _RefreshTeachersList();
                    } else
                    {
                        MessageBox.Show($"This teacher cannot be deleted because it is linked to other data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    MessageBox.Show($"Not Found teacher With ID {TeacherID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails((string)dgvTeachers.CurrentRow.Cells["NationalID"].Value);
            frm.ShowDialog();
        }

        private void cbSpecializations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterItems.Text.Trim() == "Specializations")
            {
                
                _dtTeachers.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "Specializations", cbSpecializations.SelectedItem.ToString());
                  
                return;
            }
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUpdateTeacher frm = new frmUpdateTeacher((int)dgvTeachers.CurrentRow.Cells["TeacherID"].Value);
            frm.ShowDialog();
            _RefreshTeachersList();
        }

        private void cmsManageTeachers_Opening(object sender, CancelEventArgs e)
        {
            if (dgvTeachers.CurrentRow != null)
            {
                int teacherID = (int)dgvTeachers.CurrentRow?.Cells["TeacherID"].Value;
                bool isActive = clsTeacher.isTeacherActive(teacherID);
                
                ActivateTeacherToolStripMenuItem.Enabled =! isActive;
                DeactivateTeacherToolStripMenuItem.Enabled = isActive;

            } else
            {
                e.Cancel = true;
            }

            
        }

        private void ActivateTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int teacherID = (int)dgvTeachers.CurrentRow.Cells["TeacherID"].Value;
            clsTeacher.Activate(teacherID);
            MessageBox.Show("Teacher Activate Successfully", "Activity", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _RefreshTeachersList();
        }

        private void DeactivateTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int teacherID = (int)dgvTeachers.CurrentRow.Cells["TeacherID"].Value;
            clsTeacher.Deactivate(teacherID);
            MessageBox.Show("Teacher Deactivate Successfully", "Activity", MessageBoxButtons.OK,MessageBoxIcon.Information);
            _RefreshTeachersList();
        }

        private void addNewpersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateTeacher();
            frm.ShowDialog();
            _RefreshTeachersList();
        }

        private void btnAddNewTeacher_Click(object sender, EventArgs e)
        {
            frmAddUpdateTeacher frm = new frmAddUpdateTeacher();
            frm.ShowDialog();
            _RefreshTeachersList();
        }
    }
}
