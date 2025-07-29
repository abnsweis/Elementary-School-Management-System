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
    public partial class frmUpdateTeacher : Form
    {

        private clsTeacher _Teacher;
        private int _TeacherID;

        private Dictionary<string, Guna2CheckBox> _subjectsCheckBoxes = new Dictionary<string, Guna2CheckBox>();
        public frmUpdateTeacher(int TeacherID)
        {
            InitializeComponent();
            _TeacherID = TeacherID;
           
        }




        private void CreateSubjectsCheckBoxs()
        {
            // Get the list of subjects from the database
            DataTable dtSubjects = clsSubject.GetAllSubjects();
            // Clear any existing checkboxes
            flpSubjects.Controls.Clear();
            // Create a checkbox for each subject
            foreach (DataRow row in dtSubjects.Rows)
            {
                // Create a new checkbox
                Guna2CheckBox chkSubject = new Guna2CheckBox();
                chkSubject.Text = row["SubjectName"].ToString();
                chkSubject.Name = row["SubjectName"].ToString();
                chkSubject.Tag = row["SubjectID"].ToString() ;
                chkSubject.TabIndex = cbYearsOfExperience.TabIndex++;
                chkSubject.CheckedChanged += chkSubject_CheckedChanged;

                _subjectsCheckBoxes[row["SubjectName"].ToString()] = chkSubject;
                flpSubjects.Controls.Add(chkSubject);
            }

        }

        private void SetActiveCheckboxes()
        {

            if (_Teacher != null)
            {

                foreach (var sub in _Teacher.subjects)
                {
                    if (flpSubjects.Controls.ContainsKey(sub.SubjectName))
                    {
                        _subjectsCheckBoxes[sub.SubjectName].Checked = true;

                    }
                }

            }

        }
        

        private void frmUpdateTeacher_Load(object sender, EventArgs e)
        {
            if (clsTeacher.IsTeacherExist(_TeacherID))
            {
                _Teacher = clsTeacher.Find(_TeacherID);
                if (_Teacher != null)
                {
                    _LoadData();
                }
            } else
            {
                MessageBox.Show($"Not Found teacher With ID {_TeacherID}");
                this.Close();
            }
        }

        private void _LoadData()
        {
            if (_Teacher == null)
            {
                MessageBox.Show("Not Found Teacher");
                this.Close();
            }
            if (!_Teacher.IsActive)
            {
                MessageBox.Show($"The teacher '{_Teacher.person.FullName}' is not active. Please activate the teacher and try again.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  this.Close();
            }

            this.Text = $"Update Teacher: {_Teacher.person.FullName}";
            ucPersonInfo1.LoadPerson(_Teacher.PersonID);
            tbTeacherSalary.Text = _Teacher.Salary.ToString();
            cbYearsOfExperience.SelectedItem = _Teacher.YearsOfExperience.ToString();
            btnSave.TabIndex = _subjectsCheckBoxes.Count + 1;
            btnClose.TabIndex = _subjectsCheckBoxes.Count + 1;

            CreateSubjectsCheckBoxs();
            SetActiveCheckboxes();


        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void chkSubject_CheckedChanged(object Sender, EventArgs e)
        {


            if (Sender is Guna2CheckBox)
            {
                Guna2CheckBox checkBox = (Guna2CheckBox)Sender;

                if (int.TryParse(checkBox.Tag.ToString(), out int SujectID))
                {
                    if (clsSubject.IsSubjectExists(SujectID))
                    {
                        if (checkBox.Checked)
                        {
                            _Teacher.AssignSubjectToTeacher(SujectID);
                        } else
                        {
                            _Teacher.RemoveSubjectFromTeacher(SujectID);
                        }
                    } else
                    {
                        checkBox.Enabled = false; // Uncheck the checkbox if the subject does not exist
                        MessageBox.Show($"Error: Subject with ID {SujectID} does not exist.", "Invalid Subject ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                } else
                {
                    checkBox.Enabled = false; // Uncheck the checkbox if the subject does not exist
                    MessageBox.Show("Error: Unable to parse the Subject ID. Please ensure the data is valid and try again.", "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void ValidedateSalaryField()
        {
            if (string.IsNullOrEmpty(tbTeacherSalary.Text))
            {
                clsVerifications.SetErrorToField(tbTeacherSalary, lbError, "Salary is required");
                return;
            } else
            {
                clsVerifications.ClearError(tbTeacherSalary, lbError);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            ValidedateSalaryField();

            if (Save())
            {
                MessageBox.Show("Teacher Update successfully.");
                this.Close();
                
            } else
            {
                MessageBox.Show("Failed to Update teacher.");

            }
        }


        private bool Save()
        {
            _Teacher.Salary = decimal.Parse(tbTeacherSalary.Text);
            _Teacher.YearsOfExperience = int.Parse(cbYearsOfExperience.SelectedItem.ToString());
            
            
            return _Teacher.Save();
        }

        private void tbTeacherSalary_TextChanged(object sender, EventArgs e)
        {
            ValidedateSalaryField();


        }
    }
}
