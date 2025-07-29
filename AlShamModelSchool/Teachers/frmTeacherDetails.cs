using AlShamModelSchool.Teachers.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlShamModelSchool.Teachers
{
    public partial class frmTeacherDetails : Form
    {
        private readonly int teacherID;

        public frmTeacherDetails(int TeacherID)
        {
            InitializeComponent();
            teacherID = TeacherID;
        }

        private void frmTeacherDetails_Load(object sender, EventArgs e)
        {
            usTeacherDetails1.LoadTeacherInfo(teacherID);
        }
    }
}
