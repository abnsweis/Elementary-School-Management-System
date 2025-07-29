using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlShamModelSchool.People
{
    public partial class frmPersonDetails : Form
    {
        private int _PersonID;
        private string _NationalID;
        public frmPersonDetails(int personID)
        {
            InitializeComponent();
            _PersonID = personID;
        }
        public frmPersonDetails(string NationalID)
        {
            InitializeComponent();
            _NationalID = NationalID;
        }
        private void frmPersonDetails_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_NationalID))
            {
                ucPersonInfo1.LoadPerson(_PersonID);
                return;
            }
            ucPersonInfo1.LoadPerson(_NationalID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
