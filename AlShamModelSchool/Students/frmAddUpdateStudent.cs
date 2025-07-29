using AlShamModelSchool.Parents;
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
    public partial class frmAddUpdateStudent : Form
    {
        private enum enMode { Add, Update }

        enMode _Mode = enMode.Add;
        clsStudent _Student;
        int _StudentID = -1;
        clsParents _Parents;
        int _ParentsID = -1;

        clsPerson _Person;
        int _PersonID = -1;

        bool isParentSelected ; // is Parents selected from frmParentsList
        bool isPersonSelected ; // is Person selected from ucPersonSelector
        public frmAddUpdateStudent()
        {
            InitializeComponent();
            _Mode = enMode.Add;
        }

        public frmAddUpdateStudent(int StudentID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _StudentID = StudentID;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isParentSelected || _Parents == null)
            {
                MessageBox.Show("Please select Parents first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!isPersonSelected)
            {
                MessageBox.Show("Please select Student first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsStudent.IsPersonAlreadyStudent(_PersonID) && _Mode == enMode.Add)
            {

                MessageBox.Show("This person is already a student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_PersonID == _Parents.FatherID || _PersonID == _Parents.MotherID )
            {
                MessageBox.Show(@"The same person cannot be designated as both a student and a parent at the same time.Please check the data entered and select correct IDs for both the student and their parent.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                
            }
             
            _Student.PersonID = _PersonID;
            _Student.ParentsID = _ParentsID;
            _Student.Status = clsStudent.enStudentStatus.Active;
            _Student.AdmissionDate = DateTime.Now.Date;
            _Student.Notes = tbStudentsNotes.Text;
            //_Student.CreatedByUserID = clsCurrentUser.UserID;
            _Student.CreatedByUserID = 1; // for testing
            _Student.CreatedByUserInfo = clsUser.Find(_Student.CreatedByUserID);

            if (_Student.Save())
            {
                MessageBox.Show("Student Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                btnSave.Enabled = false; 
                ucPersonSelector1.FilterEnabled = false;
            } else
            {
                MessageBox.Show("Failed to Save Student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataBackEvent(int ParentsID)
        {
            if (clsParents.IsParentsExist(ParentsID))
            {
                _ParentsID = ParentsID;
                _Parents = clsParents.Find(ParentsID);

                if (_Parents != null)
                {
                    isParentSelected = true;
                    lbParentsID.Text = _Parents.ParentsID.ToString();
                    lbFatherName.Text = _Parents.Father.FullName;
                    lbMotherName.Text = _Parents.Mother.FullName;

                    lbFatherNationalID.Text = _Parents.Father.NationalID;
                    lbMotherNationalID.Text = _Parents.Mother.NationalID;

                }
            }

             

        }
        private void btnSelectParents_Click(object sender, EventArgs e)
        {
            frmParentsList frm = new frmParentsList(frmParentsList.enMode.Select);

            frm.DataBack += DataBackEvent;

            frm.ShowDialog();

        }

        private void frmAddUpdateStudent_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void _LoadData()
        {
            if (_Mode == enMode.Add)
            {
                lbAdmissionDate.Text = DateTime.Now.ToShortDateString();
                _Student = new clsStudent();
                this.Text = "Add New Student";
                return;
            }



            _Student = clsStudent.Find(_StudentID);
            if (_Student != null)
            {
                _PersonID = _Student.PersonID;
                _ParentsID = _Student.ParentsID;
                _Person = clsPerson.Find(_PersonID);
                _Parents = clsParents.Find(_ParentsID);
                if (_Person != null)
                {
                    isPersonSelected = true;
                    ucPersonSelector1.LoadPerson(_PersonID);
                }
                if (_Parents != null)
                {
                    isParentSelected = true;
                    lbParentsID.Text = _Parents.ParentsID.ToString();
                    lbFatherName.Text = _Parents.Father.FullName;
                    lbMotherName.Text = _Parents.Mother.FullName;
                    lbFatherNationalID.Text = _Parents.Father.NationalID;
                    lbMotherNationalID.Text = _Parents.Mother.NationalID;
                }
                lbAdmissionDate.Text = _Student.AdmissionDate.ToShortDateString();
                tbStudentsNotes.Text = _Student.Notes;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucPersonSelector1_OnPersonSelected(int obj)
        {
            _PersonID = obj;
            
            _Person = ucPersonSelector1.SelectedPersonInfo;
            if (_Person != null)
            {
                isPersonSelected = true;
            }
        }

        private void ucPersonSelector1_Load(object sender, EventArgs e)
        {

        }

        private void ucPersonSelector1_OnPersonCleared()
        {
            ucPersonSelector1.ucPersonInfo1.Clear();
        }
    }
}
