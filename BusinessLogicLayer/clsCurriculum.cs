using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class clsCurriculum
    {
        public enum enMode { Add, Update }
        private enMode _Mode;

        public int CurriculumID { get; set; }
        public string CurriculumName { get; set; }
        public string Description { get; set; }
        public int EducationLevelID { get; set; }
        public clsEducationLevel _EducationLevel;
        public clsEducationLevel EducationLevel
        {
            get
            {
                return _EducationLevel;
            }
        }
        public DateTime PublicationDate { get; set; }

        public clsCurriculum(int curriculumID, string curriculumName, string description, int educationLevelID, DateTime publicationDate)
        {
            _Mode = enMode.Update;
            CurriculumID = curriculumID;
            CurriculumName = curriculumName;
            Description = description;
            EducationLevelID = educationLevelID;
            _EducationLevel = clsEducationLevel.Find(educationLevelID);
            PublicationDate = publicationDate;
        }

        public clsCurriculum()
        {
            _Mode = enMode.Add;
            CurriculumID = -1;
            CurriculumName = string.Empty;
            Description = string.Empty;
            EducationLevelID = -1;
            _EducationLevel = null;
            PublicationDate = DateTime.MinValue;
        }

        /// <summary>
        /// Saves the curriculum object to the database.
        /// </summary>
        /// <returns>True if the save operation was successful, False otherwise.</returns>
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    if (_AddNewCurriculum())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateCurriculum();
                default:
                    return false;
            }
        }


        public static DataTable GetAllCurriculums()
        {
            return clsCurriculumData.GetAllCurriculums();
        }
        /// <summary>
        /// Adds a new curriculum to the database.
        /// </summary>
        /// <returns>True if the addition was successful, False otherwise.</returns>
        private bool _AddNewCurriculum()
        {
            CurriculumID = clsCurriculumData.AddNewCurriculum(CurriculumName, Description, EducationLevelID, PublicationDate);
            return CurriculumID > 0;
        }

        /// <summary>
        /// Updates the curriculum in the database.
        /// </summary>
        /// <returns>True if the update was successful, False otherwise.</returns>
        private bool _UpdateCurriculum()
        {
            return clsCurriculumData.UpdateCurriculum(CurriculumID, CurriculumName, Description, EducationLevelID);
        }

        /// <summary>
        /// Deletes the curriculum from the database using the current curriculum object.
        /// </summary>
        /// <returns>True if the deletion was successful, False otherwise.</returns>
        public bool Delete()
        {
            return clsCurriculumData.DeleteCurriculum(CurriculumID);
        }

        /// <summary>
        /// Deletes a curriculum from the database using its CurriculumID.
        /// </summary>
        /// <param name="curriculumID">The ID of the curriculum to be deleted.</param>
        /// <returns>True if the deletion was successful, False otherwise.</returns>
        public static bool Delete(int curriculumID)
        {
            return clsCurriculumData.DeleteCurriculum(curriculumID);
        }

        /// <summary>
        /// Finds a curriculum by its CurriculumID.
        /// </summary>
        /// <param name="curriculumID">The ID of the curriculum to find.</param>
        /// <returns>A clsCurriculum object if found, null otherwise.</returns>
        public static clsCurriculum Find(int curriculumID)
        {
            string curriculumName = "";
            string description = "";
            int educationLevelID = -1;
            DateTime publicationDate = DateTime.MinValue;

            if (clsCurriculumData.GetCurriculumByID(curriculumID, ref curriculumName, ref description, ref educationLevelID, ref publicationDate))
            {
                return new clsCurriculum(curriculumID, curriculumName, description, educationLevelID, publicationDate);
            }
            return null;
        }

        /// <summary>
        /// Finds a curriculum by its CurriculumName.
        /// </summary>
        /// <param name="curriculumName">The name of the curriculum to find.</param>
        /// <returns>A clsCurriculum object if found, null otherwise.</returns>
        public static clsCurriculum Find(string curriculumName)
        {
            int curriculumID = -1;
            string description = "";
            int educationLevelID = -1;
            DateTime publicationDate = DateTime.MinValue;

            if (clsCurriculumData.GetCurriculumByName(curriculumName, ref curriculumID, ref description, ref educationLevelID, ref publicationDate))
            {
                return new clsCurriculum(curriculumID, curriculumName, description, educationLevelID, publicationDate);
            }
            return null;
        }

        /// <summary>
        /// Checks if a curriculum exists by its CurriculumID.
        /// </summary>
        /// <param name="curriculumID">The CurriculumID to check.</param>
        /// <returns>True if the curriculum exists, False otherwise.</returns>
        public static bool IsCurriculumExist(int curriculumID)
        {
            return clsCurriculumData.IsCurriculumExist(curriculumID);
        }

    }
}
