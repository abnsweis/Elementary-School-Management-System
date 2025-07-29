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
    public partial class ucPersonSelector : UserControl
    {
        public event Action<int> OnPersonSelected;

        public event Action OnPersonCleared;
        int _PersonSelectedID = -1;

       

        public virtual void SelectedPerson(int PersonID)
        {
            Action<int> habdler = OnPersonSelected;

            if (habdler != null)
            {
                habdler(PersonID);
            }
        }



        
        public clsPerson SelectedPersonInfo
        { 
            get {

                return ucPersonInfo1.SelectedPerson;
            } 
        
        }
        public int PersonSelectedID
        { 
            get {

                return _PersonSelectedID;
            } 
        
        }
        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return FilterContainer.Enabled;
            }

            set
            {
                _FilterEnabled = value;
                FilterContainer.Enabled = _FilterEnabled;
            }
        
        }

        public ucPersonSelector()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
             
        }

        private void cbFIlterItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterString.PlaceholderText = "Search by " + cbFIlterItems.Text;
            tbFilterString.Text = "";
            tbFilterString.Focus();
        }

  

        private void tbFilterString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSerach.PerformClick();
                 
            }

            if ( cbFIlterItems.Text == "Person ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void FindNow()
        { 
            ucPersonInfo1.Clear();
            switch (cbFIlterItems.SelectedIndex) {

                case 0:
                    {
                        if (int.TryParse(tbFilterString.Text,out int PersonID))
                        {
                           ucPersonInfo1.LoadPerson(PersonID); 
                        } else
                        {
                            ucPersonInfo1.Clear();
                            MessageBox.Show("Invalid PeronID");
                            return;
                        }
                        break;
                    }
                case 1:
                    {
                        ucPersonInfo1.LoadPerson(tbFilterString.Text);
                        break;
                    }
                default:                 
                    break;

            }

            if (SelectedPersonInfo != null)
            {
                if (OnPersonSelected != null && FilterEnabled)
                    OnPersonSelected(ucPersonInfo1.PersonID);  
            }  
        }


        public void LoadPerson(int PersonID)
        {
            tbFilterString.Text = PersonID.ToString();
            FilterEnabled = false;
            cbFIlterItems.SelectedIndex = 0;
            FindNow();
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.DataBack += DataBackEvent; // Subscribe to the event
            frm.ShowDialog();
 

        }

        private void DataBackEvent(object sender, int PersonID)
        {
            // Handle the data received

            cbFIlterItems.SelectedIndex = 1;
            tbFilterString.Text = PersonID.ToString();
            ucPersonInfo1.LoadPerson(PersonID);
            if (ucPersonInfo1.SelectedPerson != null)
            {
                _PersonSelectedID = ucPersonInfo1.SelectedPerson.PersonID;
                if (OnPersonSelected != null && FilterEnabled)
                    OnPersonSelected(_PersonSelectedID);
            }
            FilterEnabled = false;
        }
        private void btnSerach_Click(object sender, EventArgs e)
        {
            lbFiltervalueRequired.Tag = cbFIlterItems.Text;
            if (!clsVerifications.ValidateFieldWithLabel(tbFilterString, lbFiltervalueRequired)) { 
                ucPersonInfo1.Clear();
                OnPersonCleared?.Invoke();
                MessageBox.Show("Please enter a valid value to search", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbFilterString.Focus();
                return;
            };
            

            FindNow();
            tbFilterString.Focus();
        }

        private void tbFilterString_TextChanged(object sender, EventArgs e)
        {
            btnSerach.PerformClick();
        }

        private void ucPersonInfo2_OnPersonUpdated(int obj)
        {
            _PersonSelectedID = obj;
            if (SelectedPersonInfo != null)
            {
                if (OnPersonSelected != null && FilterEnabled)
                    OnPersonSelected(_PersonSelectedID);
            }
        }
    }
}
