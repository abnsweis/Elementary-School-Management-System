using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class clsStudent
    {
        public enum enMode { Add, Update, }
        public enum enStudentStatus
        {
            Active = 1,      // نشط
            Inactive = 2,    // غير نشط
            Graduated = 3,   // متخرج
            DroppedOut = 4,  // متسرب
            Expelled = 5,    // مفصول
            Suspended = 6    // معلق
        }
        public int StudentID { get; set; }
        public int PersonID { get; set; }
        public int ParentsID { get; set; }
        public string StudentNumber { get; set; }
        public enStudentStatus Status { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime LastUpdateStatus { get; set; }
        public string Notes { get; set; }

        public clsParents parents { get; set; }
        public clsPerson person { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUser CreatedByUserInfo { get; set; }
        enMode _Mode = enMode.Add;

        /// <summary>
        /// Constructor to initialize a student object with given parameters.
        /// </summary>
        public clsStudent(int studentID, int personID, int parentsID, string studentNumber, enStudentStatus status, DateTime admissionDate, DateTime LastUpdateStatus, string notes, int createdByUserID)
        {
            _Mode = enMode.Update;
            this.StudentID = studentID;
            this.PersonID = personID;
            this.ParentsID = parentsID;
            this.StudentNumber = studentNumber;
            this.Status = status;
            this.AdmissionDate = admissionDate;
            this.LastUpdateStatus = LastUpdateStatus;
            this.Notes = notes;
            this.CreatedByUserID = createdByUserID;
            this.CreatedByUserInfo = clsUser.Find(CreatedByUserID);
            this.parents = clsParents.Find(parentsID);
            this.person = clsPerson.Find(personID);
        }

        /// <summary>
        /// Default constructor to initialize a new student object.
        /// </summary>
        public clsStudent()
        {
            _Mode = enMode.Add;
            StudentID = -1;
            PersonID = -1;
            ParentsID = -1;
            StudentNumber = string.Empty;
            Status = enStudentStatus.Active;
            AdmissionDate = DateTime.MinValue;
            LastUpdateStatus = DateTime.MinValue;
            Notes = string.Empty;
            CreatedByUserID = -1;
            CreatedByUserInfo = null;
            parents = null;
            person = null;
        }

        /// <summary>
        /// Saves the student object to the database.
        /// </summary>
        /// <returns>True if the save operation was successful, False otherwise.</returns>
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    {
                        if (_AddNewStudent())
                        {
                            _Mode = enMode.Update;
                            return true;
                        } else return false;
                    }
                case enMode.Update:
                    {
                        return _UpdateStudent();
                    }
                default:
                    return false;
            }
        }

        /// <summary>
        /// Returns all students from the database as a DataTable.
        /// </summary>
        /// <returns>A DataTable containing all students.</returns>
        public static DataTable GetAllStudents()
        {
            return clsStudentData.GetAllStudents();
        }

        /// <summary>
        /// Adds a new student to the database.
        /// </summary>
        /// <returns>True if the addition was successful, False otherwise.</returns>
        private bool _AddNewStudent()
        {
            this.StudentID = clsStudentData.AddNewStudent(PersonID, ParentsID, (short)Status, AdmissionDate, LastUpdateStatus, Notes, CreatedByUserID);
            return this.StudentID > 0;
        }

        /// <summary>
        /// Updates the student in the database.
        /// </summary>
        /// <returns>True if the update was successful, False otherwise.</returns>
        private bool _UpdateStudent()
        {
            return clsStudentData.UpdateStudent(this.StudentID, PersonID, ParentsID, (short)(int)Status, AdmissionDate, LastUpdateStatus, Notes, CreatedByUserID);
        }

        /// <summary>
        /// Deletes the student from the database using the current student object.
        /// </summary>
        /// <returns>True if the deletion was successful, False otherwise.</returns>
        public bool Delete()
        {
            return clsStudentData.DeleteStudent(this.StudentID);
        }

        /// <summary>
        /// Deletes a student from the database using their StudentID.
        /// </summary>
        /// <param name="StudentID">The ID of the student to be deleted.</param>
        /// <returns>True if the deletion was successful, False otherwise.</returns>
        public static bool Delete(int StudentID)
        {
            return clsStudentData.DeleteStudent(StudentID);
        }

        /// <summary>
        /// Finds a student by their StudentID.
        /// </summary>
        /// <param name="StudentID">The ID of the student to find.</param>
        /// <returns>A clsStudent object if found, null otherwise.</returns>
        public static clsStudent Find(int StudentID)
        {
            int PersonID = -1;
            int ParentsID = -1;
            string StudentNumber = "";
            short Status = 0;
            DateTime AdmissionDate = DateTime.MinValue;
            DateTime LastUpdateStatus = DateTime.MinValue;
            string Notes = "";
            int CreatedByUserID = -1;

            if (clsStudentData.GetStudentByID(StudentID, ref PersonID, ref ParentsID, ref StudentNumber, ref Status, ref AdmissionDate, ref LastUpdateStatus, ref Notes, ref CreatedByUserID))
            {
                return new clsStudent(StudentID, PersonID, ParentsID, StudentNumber, (enStudentStatus)Status, AdmissionDate, LastUpdateStatus, Notes, CreatedByUserID); // تحويل short إلى enStudentStatus
            }
            return null;
        }

        /// <summary>
        /// Finds a student by their StudentNumber.
        /// </summary>
        /// <param name="StudentNumber">The student number to find.</param>
        /// <returns>A clsStudent object if found, null otherwise.</returns>
        public static clsStudent Find(string StudentNumber)
        {
            int StudentID = -1;
            int PersonID = -1;
            int ParentsID = -1;
            short Status = 0;
            DateTime AdmissionDate = DateTime.MinValue;
            DateTime LastUpdateStatus = DateTime.MinValue;
            string Notes = "";
            int CreatedByUserID = -1;
            if (clsStudentData.GetStudentByStudentNumber(StudentNumber, ref StudentID, ref PersonID, ref ParentsID, ref Status, ref AdmissionDate, ref LastUpdateStatus, ref Notes, ref CreatedByUserID))
            {
                return new clsStudent(StudentID, PersonID, ParentsID, StudentNumber, (enStudentStatus)Status, AdmissionDate, LastUpdateStatus, Notes, CreatedByUserID); // تحويل short إلى enStudentStatus
            }
            return null;
        }

        /// <summary>
        /// Finds a student by their PersonID.
        /// </summary>
        /// <param name="PersonID">The PersonID to find.</param>
        /// <returns>A clsStudent object if found, null otherwise.</returns>
        public static clsStudent FindByPersonID(int PersonID)
        {
            int StudentID = -1;
            int ParentsID = -1;
            string StudentNumber = "";
            short Status = 0;
            DateTime AdmissionDate = DateTime.MinValue;
            DateTime LastUpdateStatus = DateTime.MinValue;
            string Notes = "";
            int CreatedByUserID = -1;
            if (clsStudentData.GetStudentByPersonID(PersonID, ref StudentID, ref ParentsID, ref StudentNumber, ref Status, ref AdmissionDate, ref AdmissionDate, ref Notes, ref CreatedByUserID))
            {
                return new clsStudent(StudentID, PersonID, ParentsID, StudentNumber, (enStudentStatus)Status, AdmissionDate, LastUpdateStatus, Notes, CreatedByUserID); // تحويل short إلى enStudentStatus
            }
            return null;
        }

        /// <summary>
        /// Checks if a student exists by their StudentID.
        /// </summary>
        /// <param name="StudentID">The StudentID to check.</param>
        /// <returns>True if the student exists, False otherwise.</returns>
        public static bool IsStudentExist(int StudentID)
        {
            return clsStudentData.IsStudentExistByStudentID(StudentID);
        }

        /// <summary>
        /// Checks if a student exists by their StudentNumber.
        /// </summary>
        /// <param name="StudentNumber">The StudentNumber to check.</param>
        /// <returns>True if the student exists, False otherwise.</returns>
        public static bool IsStudentExist(string StudentNumber)
        {
            return clsStudentData.IsStudentExistByStudentNumber(StudentNumber);
        }

        /// <summary>
        /// Checks if a student exists by their PersonID.
        /// </summary>
        /// <param name="PersonID">The PersonID to check.</param>
        /// <returns>True if the student exists, False otherwise.</returns>
        public static bool IsStudentExistByPersonID(int PersonID)
        {
            return clsStudentData.IsStudentExistByPersonID(PersonID);
        }

        /// <summary>
        /// Checks if a person is already a student by their PersonID.
        /// </summary>
        /// <param name="PersonID">The PersonID to check.</param>
        /// <returns>True if the person is already a student, False otherwise.</returns>
        public static bool IsPersonAlreadyStudent(int PersonID)
        {
            return clsStudentData.IsPersonAlreadyStudent(PersonID);
        }




        // generate mothdes for update student status  for example method for update student status to active

        public bool Active()
        {
            return clsStudentData.UpdateStudentStatus(this.StudentID, (int)enStudentStatus.Active);
        }

        public bool Inactive()
        {
            return clsStudentData.UpdateStudentStatus(this.StudentID, (int)enStudentStatus.Inactive);
        }

        public bool Graduated()
        {
            return clsStudentData.UpdateStudentStatus(this.StudentID, (int)enStudentStatus.Graduated);
        }


        public bool DroppedOut()
        {
            return clsStudentData.UpdateStudentStatus(this.StudentID, (int)enStudentStatus.DroppedOut);
        }
        public bool Expelled()
        {
            return clsStudentData.UpdateStudentStatus(this.StudentID, (int)enStudentStatus.Expelled);
        }

        public bool Suspended()
        {
            return clsStudentData.UpdateStudentStatus(this.StudentID, (int)enStudentStatus.Suspended);
        }

         
    }
}
