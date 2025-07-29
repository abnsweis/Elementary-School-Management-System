using AlShamModelSchool.Properties;
using AlShamModelSchool.Teachers;
using AlShamModelSchool.Teachers.UserControls;
using AlShamModelSchool.UserControls;
using BusinessLogicLayer;
using Guna.UI2.WinForms;
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

namespace AlShamModelSchool.Classes
{
    public partial class frmAddUpdateClass : Form
    {

        private enum enMode { Add, Update }

        enMode _Mode = enMode.Add;
        int _ClassID = -1;
        clsClass _Class;

        int _GradeLevelID = -1;

        public frmAddUpdateClass()
        {
            InitializeComponent();
        }

        public frmAddUpdateClass(int ClassID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _ClassID = ClassID;
        }
      
        private void frmAddUpdateClass_Load(object sender, EventArgs e)
        {
            _FillcbGradeLevelsCombobox(); 
            if (_Mode == enMode.Update)
            {

                _LoadDate();
                return;

            }

            _Class = new clsClass();
            this.Text = "Add New Class";
            rbAfternoon.Checked = true;
            ucClassInfo1.lbShiftType.Text = rbMorning.Checked ? "Morning" : "Afternoon";
        }


        private bool _IsSelectedALLTeachersForClass()
        {
            foreach (var control in flpTeachersSelectorPanel.Controls)
            {
                if (control is ucClassSubjectTeacherSelector CSTSelector)
                {
                    if (!CSTSelector.IsSelectedTeacher)
                    {
                        MessageBox.Show($"Places Selected Teacher For {CSTSelector.Tag} Subject");
                        return false;
                    }
                }
                 
            }
            return true;
        }

        private void _LoadDate()
        {
            if (_Mode == enMode.Update)
            {
                _Class = clsClass.Find(_ClassID);
                if (_Class != null)
                {
                    tbClassName.Text = _Class.ClassName;
                    tbMaxStudentsNumber.Text = _Class.MaxStudents.ToString();
                    tbRoomNumber.Text = _Class.RoomNumber;
                    cbGradeLevel.SelectedValue = _Class.GradeLevel.CurriculumID;
                    if (_Class.ShiftType == clsClass.enShiftType.Morning)
                    {
                        rbMorning.Checked = true;
                    } else
                    {
                        rbAfternoon.Checked = true;
                    }

                    ucClassInfo1.LoadClassInfo(_ClassID);

                    _CreateSubjectSelectControls();
                }
            }

        }
        private bool VerifyFields()
        {

            if (!clsVerifications.ValidateFieldWithLabel(tbClassName, lbClassNameRequired)) return false; 
            if (!clsVerifications.ValidateFieldWithLabel(tbMaxStudentsNumber, lbMaxStudentsRequierd)) return false;
            if (!clsVerifications.ValidateFieldWithLabel(tbRoomNumber, lbRoomNumberRequired)) return false;
            if(!_VerifyThatTheFirstStepIsValid()) return false;
            tabs.SelectedIndex = 1;
            btnNext.Enabled = false;
            if (!_IsSelectedALLTeachersForClass()) return false;
            return true;
        }
        private void _FillcbGradeLevelsCombobox()
        {
            DataTable dataTable = clsGradeLevel.GetAllGradeLevels();
 

            cbGradeLevel.DisplayMember = "GradeLevelName";
            cbGradeLevel.ValueMember = "GradeLevelID";
            cbGradeLevel.DataSource = dataTable;

            cbGradeLevel.SelectedIndex = dataTable.Rows.Count > 0 ? 0 : -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (VerifyFields())
            {

                _Class.GradeLevelID = cbGradeLevel.SelectedIndex + 1;
                _Class.ClassName = tbClassName.Text.Trim();
                if (string.IsNullOrEmpty(tbMaxStudentsNumber.Text))
                {
                    _Class.MaxStudents = 30;
                } else { 
                    
                    _Class.MaxStudents = Convert.ToInt32(tbMaxStudentsNumber.Text);
                }
                _Class.RoomNumber = tbRoomNumber.Text;
                _Class.ShiftType = rbAfternoon.Checked ? clsClass.enShiftType.Afternoon : clsClass.enShiftType.Morning;


                if (_Class.Save())
                {

                    if (SaveSelectedTeachers(_Class.ClassID))
                    {
                        MessageBox.Show("Class Saved Successfully");
                        this.Text = $"{_Mode.ToString()} Class";

                        lbFormTitle.Text = $"{_Mode.ToString()}  Class";
                        _Mode = enMode.Update;
                        this.Close();
                    }
                    
                    
                } else
                {
                    MessageBox.Show("Error Saving Class");
                }

            }
        }


