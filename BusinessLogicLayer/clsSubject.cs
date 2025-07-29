using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class clsSubject
    {
        private  enum enMode { Add, Update}
        private enMode _Mode;
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public int MaxMarks { get; set; }
        public int PassingMarks { get; set; }
        public string Description { get; set; }
        public List<clsTeacher> Teachers { get; set; }



        private void SetModeToUpdate()
        {
            _Mode = enMode.Update;
        }
        private clsSubject(int subjectID, string subjectName, int maxMarks, int passingMarks, string description)
        {
            SubjectID = subjectID;
            SubjectName = subjectName;
            MaxMarks = maxMarks;
            PassingMarks = passingMarks;
            Description = description;
            _Mode = enMode.Update;

            Teachers = clsTeacherSubjectsData.GetSubjectTeachers(subjectID).ToList<clsTeacher>();
        }

        public clsSubject()
        {
            SubjectID = 0;
            SubjectName = string.Empty;
            MaxMarks = 0;
            PassingMarks = 0;
            Description = string.Empty;
            _Mode = enMode.Add;
            Teachers = new List<clsTeacher>();
        }

        public static DataTable GetSubjectTeachers(int SubjectID) => clsTeacherSubjectsData.GetSubjectTeachers(SubjectID);
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    //if (_AddNewClass())
                    //{
                    //    _Mode = enMode.Update;
                    //    return true;
                    //}
                    return false;
                case enMode.Update:
                //return _UpdateClass();
                default:
                    return false;
            }
        }



        public static DataTable GetAllSubjects()
        { 
            return clsSubjectData.GetAllSubjects();
        }
        public static bool IsSubjectExists(int subjectID) => clsSubjectData.IsSubjectExists(subjectID);
        public static bool IsSubjectExists(string SubjectName) => clsSubjectData.IsSubjectExists(SubjectName);
        public static clsSubject Find(int SubjectID) {

                
            string SubjectName = string.Empty;
            byte MaxMarks = 0;
            byte PassingMarks = 0;
            string Description = string.Empty;

            if (clsSubjectData.GetSubjectByID(SubjectID,ref SubjectName, ref MaxMarks,ref PassingMarks,ref Description))
            {
                return new clsSubject(SubjectID, SubjectName, MaxMarks,PassingMarks,Description);   
            }


            return null;
        }
        public static clsSubject Find(string SubjectName)
        {


            int SubjectID = -1;
            byte MaxMarks = 0;
            byte PassingMarks = 0;
            string Description = string.Empty;

            if (clsSubjectData.GetSubjectByName(SubjectName, ref SubjectID, ref MaxMarks, ref PassingMarks, ref Description))
            {
                return new clsSubject(SubjectID, SubjectName, MaxMarks, PassingMarks, Description);
            }


            return null;
        }
        public  bool IsTeacherAlreadyStudyingSubject(int TeacherID) => clsTeacherSubjectsData.IsTeacherAlreadyStudyingSubject(TeacherID,this.SubjectID);
       
    }
}
