using System;
using System.Collections.Generic;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class clsClass
    {
        public enum enMode { Add, Update }
        
        public enum enShiftType { Afternoon = 0, Morning = 1 }

        private enMode _Mode;

        public int ClassID { get; set; }
        public int GradeLevelID { get; set; }
        public string ClassName { get; set; }
        public int MaxStudents { get; set; }
        public string RoomNumber { get; set; }
        public enShiftType ShiftType { get; set; }

        public clsGradeLevel GradeLevel;

        public List<clsSubject> subjects { get; set; } = new List<clsSubject>();
        private clsClass(int classID, int gradeLevelID, string className, int maxStudents, string roomNumber, enShiftType shiftType)
        {
            _Mode = enMode.Update;
            ClassID = classID;
            GradeLevelID = gradeLevelID;
            ClassName = className;
            MaxStudents = maxStudents;
            RoomNumber = roomNumber;
            ShiftType = shiftType;
            GradeLevel = clsGradeLevel.Find(gradeLevelID);
        }

        public clsClass()
        {
            _Mode = enMode.Add;
            ClassID = -1;
            GradeLevelID = -1;
            ClassName = string.Empty;
            MaxStudents = 0;
            RoomNumber = string.Empty;
            ShiftType = enShiftType.Afternoon;
            GradeLevel = null;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    if (_AddNewClass())
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

        public static DataTable GetAllClasses()
        {
            return clsClassData.GetAllClasses();
        }
        public static DataTable GetClassesByGradeLevelID(int GradeLevelID)
        {
            return clsClassData.GetClassesByGradeLevelID(GradeLevelID);
        }
        private bool _AddNewClass()
        {
            ClassID = clsClassData.AddNewClass(GradeLevelID, ClassName, MaxStudents, RoomNumber, (short)ShiftType);
            return ClassID > 0;
        }

        private bool _UpdateClass()
        {
            return clsClassData.UpdateClass(ClassID, GradeLevelID, ClassName, MaxStudents, RoomNumber, (short)ShiftType);
        }

        public bool Delete()
        {
            return clsClassData.DeleteClass(ClassID);
        }

        public static bool Delete(int classID)
        {
            return clsClassData.DeleteClass(classID);
        }

        public static clsClass Find(int classID)
        {
            int gradeLevelID = -1;
            string className = "";
            int maxStudents = 0;
            string roomNumber = "";
            enShiftType shiftType = enShiftType.Afternoon;
            short shiftTypeInt = (short)enShiftType.Afternoon;

            if (clsClassData.GetClassByID(classID, ref gradeLevelID, ref className, ref maxStudents, ref roomNumber, ref shiftTypeInt))
            {
                return new clsClass(classID, gradeLevelID, className, maxStudents, roomNumber, (enShiftType)shiftTypeInt);
            }
            return null;
        }
        public static clsClass Find(string className)
        {
            int classID = -1; 
            int gradeLevelID = -1; 
            int maxStudents = 0;
            string roomNumber = "";
            enShiftType shiftType = enShiftType.Afternoon;
            short shiftTypeInt = (short)enShiftType.Afternoon;

            if (clsClassData.GetClassByIDName(className, ref gradeLevelID, ref classID, ref maxStudents, ref roomNumber, ref shiftTypeInt))
            {
                return new clsClass(classID, gradeLevelID, className, maxStudents, roomNumber, (enShiftType)shiftTypeInt);
            }
            return null;
        }

        public static bool IsClassExist(int classID)
        {
            return clsClassData.IsClassExist(classID);
        }
        public static bool IsClassExist(string ClassName)
        {
            return clsClassData.IsClassExist(ClassName);
        }


        public int GetTotalStudents()
        {
            return clsClassData.GetTotalStudents(this.ClassID);
        }

        
        public int GetAvailableSeats()
        {
            return this.MaxStudents - clsClassData.GetTotalStudents(this.ClassID);
        }


        public bool IsAvailableSeats()
        {
            return GetAvailableSeats() > 0;
        }



       
    }
}
