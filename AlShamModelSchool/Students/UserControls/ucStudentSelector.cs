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

namespace AlShamModelSchool.Students.UserControls
{
    public partial class ucStudentSelector : UserControl
    {
        public event Action<int> OnStudentSelected;

        int _StudentSelectedID = -1;
 
        private bool _FilterEnabled = true;
        public ucStudentSelector()
        {
            InitializeComponent();
        }
        public clsStudent SelectedStudentInfo
        {
            get
            {

                return ucStudentInfo1.SelectedStudent;
            }

        }
        public int StudentSelectedID
        {
            get
            {

                return _StudentSelectedID;
            }

        }
        
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



        private void FindNow()
        {
            ucStudentInfo1.Clear();
            switch (cbFIlterItems.SelectedIndex)
            {

                case 0:
                    {
                        ucStudentInfo1.LoadStudent(Convert.ToInt32(tbFilterString.Text));
                        break;
                    }
                case 1:
                    {
                        ucStudentInfo1.LoadStudent(tbFilterString.Text);
                        break;
                    }
                default:
                    break;

            }

            if (SelectedStudentInfo != null)
            {
                if (OnStudentSelected != null && FilterEnabled)
                    OnStudentSelected(ucStudentInfo1.StudentID);
            }
        }
        public virtual void SelectedStudent(int StudentID)
        {
            Action<int> habdler = OnStudentSelected;

            if (habdler != null)
            {
                habdler(StudentID);
            }
        }
        private void btnSerach_Click(object sender, EventArgs e)
        {

            ucStudentInfo1.Clear();
            lbFiltervalueRequired.Tag = cbFIlterItems.Text;
            if (!clsVerifications.ValidateFieldWithLabel(tbFilterString, lbFiltervalueRequired))
            {
                ucStudentInfo1.Clear();
                tbFilterString.Focus();
                return;
            };


            FindNow();
            tbFilterString.Focus();
        }
        public void LoadStudent(int StudentID)
        {
            tbFilterString.Text = StudentID.ToString();
            FilterEnabled = false;
            cbFIlterItems.SelectedIndex = 0;
            FindNow();
        }
        public void LoadStudent(string StudentNumber)
        {
            tbFilterString.Text = StudentNumber;
            FilterEnabled = false;
            cbFIlterItems.SelectedIndex = 0;
            FindNow();
        }
        private void tbFilterString_TextChanged(object sender, EventArgs e)
        {
            btnSerach.PerformClick();
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

            if (cbFIlterItems.Text == "Student ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        
    }
}
