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
    public partial class frmParentsDetails : Form
    {
        int _ParentsID;
        clsParents _Parents;

        public event Action<int> OnParentsSelected;

        public virtual void SelectedParents(int ParentsID)
        {
            Action<int> habdler = OnParentsSelected;
            if (habdler != null)
            {
                habdler(ParentsID);
            }
        }

        private bool _ShowSelectButton = true;

        public bool ShowSelectButton
        {
            get { return _ShowSelectButton; }
            set
            {
                _ShowSelectButton = value;
                btnSelectParents.Visible = _ShowSelectButton;
            }
        }

        public frmParentsDetails(int parentsID)
        {
            InitializeComponent();
            _ParentsID = parentsID;
        }




        private void _LoadData()
        {
            if (!clsParents.IsParentsExist(_ParentsID)) {
                MessageBox.Show($"Not Found Parents With ID {_ParentsID}","NotFound",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
                
            }

            _Parents = clsParents.Find(_ParentsID);

            if (_Parents != null)
            {
                pnFather.LoadPerson(_Parents.FatherID);
                pnMother.LoadPerson(_Parents.MotherID);


                pnFather.Title = "Father Information";
                pnMother.Title = "Mother Information";
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmParentsDetails_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSelectParents_Click(object sender, EventArgs e)
        {
            if (_ParentsID != -1 && btnSelectParents.Visible)
            {
                SelectedParents(_ParentsID);
            }
        }
    }
}
