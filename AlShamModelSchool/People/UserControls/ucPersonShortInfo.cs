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

namespace AlShamModelSchool.People.UserControls
{
    public partial class ucPersonShortInfo : UserControl
    {

        private clsPerson _Person;
        private int _PersonID;
        private string _NationalID;
        private bool _EnabledUpdateButton = false;

        public bool EnabledUpdateButton
        {
            get { return _EnabledUpdateButton; }
            set { 
                
                _EnabledUpdateButton = value;
                btnUpdatePerson.Enabled = value;
            }
        }


        public clsPerson SelectedPerson
        {
            get => _Person;

        }
        public int PersonID
        {
            get
            {

                return _PersonID;
            }
            set {
                _PersonID = value;
                LoadPerson(value);
            }
        }
        public ucPersonShortInfo()
        {
            InitializeComponent();
        }

        private void ucPersonShortInfo_Load(object sender, EventArgs e)
        {
            ResetPersonInfo();

        }



        private void _LoadDate()
        {

            if (_Person != null)
            {
                _PersonID = _Person.PersonID;
                // Set Person Info
                lbPersonID.Text = _PersonID.ToString();
                lbFullName.Text = _Person.FullName; 
                lbGender.Text = _Person.Gender ? "Male" : "Female"; 
                lbNationalID.Text = _Person.NationalID; 
                lbAge.Text = (DateTime.Now.Year - _Person.DateOfBirth.Year).ToString();
                 
                _LoadPersonImageAndGenderImage(); 

            }
        }

        public void ResetPersonInfo()
        {

            _Person = null;
            _PersonID = -1;
            lbPersonID.Text = "";
            lbFullName.Text = ""; 
            lbGender.Text = ""; 
            lbNationalID.Text = ""; 
            lbAge.Text = ""; 
            pbPersonImage.ImageLocation = "";
            pbPersonImage.Image = null;
        }



        public void LoadPerson(int PersonID)
        {

            ResetPersonInfo();
            _PersonID = PersonID;
            if (!clsPerson.IsPersonExist(PersonID))
            {
                ResetPersonInfo();
                return;
            }
            _Person = clsPerson.Find(PersonID);
            _LoadDate();
        }
        public void LoadPerson(string NationalID)
        {
            _NationalID = NationalID;
            if (!clsPerson.IsPersonExistByNationalID(_NationalID))
            {
                ResetPersonInfo();
                return;
            }
            _Person = clsPerson.FindByNationalID(NationalID);

            _LoadDate();
        }

        public void Clear()
        {
            ResetPersonInfo();
        }

        private void _LoadPersonImageAndGenderImage()
        {
            // Set Main Image
            pbUserControlImage.ImageLocation = _Person.Gender ? clsGloble.MalePersonDefaultImage : clsGloble.FemalePersonDefaultImage;
            // Set Person Image
            pbPersonImage.ImageLocation = _Person.ImagePath;


        }

        private void btnUpdatePerson_Click(object sender, EventArgs e)
        {
            if (clsPerson.IsPersonExist(_PersonID))
            {
                frmAddUpdatePerson frm = new frmAddUpdatePerson(_PersonID);
                frm.ShowDialog();
                LoadPerson(_PersonID);
            }
        }
    }
}
