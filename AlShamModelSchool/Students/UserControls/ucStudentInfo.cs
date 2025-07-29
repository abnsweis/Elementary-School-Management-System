using AlShamModelSchool.People;
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

namespace AlShamModelSchool.Students.UserControls
{
    public partial class ucStudentInfo : UserControl
    {

        private clsStudent _Student;
        private int _StudentID;
        private int _PersonID;
        private string _StudentNumber;
        public ucStudentInfo()
        {
            InitializeComponent();
        }


        public int StudentID
        {
            get
            {

                return _StudentID;
            }
        }
        public clsStudent SelectedStudent
        {
            get
            {

                return _Student;
            }
        }
        private void _LoadDate()
        {

            if (_Student != null)
            {
                _PersonID = _Student.PersonID;
                _StudentID = _Student.StudentID;
                _StudentNumber = _Student.StudentNumber;
                ucPersonInfo1.LoadPerson(_Student.PersonID);
                lbFatherName.Text = _Student.parents.Father.FullName;
                lbMotherName.Text = _Student.parents.Mother.FullName;
                lbStudentNumber.Text = _Student.StudentNumber.ToString();


            }
        }
        public void LoadStudent(int StudentID)
        {

            ResetStudentInfo();
            _StudentID = StudentID;
            if (!clsStudent.IsStudentExist(StudentID))
            {
                ResetStudentInfo();
                return;
            }
            _Student = clsStudent.Find(StudentID);
            _LoadDate();
        }

        public void LoadStudent(string StudentNumber)
        {

            ResetStudentInfo();
            _StudentNumber = StudentNumber;
            if (!clsStudent.IsStudentExist(StudentNumber))
            {
                ResetStudentInfo();
                return;
            }
            _Student = clsStudent.Find(StudentNumber);
            _LoadDate();
        }
        public void ResetStudentInfo()
        {
            ucPersonInfo1.Clear();
            _Student = null;
            _StudentID = -1;
            _PersonID = -1;
            _StudentNumber = string.Empty;

            ucPersonInfo1.Clear();
            lbFatherName.Text = string.Empty;
            lbFatherName.Text = string.Empty;
            lbStudentNumber.Text = string.Empty;
        }
        public void Clear()
        {
            ResetStudentInfo();
        }

    }
}
