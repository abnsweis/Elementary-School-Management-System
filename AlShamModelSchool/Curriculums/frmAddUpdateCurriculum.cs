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

namespace AlShamModelSchool.Curriculums
{
    public partial class frmAddUpdateCurriculum : Form
    {
        public enum enMode { Add = 0, Update = 1 }

        public enMode _Mode;

        private clsCurriculum _Curriculum;
        private int _CurriculumID;

        public frmAddUpdateCurriculum()
        {
            InitializeComponent();
            _Mode = enMode.Add;
        }

        public frmAddUpdateCurriculum(int CurriculumID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _CurriculumID = CurriculumID;
        }
        private void frmAddUpdateCurriculum_Load(object sender, EventArgs e)
        {
            _FillcbEducationLevelsCombobox();

            if (_Mode == enMode.Add)
            {
                _Curriculum = new clsCurriculum();
                this.Text = "Add New Curriculum";
                _CurriculumID = -1;
                return;
            }


            _LoadDate();
        }

        private void _FillcbEducationLevelsCombobox()
        {
            DataTable dataTable = clsEducationLevel.GetAllEducationLevels();

            foreach (DataRow row in dataTable.Rows)
            {
                cbEducationLevels.Items.Add(row["EducationLevelName"].ToString());
            }

            cbEducationLevels.SelectedIndex = 0;
        }

        private void _LoadDate()
        {
            if (_Mode == enMode.Update)
            {
                if (!clsCurriculum.IsCurriculumExist(_CurriculumID))
                {
                    MessageBox.Show($"NotFound Curriculum With ID {_CurriculumID}");
                    this.Close();
                }


                _Curriculum = clsCurriculum.Find(_CurriculumID);

                if (_Curriculum != null)
                {
                    this.Text = $"Update Curriculum {_Curriculum.CurriculumName}";
                    lbCurriculumID.Text = _Curriculum.CurriculumID.ToString();
                    tbCurriculumName.Text = _Curriculum.CurriculumName;
                    tbDescription.Text = _Curriculum.Description;
                    cbEducationLevels.SelectedItem = _Curriculum.EducationLevel.EducationLevelName ;
                }

            }
        }




        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool _VerifyFields()
        {

            if (!clsVerifications.ValidateFieldWithLabel(tbCurriculumName, lbCurriculumNameRequired)) return false;
            if (!clsVerifications.ValidateFieldWithLabel(tbDescription, lbDescriptionRequired)) return false;

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_VerifyFields())
            {

                _Curriculum.CurriculumName = tbCurriculumName.Text;
                _Curriculum.Description = tbDescription.Text;
                _Curriculum.EducationLevelID = clsEducationLevel.Find(cbEducationLevels.SelectedItem.ToString()).EducationLevelID;
                _Curriculum.PublicationDate = DateTime.Now;
                if (_Curriculum.Save())
                {
                    _Mode = enMode.Update;
                    lbCurriculumID.Text = _Curriculum.CurriculumID.ToString();
                    MessageBox.Show($"Curriculum {_Mode}ed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                } else
                {
                    MessageBox.Show($"Error {_Mode}ed Curriculum", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

            }
        }
    }
}
