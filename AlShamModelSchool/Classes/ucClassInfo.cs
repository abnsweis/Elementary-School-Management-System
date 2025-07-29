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

namespace AlShamModelSchool.Classes
{
    public partial class ucClassInfo : UserControl
    {

        clsClass _Class;
        int _ClassID;
        string _ClassName;

        public clsClass SelectedClass {  get { return _Class; } }


        public ucClassInfo()
        {
            InitializeComponent();
        }

        private void ucClassInfo_Load(object sender, EventArgs e)
        {
            Reset();
        }

        public void LoadClassInfo(int ClassID)
        {
            _ClassID = ClassID; 
            if (!clsClass.IsClassExist(ClassID))
            { 
                Reset();
                return;
            }


            _Class = clsClass.Find(ClassID);
            _LoadData();


        }
        public void LoadClassInfo(string ClassName)
        {
            _ClassName = ClassName;
            if (!clsClass.IsClassExist(ClassName))
            {
                Reset();
                return;
            }


            _Class = clsClass.Find(ClassName);
            _LoadData();


        }

        private void _LoadData()
        {
            if (_Class != null)
            {
                lbClassID.Text = _Class.ClassID.ToString();
                lbClassName.Text = _Class.ClassName;
                lbGradeLevelName.Text = _Class.GradeLevel.GradeLevelName;
                lbRommNumber.Text = _Class.RoomNumber;
                lbRommNumber.Text = _Class.RoomNumber;
                lbMaxStudents.Text = _Class.MaxStudents.ToString();
                lbShiftType.Text = _Class.ShiftType == clsClass.enShiftType.Morning ? "Morning" : "Afternoon";
                lbAvailableSeats.Text = _Class.GetAvailableSeats().ToString();
                lbMaxnimumAge.Text = _Class.GradeLevel.MaxAge.ToString();
                lbMinimumAge.Text = _Class.GradeLevel.MinAge.ToString();
                lbBookCount.Text = _Class.GradeLevel.BooksCount.ToString() + " Books";
                lbStudentsEnrollmentCount.Text = _Class.GetTotalStudents().ToString();
                lbLinkEditeClass.Enabled = true;
            }
        }
        private void Reset()
        {
            foreach (var C in this.Controls)
            {
                if (C is Label lb)
                {
                    if(lb.Text.StartsWith("lb")){

                        lb.Text = "..........";
                    }
                }
            }

            lbLinkEditeClass.Enabled = false;
        }


 
        private void lbLinkEditeClass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmAddUpdateClass(_Class.ClassID);
            frm.ShowDialog();
        }
    }
}
