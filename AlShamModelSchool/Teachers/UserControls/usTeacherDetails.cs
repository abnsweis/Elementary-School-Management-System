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

namespace AlShamModelSchool.Teachers.UserControls
{
    public partial class usTeacherDetails : UserControl
    {

        private clsTeacher _teacher;
        private int _teacherID;
        public usTeacherDetails()
        {
            InitializeComponent();
        }

        public void LoadTeacherInfo(int TeacherID)
        {
            if (clsTeacher.isTeacherActive(TeacherID))
            {
                _teacherID = TeacherID;

                _teacher = clsTeacher.Find(TeacherID);
                if (_teacher != null)
                {
                    _LoadData();
                }

            } else
            {
                MessageBox.Show($"Error : Not Found Teacher With ID {TeacherID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void _LoadData()
        {
            if (_teacher != null)
            {
                ucPersonInfo1.LoadPerson(_teacher.PersonID);
                lbTeacherID.Text = _teacher.TeacherID.ToString();
                lbHireDate.Text = _teacher.HireDate.ToString("dd/MM/yyyy");
                lbSalary.Text = _teacher.Salary.ToString("C");
                lbSpecializations.Text = string.Join(" / ",_teacher.subjects.Select(t => t.SubjectName));
                lbYearsOfExperience.Text = _teacher.YearsOfExperience.ToString() + " Years";
                lbIsActive.Text = _teacher.IsActive ? "Yes" : "No";
                if (_teacher.TerminationDate != null)
                {
                    lbTerminationDate.Text = _teacher.TerminationDate.Value.ToString("dd/MM/yyyy");
                } else
                {
                    lbTerminationDate.Text = "N/A";
                }
                
            }
        }

        
    }
}
