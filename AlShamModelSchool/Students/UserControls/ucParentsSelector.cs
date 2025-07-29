using AlShamModelSchool.People;
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

namespace AlShamModelSchool.Students.UserControls
{
    public partial class ucParentsSelector : UserControl
    {
        public enum enParentType{Father,Mother}

        private clsPerson _Person;
        private int _PersonID;
        private string _NationalID;

        public clsPerson Person
        {
            get { return _Person; }
        }

        public int PersonID
        {
            get { return _PersonID; }
        }
        private enParentType _ParentType { get; set; }


        public enParentType ParentType
        {
            get { return _ParentType; }
            set
            {
                _ParentType = value;
                if (_ParentType == enParentType.Father)
                {
                    lblParentType.Text = "Father";
                    pbParentType.ImageLocation = clsGloble.MalePersonDefaultImage;
                } else
                {
                    lblParentType.Text = "Mother";
                    pbParentType.ImageLocation = clsGloble.FemalePersonDefaultImage;
                }
            }
        }
        public ucParentsSelector()
        {
            InitializeComponent();
        }


        private void _LoadDate()
        {

            if (_Person != null)
            {
                // Set Person Info
                lbPersonID.Text = _PersonID.ToString();
                lbFullName.Text = _Person.FullName;
                lbDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
                 
                lbAddress.Text = _Person.Address;
                lbNationalID.Text = _Person.NationalID;

                // Enameble Update Link
                lbUpdatePerson.Enabled = true;

 
            }
        }

        public void ResetPersonInfo()
        {

            _Person = null;
            _PersonID = -1;
            lbPersonID.Text = "";
            lbFullName.Text = "";
            lbDateOfBirth.Text = "";
            lbAddress.Text = "";
            lbNationalID.Text = "";
            _ParentType = enParentType.Father;
        }

        private void ShowErrorPersonNotFound()
        {
            ResetPersonInfo();
            MessageBox.Show("Person not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void LoadPerson(int PersonID)
        {

            ResetPersonInfo();
            _PersonID = PersonID;
            if (!clsPerson.IsPersonExist(PersonID))
            {
                ShowErrorPersonNotFound();
                return;
            }
            _Person = clsPerson.Find(PersonID);
            _LoadDate();
        }
        public void LoadPerson(string NationalID)
        {
            ResetPersonInfo();
            _NationalID = NationalID;
            if (!clsPerson.IsPersonExistByNationalID(_NationalID))
            {
                ShowErrorPersonNotFound();
                return;
            }
            _Person = clsPerson.FindByNationalID(NationalID);
            _LoadDate();
        }


        private void lbUpdatePerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_PersonID != -1)
            {
                Form frm = new frmAddUpdatePerson(_PersonID);
                frm.ShowDialog();
                LoadPerson(_PersonID);
            }

        }
        public void Clear()
        {
            ResetPersonInfo();
        }

        private void ucParentsSelector_Load(object sender, EventArgs e)
        {
            ResetPersonInfo();
        }
    }
}
