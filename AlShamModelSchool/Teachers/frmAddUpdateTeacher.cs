using BusinessLogicLayer;
using Guna.UI2.WinForms;
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
    public partial class frmAddUpdateTeacher : Form
    {
        public enum enMode { AddNew, Update ,InsertSubjectToTeacher}

        private enMode _Mode;
        private int _PersonID = -1;
        private int _TeacherID;

        private bool _IsThePersonTeacher = false;
        private clsTeacher _Teacher;
        private clsSubject _Subject;
        public frmAddUpdateTeacher()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdateTeacher(int teacherID)
        {
            InitializeComponent();
            _TeacherID = teacherID;
            _Mode = enMode.Update;
        }
        private void tbTeacherSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            string newText = tbTeacherSalary.Text + e.KeyChar;

            if (int.TryParse(newText, out int result))
            {
                if (result > 50000)
                {
                    clsVerifications.SetErrorToField(tbTeacherSalary, lbError, "It is not allowed to enter a value greater than 50,000");
                    e.Handled = true;
                } else
                {
                    clsVerifications.ClearError(tbTeacherSalary, lbError);
                    e.Handled = false;
                }
            } else
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         
        public static void FillcbSubjectsinCombobox(Guna2ComboBox comboBox)
        {
            DataTable dataTable = clsSubject.GetAllSubjects();

            foreach (DataRow row in dataTable.Rows)
            {
                comboBox.Items.Add(row["SubjectName"].ToString());
            }

            comboBox.SelectedIndex = 0;
        }

        private void frmAddUpdateTeacher_Load(object sender, EventArgs e)
        {
            FillcbSubjectsinCombobox(cbSubjects);
            if (_Mode == enMode.AddNew)
            {
                
                _Teacher = new clsTeacher();
                return;
            }

            _LoadData();

        }

        private void _LoadData()
        {

            if (!_IsThePersonTeacher)
            {
                _Teacher = clsTeacher.Find(_TeacherID);

            }


            if (_Teacher == null)
            {
                MessageBox.Show("Not Found Teacher");
                this.Close();
            }


            ucPersonSelector1.LoadPerson(_Teacher.PersonID);

            tbTeacherSalary.Text = _Teacher.Salary.ToString();
            cbSubjects.SelectedItem = _Teacher.Specialization;
            cbYearsOfExperience.SelectedItem = _Teacher.YearsOfExperience.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_PersonID == -1)
            {
                MessageBox.Show("Please select a person first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            if (clsTeacher.IsTeacherAlreadyStudyingSubject(_TeacherID,_Subject.SubjectID))
            {
                MessageBox.Show("This teacher is already teaching this subject. He cannot be registered again.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }


            if (string.IsNullOrEmpty(tbTeacherSalary.Text))
            {
                clsVerifications.SetErrorToField(tbTeacherSalary, lbError, "Salary is required");
                return;
            } else
            {
                clsVerifications.ClearError(tbTeacherSalary, lbError);
            }

            switch (_Mode)
            {
                case enMode.AddNew:
                case enMode.Update:
                    Save();
                    break;

                case enMode.InsertSubjectToTeacher:
                    if (InsertSubjectToTeacher())
                    { 
                        MessageBox.Show("Subject successfully assigned to the teacher.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        MessageBox.Show("Failed to assign subject to the teacher.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

            }
        }


        private bool InsertSubjectToTeacher()
        {
           clsTeacherSubjects teacherSubjects = new clsTeacherSubjects(_Teacher.TeacherID,_Subject.SubjectID);
             
            if (teacherSubjects.Save())
            {
                MessageBox.Show("Subject added to teacher successfully.");
                return true;
            } else
            {
                MessageBox.Show("Failed to add subject to teacher.");
            }

            return false;
        }
        private bool Save()
        {
            _Teacher.PersonID = _PersonID; // This should be set to the actual PersonID
            _Teacher.HireDate = DateTime.Now;
            _Teacher.Salary = decimal.Parse(tbTeacherSalary.Text);
            _Teacher.Specialization = cbSubjects.SelectedItem.ToString();
            _Teacher.YearsOfExperience = int.Parse(cbYearsOfExperience.SelectedItem.ToString());
            _Teacher.TerminationDate = null; // Assuming this is not set at the time of creation
            _Teacher.IsActive = true;
            if (_Teacher.Save())
            {
                if (!clsTeacher.IsTeacherAlreadyStudyingSubject(_TeacherID,_Subject.SubjectID))
                {
                    InsertSubjectToTeacher();
                }
                MessageBox.Show("Teacher added successfully.");
                return true;
            } else
            {
                MessageBox.Show("Failed to add teacher.");
                return false;
            }
            return false;
        }

        private void ucPersonSelector1_OnPersonSelected(int obj)
        {
            _PersonID = obj;


            if (!clsPerson.IsPersonExist(_PersonID)) MessageBox.Show("Person does not exist.");

            if (_Mode == enMode.Update) return;

            if (clsTeacher.IsThePersonTeacher(_PersonID))
            {
                _IsThePersonTeacher = true;
                _Teacher = clsTeacher.GetTeacherByPersonID(_PersonID);
                _TeacherID = _Teacher.TeacherID;
                _LoadData();
                ucPersonSelector1.FilterEnabled = true;
                _Mode = enMode.InsertSubjectToTeacher;
                 
            } else
            {
                ReasetForm();
            }
        }

        private void ReasetForm()
        {
            if (!clsPerson.IsPersonExist(_PersonID))
            {
                _PersonID = -1;
                ucPersonSelector1.ucPersonInfo1.Clear();
            }
            tbTeacherSalary.Text = string.Empty;
            cbSubjects.SelectedIndex = 0;
            cbYearsOfExperience.SelectedIndex = 9;

            _TeacherID = -1;
            _IsThePersonTeacher = false;
           
        }
        


       

        private void cbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clsSubject.IsSubjectExists(cbSubjects.SelectedItem.ToString()))
            {
                _Subject = clsSubject.Find(cbSubjects.SelectedItem.ToString());
                 

            } else
            {
                _Subject = null;
                MessageBox.Show($"Not Found Subject With Name {cbSubjects.SelectedItem}");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ucPersonSelector1.FilterEnabled = true;
            ReasetForm();
            ucPersonSelector1.ucPersonInfo1.Clear();
        }

        private void tbTeacherSalary_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