        private bool SaveSelectedTeachers(int ClassID)
        {
            foreach (var control in flpTeachersSelectorPanel.Controls)
            {
                if (control is ucClassSubjectTeacherSelector CSTSelector)
                {
                    if (CSTSelector.IsSelectedTeacher)
                    {
                        clsClassTeacherSubject clsClassTeacherSubject = new clsClassTeacherSubject(ClassID, CSTSelector.TeacherID, CSTSelector.SubjectID);
                        if (!clsClassTeacherSubject.Save())
                        {
                            return false;
                        }
                    }
                }
            }
            
            return true;
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is Guna2TextBox textBox)
            {
                if (char.IsControl(e.KeyChar))
                    return;


                string newText = textBox.Text + e.KeyChar;


                if (int.TryParse(newText, out int result))
                {

                    if (result > 45)
                        e.Handled = true;
                } else
                {

                    e.Handled = true;
                }
            }

            
        }

     
        private bool _VerifyThatTheFirstStepIsValid()
        {
            btnNext.Enabled = false;
            if (string.IsNullOrEmpty(tbClassName.Text)) return false;
            if (string.IsNullOrEmpty(tbMaxStudentsNumber.Text)) return false;
            if (string.IsNullOrEmpty(tbRoomNumber.Text)) return false;
             
            btnNext.Enabled = true;
            return true ;
        }
        

        private void _CreateSubjectSelectControls()
        { 
            flpTeachersSelectorPanel.Controls.Clear(); // Clear existing teacher info panels  
            int GradeLevelID = int.TryParse(cbGradeLevel.SelectedValue.ToString(), out int id) ? id : -1;

            // Get the list of subjects from the database  
            List<clsSubject> Subjects = clsGradeLevel.GetGradeLevelsSubject(GradeLevelID);

            

            // Create a button and corresponding teacher info panel for each subject  
            foreach (var sub in Subjects)
            {
                // Create a new button for the subject  
                ucClassSubjectTeacherSelector CTSSelector = new ucClassSubjectTeacherSelector();

                CTSSelector.LoadInfoSubject(sub.SubjectID);
                CTSSelector.Tag = sub.SubjectName; // Set the tag to the subject name


                if (_Mode == enMode.Update)
                {
                    SetValueToCTSSelector(CTSSelector);
                }


                // Add the teacher info panel and button to their respective containers  
                flpTeachersSelectorPanel.Controls.Add(CTSSelector); 
            }
        }

        private void SetValueToCTSSelector(ucClassSubjectTeacherSelector CTSSelector)
        {
            if (_Mode == enMode.Update && _Class != null)
            {
                int subjectID = CTSSelector.SubjectID;
                int teacherID = clsClassTeacherSubject.GetTeacherIdBySectionAndSubject(_Class.ClassID, subjectID);
                if(subjectID > 0 && teacherID > 0 && _ClassID > 0)
                {
                    
                    CTSSelector.LoadInfo(teacherID, subjectID);
                } else
                {
                    CTSSelector.Clear();

                }
            }
        }


        private void cbGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            _CreateSubjectSelectControls();
            _GradeLevelID = int.TryParse(cbGradeLevel.SelectedValue.ToString(), out int id) ? id : -1;

            clsGradeLevel gradeLevel = clsGradeLevel.Find(_GradeLevelID);
            ucClassInfo1.lbGradeLevelName.Text = cbGradeLevel.Text;
            ucClassInfo1.lbMinimumAge.Text = gradeLevel.MinAge.ToString();
            ucClassInfo1.lbMaxnimumAge.Text = gradeLevel.MaxAge.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabs.SelectedIndex = 1;
            btnNext.Enabled = false;
        }

        private void tbClassName_TextChanged(object sender, EventArgs e)
        {
            ucClassInfo1.lbClassName.Text = tbClassName.Text;
            _VerifyThatTheFirstStepIsValid();
        }

        private void tbMaxStudentsNumber_TextChanged(object sender, EventArgs e)
        {
            ucClassInfo1.lbMaxStudents.Text = tbMaxStudentsNumber.Text;
            _VerifyThatTheFirstStepIsValid();
        }

        private void tbRoomNumber_TextChanged(object sender, EventArgs e)
        {
            ucClassInfo1.lbRommNumber.Text = tbRoomNumber.Text;
            _VerifyThatTheFirstStepIsValid();
        }

        private void rbMorning_CheckedChanged(object sender, EventArgs e)
        {
            ucClassInfo1.lbShiftType.Text = rbMorning.Checked ? "Morning" : "Afternoon";
        }
    }
}
