using AlShamModelSchool.Teachers.UserControls;
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
using static AlShamModelSchool.Teachers.UserControls.ucTeacherShortInfo;

namespace AlShamModelSchool.Teachers
{
    public partial class frmTeacherSelector : Form
    {
        private DataTable _dtTeachers;
        private int _SubjectID = -1;



        public class SelectedTeacherAndSubjectEventArgs : SelectedTeacherEventArgs
        {
            public int SubjectID { get; }
            public clsSubject Subject {get;} 
            public SelectedTeacherAndSubjectEventArgs(int teacherID, clsTeacher teacher, int subjectID)
                : base(teacherID) // Fix: Call the parameterless constructor of the base class  
            {
                SubjectID = subjectID;
                Subject = clsSubject.Find(subjectID);
            }
        }

        public event EventHandler<SelectedTeacherAndSubjectEventArgs> OnSelectedTeacherAndSubject;

        private bool _isTeacherSelected = false;
        public frmTeacherSelector(int SubjectID)
        {
            InitializeComponent();
            _SubjectID = SubjectID;
        }

      

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateTeacherShortInfo()
        {
            flpTeachers.Controls.Clear(); // Clear existing controls
            foreach (DataRow row in _dtTeachers.Rows)
            {
                ucTeacherShortInfo teacherShortInfo = new ucTeacherShortInfo();
                teacherShortInfo.OnTeacherSelected += TeacherShortInfo_OnTeacherSelected;
                int teacherID = Convert.ToInt32(row["TeacherID"]);  
                teacherShortInfo.LoadTeacherInfo(teacherID); 
                flpTeachers.Controls.Add(teacherShortInfo);
                 
            }
        }

        private void TeacherShortInfo_OnTeacherSelected(object sender, SelectedTeacherEventArgs e)
        {
            OnSelectedTeacherAndSubject?.Invoke(this, new SelectedTeacherAndSubjectEventArgs(e.TeacherID, e.Teacher, _SubjectID));
            this.Close();
        }

        private void frmTeacherSelector_Load(object sender, EventArgs e)
        {

            if (clsSubject.IsSubjectExists(_SubjectID))
            {
                _dtTeachers = clsSubject.GetSubjectTeachers(_SubjectID);
                CreateTeacherShortInfo();  
            }
        }



         
         
    }
}
