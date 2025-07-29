using AlShamModelSchool.Properties;
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
    public partial class frmEnrollmentNewStudent : Form
    {

        int _StudentId = -1;
        int _StudentEnrollmentID = -1;

        clsClass _Class; 
        clsStudent _Student; 

        clsStudentEnrollment _StudentEnrollment;

        private enum enMode { Add ,Update}
        private enMode _Mode;
        public frmEnrollmentNewStudent()
        {
            InitializeComponent();
            _Mode = enMode.Add;
            _StudentEnrollment = new clsStudentEnrollment();
        }


        public frmEnrollmentNewStudent(int StudentEnrollmentID)
        {
            InitializeComponent();
            _StudentEnrollmentID = StudentEnrollmentID;
            _Mode = enMode.Update;
             
        }



        private void FillClasssInComboBox(int GradeLevelID)
        {
            cbClasss.Items.Clear();
            DataTable dt = clsClass.GetClassesByGradeLevelID(GradeLevelID);
            foreach (DataRow dtClass in dt.Rows)
            {

                cbClasss.Items.Add(dtClass["ClassName"].ToString());

            }
            cbClasss.SelectedIndex = 0;


        }
        private void FillGradeLevelsInComboBox()
        {

            DataTable dt = clsGradeLevel.GetAllGradeLevels();
            foreach (DataRow GradeLevel in dt.Rows)
            {

                cbGradeLevels.Items.Add(GradeLevel["GradeLevelName"].ToString());

            }
            cbGradeLevels.SelectedIndex = 0;


        }

        private void frmEnrollmentNewStudent_Load(object sender, EventArgs e)
        {
            FillGradeLevelsInComboBox();
            FillClasssInComboBox(cbGradeLevels.SelectedIndex + 1);


            if (_Mode == enMode.Add)
            {
                this.Text = "Enrollment New Student";
                _StudentEnrollment = new clsStudentEnrollment();
                return;
            }


            _LoadData();
        }

        private void _LoadData()
        {
            if (_Mode == enMode.Update)
            {
                if (!clsStudentEnrollment.IsStudentEnrollmentExist(_StudentEnrollmentID))
                {
                    MessageBox.Show($"Not Found Student Enrollment With ID {_StudentEnrollmentID}");
                    this.Close(); 
                    return;
                }

                _StudentEnrollment = clsStudentEnrollment.Find(_StudentEnrollmentID) ;
                if (_StudentEnrollment != null)
                {
                    ucStudentSelector1.LoadStudent(_StudentEnrollment.StudentID);
                    ucClassInfo1.LoadClassInfo(_StudentEnrollment.ClassID);
                    cbClasss.SelectedItem = _StudentEnrollment.Class.ClassName;
                    cbGradeLevels.SelectedItem = _StudentEnrollment.Class.GradeLevel.GradeLevelName;
                    tbNotes.Text = _StudentEnrollment.Notes;
                }
            }
        }

        private void ucStudentSelector1_OnStudentSelected(int obj)
        {
            _StudentId = obj;
            if (clsStudent.IsStudentExist(_StudentId))
            {
                btnNext.Enabled = true;
                _Student = clsStudent.Find(_StudentId);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_StudentId != -1)
            {
                tabs.SelectedIndex = 1;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbClasss_SelectedIndexChanged(object sender, EventArgs e)
        {

            ucClassInfo1.LoadClassInfo(cbClasss.Text);
            _Class = ucClassInfo1.SelectedClass; 
            


        }


        private bool isValidClassForSelectedStudent()
        { 
            if (_Class.GradeLevel.isValidAge(_Student.person.Age))
            {
                return true;
            }

            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isValidClassForSelectedStudent())
            {
                MessageBox.Show("This student's age is not appropriate for this academic level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!_Class.IsAvailableSeats())
            {
                MessageBox.Show("Not Available Seats In This Class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_Class.GetTotalStudents() == _Class.MaxStudents)
            {
                MessageBox.Show("There are no seats available in this class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _StudentEnrollment.StudentID = _StudentId;
            _StudentEnrollment.ClassID = _Class.ClassID; 
            _StudentEnrollment.EnrollmentDate = DateTime.Now;
            _StudentEnrollment.Notes = tbNotes.Text;


            if (_StudentEnrollment.Save())
            {
                MessageBox.Show("Student Enrollmented Successfully");
                this.Text = "Update Student Enrollmented";
                

                _Mode = enMode.Update;
                 
            } else
            {
                MessageBox.Show("Student Not  Enrollmented");
            }
             
        }

        private void cbGradeLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillClasssInComboBox(cbGradeLevels.SelectedIndex + 1);
        }
    }
}
