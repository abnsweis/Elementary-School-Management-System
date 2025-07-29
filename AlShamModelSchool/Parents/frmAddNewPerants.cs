using AlShamModelSchool.People;
using AlShamModelSchool.People.UserControls;
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

namespace AlShamModelSchool.Parents
{
    public partial class frmAddNewPerants : Form
    {

        private int _FatherID;
        private int _MotherID;



        private clsParents _Parents;

        public frmAddNewPerants()
        {
            InitializeComponent();

        }

        private void btnAddNewFather_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.cbGender.SelectedIndex = 0;
            frm.cbGender.Enabled = false;
            frm.DataBack += DataBackEvent_FatherSelected;
            frm.ShowDialog();
        }


        private void DataBackEvent_FatherSelected(object sender, int PersonID)
        {
            // Handle the data received
              
            ucFatherInfo.LoadPerson(PersonID);
            if (ucFatherInfo.SelectedPerson != null)
            {
                ucFatherInfo.EnabledUpdateButton = true;
                _FatherID = ucFatherInfo.SelectedPerson.PersonID;
                btnAddNewFather.Enabled = false;
            } 
        }

        private void DataBackEvent_MotherSelected(object sender, int PersonID)
        {
            // Handle the data received

            ucMotherInfo.LoadPerson(PersonID);
            if (ucMotherInfo.SelectedPerson != null)
            {
                ucMotherInfo.EnabledUpdateButton = true;
                _MotherID = ucMotherInfo.SelectedPerson.PersonID;
                btnAddNewMother.Enabled = false;
            }
        }

        private void btnAddNewMother_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.cbGender.SelectedIndex = 1;
            frm.cbGender.Enabled = false;
            frm.DataBack += DataBackEvent_MotherSelected;
            frm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsPerson.IsPersonExist(_FatherID) && clsPerson.IsPersonExist(_MotherID))
            {
                _Parents = new clsParents(_FatherID, _MotherID);


                if (_Parents.Save())
                {
                    MessageBox.Show("Parents Saved Successfully", "Successfully",MessageBoxButtons.OK,MessageBoxIcon.Information); 
                    this.Close();
                }
            }
        }
    }
}
