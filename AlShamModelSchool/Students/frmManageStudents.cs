using AlShamModelSchool.Parents;
using AlShamModelSchool.People;
using AlShamModelSchool.StudentEnrollment;
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

namespace AlShamModelSchool.Students
{
    public partial class frmManageStudents : Form
    {
        private static DataTable _dtAllStudents = clsStudent.GetAllStudents();
        private DataTable _dtStudents = _dtAllStudents.DefaultView.ToTable(false);
        public frmManageStudents()
        {
            InitializeComponent();
        }

        private void _RefreshStudentsList()
        {
            _dtAllStudents = clsStudent.GetAllStudents();
            _dtStudents = _dtAllStudents.DefaultView.ToTable(false);

            cbFilterItems.SelectedIndex = 0;
            dgvStudents.DataSource = _dtStudents;
            lblRecordsCount.Text = dgvStudents.Rows.Count.ToString();

             
        }

        private void frmManageStudents_Load(object sender, EventArgs e)
        {
            dgvStudents.DataSource = _dtStudents;
            cbFilterItems.SelectedIndex = 0;
            lblRecordsCount.Text = dgvStudents.Rows.Count.ToString();
           
            if (dgvStudents.Rows.Count > 0)
            {
                dgvStudents.Columns[0].HeaderText = "Student ID";
                dgvStudents.Columns[0].Width = 85;

                dgvStudents.Columns[1].HeaderText = "Person ID";
                dgvStudents.Columns[1].Width = 85;

                dgvStudents.Columns[2].HeaderText = "Student Number";
                dgvStudents.Columns[2].Width = 100;

                dgvStudents.Columns[3].HeaderText = "Full Name";
                dgvStudents.Columns[3].Width = 110;

                dgvStudents.Columns[4].HeaderText = "Father Name";
                dgvStudents.Columns[4].Width = 115;

                dgvStudents.Columns[5].HeaderText = "Mother Name";
                dgvStudents.Columns[5].Width = 110;

   
                dgvStudents.Columns[6].HeaderText = "Admission Date";
                dgvStudents.Columns[6].Width = 85;

                dgvStudents.Columns[7].HeaderText = "Status";
                dgvStudents.Columns[7].Width = 85;


                dgvStudents.Columns[8].HeaderText = "Notes";
                dgvStudents.Columns[8].Width = 160;
                dgvStudents.Columns[9].Visible = false;

                 

                
            }
        }


        private void tbFilterString_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterItems.Text)
            {  

                case "Student ID":
                    FilterColumn = "StudentID";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "Student Number":
                    FilterColumn = "StudentNumber";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "Father Name":
                    FilterColumn = "FatherName";
                    break;
                case "Mother Name":
                    FilterColumn = "MotherName";
                    break;
                case "Status":
                    FilterColumn = "Status";
                    break;

                 
                default:
                    FilterColumn = "None";
                    break;

            }




            //Reset the filters in case nothing selected or filter value conains nothing.
            if (tbFilterString.Text.Trim() == "" || FilterColumn == "None" )
            {
                _dtStudents.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvStudents.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "PersonID" || FilterColumn == "StudentID" || FilterColumn == "ParentsID")
                //in this case we deal with integer not string.

