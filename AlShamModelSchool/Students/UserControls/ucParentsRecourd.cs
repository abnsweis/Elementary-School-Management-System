using AlShamModelSchool.Parents;
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
    public partial class ucParentsRecourd : UserControl
    {
        public clsParents Parents { get; set; }
        private int _ParentsID { get; set; }
        private int _FatherID { get; set; }
        private int _MotherID { get; set; }
        public ucParentsRecourd()
        {
            InitializeComponent();
        }

        private void ucParentsRecourd_Load(object sender, EventArgs e)
        {

        }

        public void LoadParents(int parentsID)
        {
            Parents = clsParents.Find(parentsID);
            LoadData();
        }

        public void LoadData()
        {
            if (Parents != null)
            {
                _ParentsID = Parents.ParentsID;
                _FatherID = Parents.FatherID;
                _MotherID = Parents.MotherID;


                lbFatherName.Text = Parents.Father.FullName;
                lbFatherNationalID.Text = Parents.Father.NationalID;

                lbMotherName.Text = Parents.Mother.FullName;
                lbMatherNationalID.Text = Parents.Mother.NationalID;
            }
        }

        private void FatherBox_Click(object sender, EventArgs e)
        {
            frmParentsDetails frm = new frmParentsDetails(_ParentsID);
             
            frm.ShowDialog();
        }
    }
}
