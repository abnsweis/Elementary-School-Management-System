using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class clsTeacher
    {
        public enum enMode { Add, Update }

        private enMode _Mode;

        public int TeacherID { get; set; }
        public int PersonID { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public string Specialization { get; set; }
        public int YearsOfExperience { get; set; }
        public bool IsActive { get; set; }
        public DateTime? TerminationDate { get; set; }
        public clsPerson person { get; set; }

        public List<clsSubject> subjects { get; set; }


        private void SetModeToUpdate()
        {
            _Mode = enMode.Update;
        }
        public clsTeacher()
        {
            TeacherID = -1;
            PersonID = -1;
            HireDate = DateTime.MinValue;
            Salary = 0;
            Specialization = string.Empty;
            YearsOfExperience = -1;
            IsActive = false;
            TerminationDate = DateTime.MinValue;
            _Mode = enMode.Add;
            person = new clsPerson();
            subjects = new List<clsSubject>();
        }

        private clsTeacher(int teacherID, int personID, DateTime hireDate, decimal salary,  int yearsOfExperience, bool isActive, DateTime? terminationDate)
        {
            TeacherID = teacherID;
            PersonID = personID;
            HireDate = hireDate;
            Salary = salary;
            Specialization = "";
            YearsOfExperience = yearsOfExperience;
            IsActive = isActive;
            TerminationDate = terminationDate;
            person = clsPerson.Find(PersonID);
            subjects = clsTeacherSubjectsData.GetTeacherSubjects(teacherID).ToList<clsSubject>();
            _Mode = enMode.Update;
        }

        private bool _AddNewteacher()
        {
            this.TeacherID=  clsTeacherData.AddTeacher(PersonID, HireDate, Salary, YearsOfExperience, IsActive, TerminationDate);

            return (this.TeacherID != -1);
        }

        private bool _UpdateTeacher()
        {
            return clsTeacherData.UpdateTeacher(this.TeacherID,this.PersonID,this.Salary,this.YearsOfExperience,this.IsActive);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    if (_AddNewteacher())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                return _UpdateTeacher();
                default:
                    return false;
            }
        }

        public static DataTable GetAllTeachers()
        {
            return clsTeacherData.GetAllTeachers();
        }
        public static int GetTeachersCounts(bool? IsActive = null)
        {
            return clsTeacherData.GetTeachersCounts(IsActive);
        }        
        
        public static decimal GetTotalSalary()
        {
            return clsTeacherData.GetTotalSalary();
        }
        public static clsTeacher Find(int teacherID)
        {
            int personID = -1;
            DateTime hireDate = DateTime.MinValue;
            decimal salary = 0;
            int yearsOfExperience = 0;
            bool isActive = false;
            DateTime? terminationDate = null;

            if (clsTeacherData.GetTeacherByID(teacherID, ref personID, ref hireDate, ref salary,
               ref yearsOfExperience, ref isActive, ref terminationDate))
            {
                return new clsTeacher(teacherID, personID, hireDate, salary
                    , yearsOfExperience, isActive, terminationDate);
            }

            return null;
        }
        public static clsTeacher GetTeacherByPersonID(int PersonID)
        {
            int teacherID = -1;
            DateTime hireDate = DateTime.MinValue;
            decimal salary = 0;
            string specialization = string.Empty;
            int yearsOfExperience = 0;
            bool isActive = false;
            DateTime? terminationDate = null;

            if (clsTeacherData.GetTeacherByPersonID(PersonID, ref teacherID, ref hireDate, ref salary,
      ref yearsOfExperience, ref isActive, ref terminationDate))
            {
                return new clsTeacher(teacherID, PersonID, hireDate, salary,
                     yearsOfExperience, isActive, terminationDate);
            }

            return null;
        }

        public bool Delete()
        {
            
            return clsPerson.Delete(this.PersonID);
        }
        public static bool Delete(int TeacherID)
        {
            return clsTeacherData.DeleteTeacher(TeacherID);

        }


        public static bool IsTeacherExist(int TeacherID)
        {
            return clsTeacherData.IsTeacherExist(TeacherID);
        }

        public static bool IsThePersonTeacher(int PersonID)
        {
            if (!clsPerson.IsPersonExist(PersonID)) return false;

            return clsTeacherData.IsThePersonTeacher(PersonID);
        }

        public bool IsTeacherAlreadyStudyingSubject(int SubjectID) => clsTeacherSubjectsData.IsTeacherAlreadyStudyingSubject(this.TeacherID, SubjectID);
        public static bool IsTeacherAlreadyStudyingSubject(int TeacherID ,int SubjectID) => clsTeacherSubjectsData.IsTeacherAlreadyStudyingSubject(TeacherID, SubjectID);
        public static bool IsTeachingAnySubject(int TeacherID ) => clsTeacherSubjectsData.IsTeachingAnySubject(TeacherID);

        public bool AssignSubjectToTeacher(int SubjectID)
        {
            if (!clsSubjectData.IsSubjectExists(SubjectID)) return false;
            if (IsTeacherAlreadyStudyingSubject(SubjectID)) return false;
            return clsTeacherSubjectsData.AssignSubjectToTeacher(this.TeacherID, SubjectID);
        }


        public  bool RemoveSubjectFromTeacher(int SubjectID)
        {   
            if (!clsSubjectData.IsSubjectExists(SubjectID)) return false;
            
            if (!IsTeacherAlreadyStudyingSubject(SubjectID)) return false;
            return clsTeacherSubjectsData.RemoveSubjectFromTeacher(this.TeacherID, SubjectID);
        }



        public static bool isTeacherActive(int TeacherID)
        {
            return clsTeacherData.isTeacherActive(TeacherID);
        }

        public bool Activate() {
            return clsTeacherData.UpdateTeacherStatus(this.TeacherID, true);
        }
        public bool Deactivate()
        {
            return clsTeacherData.UpdateTeacherStatus(this.TeacherID, false);
        }        
        
        public static bool Activate(int teacherID) {
            return clsTeacherData.UpdateTeacherStatus(teacherID, true);
        }
        public static bool Deactivate(int teacherID)
        {
            return clsTeacherData.UpdateTeacherStatus(teacherID, false);
        }
        public static bool UpdateTeacherStatus(int teacherID, bool isActive)
        {
            return clsTeacherData.UpdateTeacherStatus(teacherID,isActive);
        }
    }
}
