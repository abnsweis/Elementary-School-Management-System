using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BusinessLogicLayer.clsClass;

namespace BusinessLogicLayer
{
    public class clsClassTeacherSubject
    {
        public enum enMode { Add, Update } 
        private enMode _Mode;


        public int TeacherID { get; set; }
        public int SubjectID { get; set; }
        public int ClassID { get; set; }
        public string Description { get; set; }
         
        public clsTeacher Teacher { get; set; }
        public clsSubject Subject { get; set; }
        public clsClass Class { get; set; }

    
        public clsClassTeacherSubject(int classID ,int teacherID, int subjectID)
        {
            TeacherID = teacherID;
            SubjectID = subjectID;
            ClassID = classID;

            Teacher = clsTeacher.Find(teacherID);
            Subject = clsSubject.Find(subjectID);
            Class = clsClass.Find(classID);
            _Mode = enMode.Add;
        }


        
        private  bool _AddTeacherToClassWithSubject()
        {
            return clsClassTeacherSubjectData.AddTeacherToClassWithSubject(this.TeacherID, this.SubjectID, this.ClassID, this.Description);
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
                    if (_AddTeacherToClassWithSubject())
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

        public static int GetTeacherIdBySectionAndSubject(int classId, int subjectId)
        {
            return clsClassTeacherSubjectData.GetTeacherIdBySectionAndSubject(classId, subjectId);
        }



    }
}
