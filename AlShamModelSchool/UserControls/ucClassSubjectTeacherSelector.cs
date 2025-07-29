using AlShamModelSchool.Teachers;
using AlShamModelSchool.Teachers.UserControls;
using BusinessLogicLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlShamModelSchool.UserControls
{
    public partial class ucClassSubjectTeacherSelector : UserControl
    {
        private int _SubjectID = -1;
        private int _TeacherID = -1;
        private clsSubject _Subject ;
        private clsTeacher _Teacher;

        public int SubjectID
        {
            get { return _SubjectID; } 
        }
        public int TeacherID
        {
            get { return _TeacherID; } 
            private set { _TeacherID = value; 
            ucTeacherShortInfo1.LoadTeacherInfo(_TeacherID);
            }
        }
        private bool _SelectedTeacher = false;

        public bool IsSelectedTeacher
        {
            get { return _SelectedTeacher; } 
        }
        public ucClassSubjectTeacherSelector()
        {
            InitializeComponent();
        }


        public void LoadInfoSubject(int SubjectID)
        {
            _SubjectID = SubjectID;
            if (!clsSubject.IsSubjectExists(_SubjectID))
            {
                return;
            }


            _Subject = clsSubject.Find(_SubjectID);
            lbSubjectName.Text = _Subject.SubjectName;
        }


        public void LoadInfo(int TeacherId ,int SubjectID)
        {
            _SubjectID = SubjectID;
            _TeacherID = TeacherId;
            if (!clsSubject.IsSubjectExists(_SubjectID)) return;
            if (!clsTeacher.IsTeacherExist(_TeacherID)) return;


            _Subject = clsSubject.Find(_SubjectID);
            _Teacher = clsTeacher.Find(_TeacherID);
            lbSubjectName.Text = _Subject.SubjectName;
            ucTeacherShortInfo1.LoadTeacherInfo(_TeacherID);
        }


        private void btnSelectTeacher_Click(object sender, EventArgs e)
        {
            frmTeacherSelector frm = new frmTeacherSelector(_SubjectID);
            frm.OnSelectedTeacherAndSubject += frmTeacherSelector_OnTeacherSelected;
            frm.ShowDialog();
        }



        private void frmTeacherSelector_OnTeacherSelected(object sender, frmTeacherSelector.SelectedTeacherAndSubjectEventArgs e)
        {

            ucTeacherShortInfo1.LoadTeacherInfo(e.TeacherID);
            btnSelectTeacher.Enabled = false;
            _SelectedTeacher = true;
            _TeacherID = e.TeacherID;
            _Teacher = clsTeacher.Find(_TeacherID);
            _SubjectID = e.SubjectID;
            _Subject = e.Subject;

        }



        public void Clear() {
        
            ucTeacherShortInfo1.DisableControl();
            btnSelectTeacher.Enabled = false;
            lbSubjectName.Text = string.Empty;
        }

    }
}
