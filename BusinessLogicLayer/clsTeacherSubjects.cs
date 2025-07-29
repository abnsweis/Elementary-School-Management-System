using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BusinessLogicLayer.clsClass;

namespace BusinessLogicLayer
{
    public class clsTeacherSubjects
    {
        public enum enMode { Add, Update } 
        private enMode _Mode;


        public int TeacherID { get; set; }
        public int SubjectID { get; set; }
         
        public clsTeacher Teacher { get; set; }
        public clsSubject Subject { get; set; }

    
        public clsTeacherSubjects(int teacherID, int subjectID)
        {
            TeacherID = teacherID;
            SubjectID = subjectID;

            Teacher = clsTeacher.Find(TeacherID);
            Subject = clsSubject.Find(SubjectID);
            _Mode = enMode.Add;
        }


        private bool _AddNewTeacherSubjects()
        {
            return clsTeacherSubjectsData.AssignSubjectToTeacher(this.TeacherID,this.SubjectID);
            
        }

        private bool _UpdateClass()
        {
            //return clsClassData.UpdateClass(ClassID, GradeLevelID, ClassName, MaxStudents, RoomNumber, (short)ShiftType);
            return false;
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    if (_AddNewTeacherSubjects())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateClass();
                default:
                    return false;
            }
        }



       
    }
}
