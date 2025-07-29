using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class clsStudentEnrollment
    {
        public enum enStudentEnrollmentStatus  {Active = 1 , Completed = 2 ,  Failed =3}
        public enum enMode { Add, Update }
        private enMode _Mode;

        public int StudentEnrollmentID { get; set; }
        public int ClassID { get; set; }
        public clsClass Class { get; set; }
        public int StudentID { get; set; }
        public clsStudent Student { get; set; }
        public enStudentEnrollmentStatus Status { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public bool IsRepeating { get; set; }
        public string Notes { get; set; }
        public string ExitReason { get; set; }

        private clsStudentEnrollment(int studentEnrollmentID, int classID, int studentID, enStudentEnrollmentStatus status, DateTime enrollmentDate, DateTime? exitDate, bool isRepeating, string notes, string exitReason)
        {
            StudentEnrollmentID = studentEnrollmentID;
            ClassID = classID;
            Class = clsClass.Find(classID);
            StudentID = studentID;
            Student = clsStudent.Find(studentID);
            Status = status;
            EnrollmentDate = enrollmentDate;
            ExitDate = exitDate;
            IsRepeating = isRepeating;
            Notes = notes;
            ExitReason = exitReason;
            _Mode = enMode.Update;
        }
        
        public clsStudentEnrollment()
        {
            StudentEnrollmentID = -1;
            ClassID = -1;
            StudentID = -1;
            Status = enStudentEnrollmentStatus.Active;
            EnrollmentDate = DateTime.MinValue;
            ExitDate = DateTime.MinValue;
            IsRepeating = false;
            Notes = string.Empty;
            ExitReason = string.Empty;
            _Mode = enMode.Add;
        }

        private bool _AddNew()
        {
            this.StudentEnrollmentID =  clsStudentEnrollmentData.AddNewStudentEnrollment(
                ClassID,StudentID, (short)Status,
                EnrollmentDate,
                ExitDate, IsRepeating,
                Notes,
                ExitReason
            );


            return this.StudentEnrollmentID != -1 ;
        }

         
        private bool _Update()
        {
            return clsStudentEnrollmentData.UpdateStudentEnrollment(
                studentEnrollmentID: StudentEnrollmentID,
                classID: ClassID,
                studentID: StudentID,
                status: (short)Status,
                enrollmentDate: EnrollmentDate,
                exitDate: ExitDate,
                isRepeating: IsRepeating,
                notes: Notes,
                exitReason: ExitReason
            );
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    if (_AddNew())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _Update();
                default:
                    return false;
            }
        }


        public bool Delete()
        {
            return clsStudentEnrollmentData.DeleteStudentEnrollment(StudentEnrollmentID);
        }

        public static bool Delete(int StudentEnrollmentID)
        {
            return clsStudentEnrollmentData.DeleteStudentEnrollment(StudentEnrollmentID);
        }

         
        public static clsStudentEnrollment Find(int studentEnrollmentID)
        {
            int classID = 0, studentID = 0;
            short status = 0;
            DateTime enrollmentDate = DateTime.MinValue;
            DateTime? exitDate = null;
            bool isRepeating = false;
            string notes = "", exitReason = "";

            bool isFound = clsStudentEnrollmentData.GetStudentEnrollmentByID(
                studentEnrollmentID: studentEnrollmentID,
                ref classID,
                ref studentID,
                ref status,
                ref enrollmentDate,
                ref exitDate,
                ref isRepeating,
                ref notes,
                ref exitReason
            );

            if (isFound)
            {
                return new clsStudentEnrollment(studentEnrollmentID,
                                                classID,
                                                studentID,
                                                (enStudentEnrollmentStatus)status,
                                                enrollmentDate,
                                                exitDate,
                                                isRepeating: isRepeating,
                                                notes,
                                                exitReason);
                 
            }

            return null;
        }


        public static DataTable GetAllStudentEnrollments()
        {
            return clsStudentEnrollmentData.GetAllStudentEnrollments();
        }

        public static bool IsStudentEnrollmentExist(int studentEnrollmentID)
        {
            return clsStudentEnrollmentData.IsStudentEnrollmentExist(studentEnrollmentID);
        }


        public static DataTable GetStudentEnrollmentsByClassID(int classID)
        {
            return clsStudentEnrollmentData.GetStudentEnrollmentsByClassID(classID);
        }
        public DataTable GetStudentEnrollmentsByClassID()
        {
            return clsStudentEnrollmentData.GetStudentEnrollmentsByClassID(this.ClassID);
        }

        public static DataTable GetStudentEnrollmentsByStudentID(int StudentID)
        {
            return clsStudentEnrollmentData.GetStudentEnrollmentsByStudentID(StudentID);
        }
        public DataTable GetStudentEnrollmentsByStudentID()
        {
            return clsStudentEnrollmentData.GetStudentEnrollmentsByStudentID(this.StudentID);
        }
        public static int GetTotalStudentsInClass(int classID)
        {
            return clsStudentEnrollmentData.GetTotalStudentsInClass(classID);
        }

        public static bool IsStudentEnrolledInClass(int classID, int StudentID)
        {
            return clsStudentEnrollmentData.IsStudentEnrolledInClass(classID,StudentID);
        }
    }
}
