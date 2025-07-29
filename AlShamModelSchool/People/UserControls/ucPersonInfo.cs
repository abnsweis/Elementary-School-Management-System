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

namespace AlShamModelSchool.People.UserControls
{
    public partial class ucPersonInfo : UserControl
    {
        
        public event Action<int> OnPersonUpdated;

        public virtual void PersonUpdated(int PersonID)
        {
            OnPersonUpdated?.Invoke( PersonID);
        }


        private clsPerson _Person;
        private int _PersonID;
        private clsUser User;
        private int _UserID;
        private string _NationalID;

        private bool _ShowUserIDFiled = false;

        private string _Title = "Person Details";
         
        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                _Title = value;
                ucTitle.Text = _Title;
            }
        }
        public bool ShowUserIDFiled
        {
            get
            {
                return _ShowUserIDFiled;
            }
            set
            {
                _ShowUserIDFiled =value;
                if (_ShowUserIDFiled)
                {
                    this.Height = 322;
                }
                else
                {
                    this.Height = 290;
                }
                
                lbUserIDTitle.Visible = _ShowUserIDFiled;
                lbUserID.Visible = _ShowUserIDFiled;
            }
        }

        public int UserID { 
            get {

                return _UserID;
            }  
        }        
        public clsUser SelectedPersonUserInfo { 
            get {

                return User;
            }  
        }
        public int PersonID
        {
            get
            {

                return _PersonID;
            }
        }
        public clsPerson SelectedPerson
        {
            get => _Person;
             
        }
        public ucPersonInfo()
        {
            InitializeComponent();
        }


        private void _LoadDate()
        {
            
            if (_Person != null)
            {
                _PersonID = _Person.PersonID;
                // Set Person Info
                lbPersonID.Text = _PersonID.ToString();
                lbFullName.Text = _Person.FullName;
                lbDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
                lbGender.Text = _Person.Gender ? "Male" : "Female";
                 
                lbPhone.Text = _Person.Phone;
                lbEmail.Text = _Person.Email;
                lbAddress.Text = _Person.Address;
                lbNationalID.Text = _Person.NationalID;

                lbCreatedByUser.Text = _Person.CreatedByUserID.ToString();
                lbAge.Text = (DateTime.Now.Year - _Person.DateOfBirth.Year).ToString();

                // set UserControl info
                ucTitle.Text = $"{_Person.FullName} Details";
                _LoadPersonImageAndGenderImage();


                // Enameble Update Link
                lbUpdatePerson.Enabled = true;


                LoadUserInfoForThisPerson();


                
            } 
        }

        public void ResetPersonInfo()
        {

            _Person = null;
            _PersonID = -1;
            lbPersonID.Text = "";
            lbFullName.Text = "";
            lbDateOfBirth.Text = "";
            lbGender.Text = "";
            lbPhone.Text = "";
            lbEmail.Text = "";
            lbAddress.Text = "";
            lbNationalID.Text = "";
            lbCreatedByUser.Text = "";
            lbAge.Text = "";
            ucTitle.Text = "Person Details";
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


        private void _LoadPersonImageAndGenderImage() {
            // Set Main Image
            pbUserControlImage.ImageLocation = _Person.Gender ? clsGloble.MalePersonDefaultImage : clsGloble.FemalePersonDefaultImage;
            // Set Person Image
            pbPersonImage.ImageLocation = _Person.ImagePath;
             
             
        }

        private void lbUpdatePerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_PersonID != -1)
            {
                Form frm = new frmAddUpdatePerson(_PersonID);
                frm.ShowDialog();
                LoadPerson(_PersonID);

                
                PersonUpdated(_PersonID);
            }
            
        }

 

        public void Clear()
        {
            ResetPersonInfo();
        }


        private void LoadUserInfoForThisPerson()
        {
            if (_Person != null)
            {
                if (clsUser.IsUserExistByPersonID(_PersonID))
                {
                    User = clsUser.FindByPersonID(_PersonID);
                    _UserID = User.UserID;
                    lbUserID.Text = _UserID.ToString();
                }

            }
        }

        private void ucPersonInfo_Load(object sender, EventArgs e)
        {
            ResetPersonInfo();
        }
    }
}