                _dtStudents.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tbFilterString.Text.Trim());
            else
                _dtStudents.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tbFilterString.Text.Trim());

            lblRecordsCount.Text = dgvStudents.Rows.Count.ToString();

        }

        private void cbFilterItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = cbFilterItems.Text;
            
            if (FilterColumn == "None")
            {
                _RefreshStudentsList();
                tbFilterString.Visible = false;
                cbFilterByStatus.Visible = false;
                 
            } else if (FilterColumn == "Status")
            {
                tbFilterString.Visible = false;
                cbFilterByStatus.Visible = true;
            } else
            {
                tbFilterString.Visible = true;
                cbFilterByStatus.Visible = false;
                tbFilterString.Text = "";
                tbFilterString.Focus();
            }
        }

        private void cbFilterByStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterItems.Text.Trim() == "Status")
            {
                _dtStudents.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", cbFilterItems.Text.Trim(), cbFilterByStatus.Text.Trim());
                lblRecordsCount.Text = dgvStudents.Rows.Count.ToString();
                return;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmPersonDetails(Convert.ToInt32(dgvStudents.SelectedRows[0].Cells[1].Value));
            frm.ShowDialog();
             
        }

        private void refrashToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _RefreshStudentsList();
        }

        private void tbFilterString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterItems.Text == "Person ID" || cbFilterItems.Text == "Parents ID" || cbFilterItems.Text == "Student ID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

        }

         

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateStudent frm = new frmAddUpdateStudent();
            frm.ShowDialog();
            _RefreshStudentsList();
        }

        private void refrashToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            _RefreshStudentsList();
        }

        private void DeleteStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure do you want to delete this student", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (clsStudent.Delete((int)dgvStudents.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Student Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshStudentsList();

                } else
                    MessageBox.Show("Student was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateStudent(Convert.ToInt32(dgvStudents.SelectedRows[0].Cells[0].Value));
            frm.ShowDialog();
            _RefreshStudentsList();
        }

        private void activeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure do you want to Activate this student", "Confirm Activate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int StudentID= (int)dgvStudents.CurrentRow.Cells[0].Value;

                if (clsStudent.IsStudentExist(StudentID))
                {
                    clsStudent student = clsStudent.Find(StudentID);

                    if (student.Status == clsStudent.enStudentStatus.Active)
                    {
                        MessageBox.Show("This Student is already Activated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (student != null)
                    {
                        student.Active();
                        MessageBox.Show("Student Activeted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshStudentsList();
                    } else { 
                        MessageBox.Show("Student Not Activeted ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                } else { 
                    MessageBox.Show("Student was NotFound ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void inactiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure do you want to activate this student", "Confirm activate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int StudentID = (int)dgvStudents.CurrentRow.Cells[0].Value;

                if (clsStudent.IsStudentExist(StudentID))
                {
                    clsStudent student = clsStudent.Find(StudentID);

                    if (student.Status == clsStudent.enStudentStatus.Inactive)
                    {
                        MessageBox.Show("This Student is already Inactive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (student != null)
                    {
                        student.Inactive();
                        MessageBox.Show("Student InActivate Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshStudentsList();
                    } else
                        MessageBox.Show("Student Not InActivates ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                } else
                    MessageBox.Show("Student was NotFound ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void graduatedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure do you want to Graduation this student", "Confirm Graduation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int StudentID = (int)dgvStudents.CurrentRow.Cells[0].Value;

                if (clsStudent.IsStudentExist(StudentID))
                {
                    clsStudent student = clsStudent.Find(StudentID);
                    if (student.Status == clsStudent.enStudentStatus.Graduated)
                    {
                        MessageBox.Show("This Student is already Graduated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (student != null)
                    {
                        student.Graduated();
                        MessageBox.Show("Student Graduated Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshStudentsList();
                    } else
                        MessageBox.Show("Student Not Graduated ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                } else
                    MessageBox.Show("Student was NotFound ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void droppedOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure do you want to Dropped Out this student", "Confirm Dropped Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int StudentID = (int)dgvStudents.CurrentRow.Cells[0].Value;

                if (clsStudent.IsStudentExist(StudentID))
                {
                    clsStudent student = clsStudent.Find(StudentID);

                    if (student.Status == clsStudent.enStudentStatus.DroppedOut)
                    {
                        MessageBox.Show("This Student is already Dropped Out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (student != null)
                    {
                        student.DroppedOut();
                        MessageBox.Show("Student Dropped Out Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshStudentsList();
                    } else
                        MessageBox.Show("Student Not Dropped Out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                } else
                    MessageBox.Show("Student was NotFound ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void expelledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure do you want to Expelled this student", "Confirm Expelled", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int StudentID = (int)dgvStudents.CurrentRow.Cells[0].Value;

                if (clsStudent.IsStudentExist(StudentID))
                {
                    clsStudent student = clsStudent.Find(StudentID);

                    if (student.Status == clsStudent.enStudentStatus.Expelled)
                    {
                        MessageBox.Show("This Student is already Expelled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (student != null)
                    {
                        student.Expelled();
                        MessageBox.Show("Student Expelled Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshStudentsList();
                    } else
                        MessageBox.Show("Student Not Expelled ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                } else
                    MessageBox.Show("Student was NotFound ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void suspendedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure do you want to Suspended this student", "Confirm Suspended", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int StudentID = (int)dgvStudents.CurrentRow.Cells[0].Value;

                if (clsStudent.IsStudentExist(StudentID))
                {
                    clsStudent student = clsStudent.Find(StudentID);
                    if (student.Status == clsStudent.enStudentStatus.Suspended)
                    {
                        MessageBox.Show("This Student is already Suspended", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (student != null)
                    {
                        student.Suspended();
                        MessageBox.Show("Student Suspended Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshStudentsList();
                    } else
                        MessageBox.Show("Student Not Suspended ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                } else
                    MessageBox.Show("Student was NotFound ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void showParentsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParentsDetails frm = new frmParentsDetails(Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["ParentsID"].Value));
            frm.ShowSelectButton = false;
            frm.ShowDialog();
        }

        private void btnEnrollmentNewStudent_Click(object sender, EventArgs e)
        {
            Form frm = new frmEnrollmentNewStudent();
            frm.ShowDialog();
        }
    }
}
