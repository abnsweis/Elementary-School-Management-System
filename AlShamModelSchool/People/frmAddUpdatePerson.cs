using AlShamModelSchool.Properties;
using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AlShamModelSchool.People.frmAddUpdatePerson;

namespace AlShamModelSchool.People
{
    public partial class frmAddUpdatePerson : Form
    {

        private enum enMode { Add, Update }

        enMode _Mode = enMode.Add;
        int _PersonID = 0;
        clsPerson _Person ;


        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.Add;
        }
        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _PersonID = PersonID;
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbGenderImageTitle.Image = cbGender.SelectedIndex == 0 ? Resources.MakeIcon : Resources.FemaleIcon;
            if (pbPersonImage.ImageLocation == clsGloble.MalePersonDefaultImage
                || pbPersonImage.ImageLocation == clsGloble.FemalePersonDefaultImage
                || pbPersonImage.ImageLocation == ""
                )
            {

                CustomizePersonImage();

            }
        }

      
 
         

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomizePersonImage()
        {
            if (cbGender.SelectedIndex == 0 )
            {
                pbPersonImage.ImageLocation = clsGloble.MalePersonDefaultImage;
            } else
            {
                pbPersonImage.ImageLocation = clsGloble.FemalePersonDefaultImage;
            }
        }


        private bool VerifyFields()
        {

            if (!clsVerifications.ValidateFieldWithLabel(tbFirstName, lbFirstNameRequired)) return false;
            if (!clsVerifications.ValidateFieldWithLabel(tbLastName, lbLastNameRequired)) return false;
            if (!clsVerifications.ValidateFieldWithLabel(tbPhone, lbPhoneRequired)) return false;

            // Verify Email
            if (!clsVerifications.ValidateFieldWithLabel(tbEmail, lbEmailRequired)) return false;
            if (!clsVerifications.IsValidEmail(tbEmail, lbEmailRequired)) return false;
            if (( _Person.Email != tbEmail.Text.Trim()))
            {
                if (clsVerifications.IsEmailAlreadyExists(tbEmail, lbEmailRequired) ) return false;
                
            }
             

            // Verify  National ID
            if (!clsVerifications.ValidateFieldWithLabel(tbNationalID, lbNationalRequired)) return false;
            if (!clsVerifications.IsValidNationalID(tbNationalID, lbNationalRequired)) return false;

            if ((_Person.NationalID != tbNationalID.Text.Trim()))
            {
                if (clsVerifications.IsNationalIDAlreadyExists(tbNationalID, lbNationalRequired)) return false;

            }

            // Verify  Address
            if (!clsVerifications.ValidateFieldWithLabel(tbAddress, lbAddressRequired)) return false;
            return true;
        }

        private void ResetForm()
        {
            if (_Mode == enMode.Add)
            {
                _Person = new clsPerson();
                this.Text = "Add New Person";
                pbFormTitle.Image = Resources.addNewPerson;
                lbFormTitle.Text = "Add New Person";
            }


            

            CustomizePersonImage();
            dtpDateOfBirth.MaxDate = DateTime.Now;
        }

        private void _LoadData() {


            _Person = clsPerson.Find(_PersonID);
            if (_Person != null)
            {

                if (_Mode == enMode.Update)
                {
                    btnSave.Text = "Update";
                    this.Text = $"Update {_Person.FullName}";
                    pbFormTitle.Image = Resources.UpdatePerson;
                    lbFormTitle.Text = $"Update {_Person.FullName}";
                }
                tbFirstName.Text = _Person.FirstName;
                tbLastName.Text = _Person.LastName;
                dtpDateOfBirth.Value = _Person.DateOfBirth;
                cbGender.SelectedIndex = _Person.Gender ? 0 : 1;
                tbPhone.Text = _Person.Phone;
                tbEmail.Text = _Person.Email;
                tbAddress.Text = _Person.Address;
                tbNationalID.Text = _Person.NationalID;
                lbPersonID.Text = _Person.PersonID.ToString();
                if (_Person.ImagePath == "")
                {
                    CustomizePersonImage();
                } else
                {
                pbPersonImage.ImageLocation = _Person.ImagePath;

                }
            }
        }
        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            ResetForm();
            if (_Mode == enMode.Update)
            {
                _LoadData();
            }
            
        }


        private bool _HandlePersonImage()
        {
            if (_Person.ImagePath != pbPersonImage.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                        return false;
                    }
                }

                if (pbPersonImage.ImageLocation != null) 
                {
                    string sourceImageFile = pbPersonImage.ImageLocation.ToString();
                    if (clsUitl.CopyImageToProjectImages(ref sourceImageFile))
                    {
                        pbPersonImage.ImageLocation = sourceImageFile;
                        return true;
                    } else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        return true;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (VerifyFields())
            {
                if (!_HandlePersonImage()) return;
                
                _Person.FirstName = tbFirstName.Text.Trim();
                _Person.LastName = tbLastName.Text.Trim();
                _Person.DateOfBirth = dtpDateOfBirth.Value;
                _Person.Gender = cbGender.SelectedIndex == 0 ? true : false;
                _Person.Phone = tbPhone.Text.Trim();
                _Person.Email = tbEmail.Text.Trim();
                _Person.Address = tbAddress.Text.Trim();
                _Person.NationalID = tbNationalID.Text.Trim();
                _Person.CreatedByUserID = 1;

                _Person.ImagePath = pbPersonImage.ImageLocation;

                if (_Person.Save())
                {
                    MessageBox.Show("Person Saved Successfully");
                    this.Text = "Update Person";
                    pbFormTitle.Image = Resources.UpdatePerson;
                    lbFormTitle.Text = "Update Person";
                    _PersonID = _Person.PersonID;
                    lbPersonID.Text = _PersonID.ToString();
                    
                    _Mode = enMode.Update;
                    DataBack?.Invoke(this, _Person.PersonID);
                } else
                {
                    MessageBox.Show("Error Saving Person");
                }

            }  
        }
         
        private void btnChangePersonImage_Click(object sender, EventArgs e)
        {
            PersonImageFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            PersonImageFileDialog.FilterIndex = 1;
            PersonImageFileDialog.RestoreDirectory = true;

            if (PersonImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = PersonImageFileDialog.FileName;
                pbPersonImage.ImageLocation = selectedFilePath;
                btnRemovePersonImage.Visible = true;
                
            }
        }

        private void btnRemovePersonImage_Click(object sender, EventArgs e)
        {
            pbPersonImage.ImageLocation = null;
            CustomizePersonImage();
            btnRemovePersonImage.Visible = false;
        }
    }
}
