using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlShamModelSchool.Students
{
    public partial class frmStudentDetails : Form
    {
        private int _StudentID;
        private string _StudentNumber;

        public frmStudentDetails(int studentID)
        {
            InitializeComponent();
            _StudentID = studentID;
        }
        public frmStudentDetails(string StudentNumber)
        {
            InitializeComponent();
            _StudentNumber = StudentNumber;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStudentDetails_Load(object sender, EventArgs e)
        {
            if (_StudentID != -1)
            {
                ucStudentInfo1.LoadStudent(_StudentID);
                this.Text = "Student ID: " + _StudentID.ToString();
            }

            if (!string.IsNullOrEmpty(_StudentNumber))
            {
                ucStudentInfo1.LoadStudent(_StudentNumber);
                this.Text = "Student Number: " + _StudentNumber;
            }
        }
    }
}
