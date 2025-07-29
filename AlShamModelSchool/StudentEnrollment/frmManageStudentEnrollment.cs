using AlShamModelSchool.Parents;
using AlShamModelSchool.Students;
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

namespace AlShamModelSchool.StudentEnrollment
{
    public partial class frmManageStudentEnrollment : Form
    {
        private static DataTable _dtAllStudentEnrollment = clsStudentEnrollment.GetAllStudentEnrollments();
        public frmManageStudentEnrollment()
        {
            InitializeComponent();
        }

        private void _RefreshStudentsEnrollments()
        {
            _dtAllStudentEnrollment = clsStudentEnrollment.GetAllStudentEnrollments(); 

            dgvStudentEnrollment.DataSource = _dtAllStudentEnrollment.DefaultView;
            lblRecordsCount.Text = dgvStudentEnrollment.Rows.Count.ToString();


        }
        private void frmManageStudentEnrollment_Load(object sender, EventArgs e)
        {
            dgvStudentEnrollment.DataSource = _dtAllStudentEnrollment.DefaultView;

            lblRecordsCount.Text = dgvStudentEnrollment.Rows.Count.ToString();

            if (dgvStudentEnrollment.Rows.Count > 0)
            {
                dgvStudentEnrollment.Columns[0].HeaderText = "ID";
                dgvStudentEnrollment.Columns[0].Width = 50;

                dgvStudentEnrollment.Columns[1].HeaderText = "Full Name";
                dgvStudentEnrollment.Columns[1].Width = 130;

                dgvStudentEnrollment.Columns[2].HeaderText = "Student Number";
                dgvStudentEnrollment.Columns[2].Width = 150;


                dgvStudentEnrollment.Columns[3].HeaderText = "Grade Level Name";
                dgvStudentEnrollment.Columns[3].Width = 180;

                dgvStudentEnrollment.Columns[4].HeaderText = "Class Name";
                dgvStudentEnrollment.Columns[4].Width = 100;

                dgvStudentEnrollment.Columns[5].HeaderText = "Is Repeating";
                dgvStudentEnrollment.Columns[5].Width = 110;

                dgvStudentEnrollment.Columns[6].HeaderText = "Enrollment Date";
                dgvStudentEnrollment.Columns[6].Width = 130;

                dgvStudentEnrollment.Columns[7].HeaderText = "Exit Date";
                dgvStudentEnrollment.Columns[7].Width = 110;                
                
                dgvStudentEnrollment.Columns[8].HeaderText = "Status";
                dgvStudentEnrollment.Columns[8].Width = 70;

                dgvStudentEnrollment.Columns[9].HeaderText = "ExitReason";
                dgvStudentEnrollment.Columns[9].Width = 130;

                dgvStudentEnrollment.Columns[10].HeaderText = "Notes";
                dgvStudentEnrollment.Columns[10].Width = 130;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnrollmentNewStudent_Click(object sender, EventArgs e)
        {
            Form frm = new frmEnrollmentNewStudent();
            frm.ShowDialog();
            _RefreshStudentsEnrollments();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmEnrollmentNewStudent((int)dgvStudentEnrollment.CurrentRow.Cells["ID"].Value);
            frm.ShowDialog();
            _RefreshStudentsEnrollments();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure do you want to delete this Student Enrollment", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (clsStudentEnrollment.Delete((int)dgvStudentEnrollment.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show(" Student Enrollment Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshStudentsEnrollments();

                } else
                    MessageBox.Show(" Student Enrollment was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void refrashToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _RefreshStudentsEnrollments();
        }

        private void addEnrollmentNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmEnrollmentNewStudent();
            frm.ShowDialog();
            _RefreshStudentsEnrollments();
        }

        private void studentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var  studentNumber = (string)dgvStudentEnrollment.CurrentRow.Cells["StudentNumber"].Value;
            if (clsStudent.IsStudentExist(studentNumber))
            {
                


                frmStudentDetails frm = new frmStudentDetails(studentNumber);
                frm.ShowDialog();
            }

        }

        private void cbFilterItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = cbFilterItems.Text;

            if (FilterColumn == "None")
            {
                tbFilterString.Visible = false;
                //cbFilterByGender.Visible = false;
                _RefreshStudentsEnrollments();
            }  else
            {
                tbFilterString.Visible = true;
                //cbFilterByGender.Visible = false;
                tbFilterString.Text = "";
                tbFilterString.Focus();
            }
        }

        private void tbFilterString_TextChanged(object sender, EventArgs e)
        {
             string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterItems.Text)
            {
                 

                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                     
                case "Student Number":
                    FilterColumn = "StudentNumber";
                    break;

                case "Class Name":
                    FilterColumn = "ClassName";
                    break;
                 

                default:
                    FilterColumn = "None";
                    break;

            }


            

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (tbFilterString.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllStudentEnrollment.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvStudentEnrollment.Rows.Count.ToString();
                return;
            }

            _dtAllStudentEnrollment.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tbFilterString.Text.Trim());

            lblRecordsCount.Text = dgvStudentEnrollment.Rows.Count.ToString();
        }
    }
}
