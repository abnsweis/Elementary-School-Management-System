using DataAccessLayer;
using System;
using System.Data;

namespace BusinessLogicLayer
{
    public class clsEducationLevel
    {
        public enum enMode { Add, Update }
        private enMode _Mode;

        public int EducationLevelID { get; set; }
        public string EducationLevelName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }

        // Constructor for updating an existing Education Level
        public clsEducationLevel(int educationLevelID, string educationLevelName, DateTime createdDate, string description)
        {
            _Mode = enMode.Update;
            EducationLevelID = educationLevelID;
            EducationLevelName = educationLevelName;
            CreatedDate = createdDate;
            Description = description;
        }

        // Default constructor for adding a new Education Level
        public clsEducationLevel()
        {
            _Mode = enMode.Add;
            EducationLevelID = -1;
            EducationLevelName = string.Empty;
            CreatedDate = DateTime.Now;
            Description = string.Empty;
        }

        // Saves the Education Level (Insert or Update)
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    if (_AddNewEducationLevel())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateEducationLevel();

                default:
                    return false;
            }
        }

        // Retrieves all Education Levels from the database
        public static DataTable GetAllEducationLevels()
        {
            return clsEducationLevelData.GetAllEducationLevels();
        }

        // Private method to add a new Education Level
        private bool _AddNewEducationLevel()
        {
            this.EducationLevelID = clsEducationLevelData.AddNewEducationLevel(EducationLevelName, CreatedDate, Description);
            return this.EducationLevelID > 0;
        }

        // Private method to update an existing Education Level
        private bool _UpdateEducationLevel()
        {
            return clsEducationLevelData.UpdateEducationLevel(this.EducationLevelID, EducationLevelName, CreatedDate, Description);
        }

        // Deletes the current Education Level
        public bool Delete()
        {
            return clsEducationLevelData.DeleteEducationLevel(this.EducationLevelID);
        }

        // Deletes an Education Level by ID
        public static bool Delete(int educationLevelID)
        {
            return clsEducationLevelData.DeleteEducationLevel(educationLevelID);
        }

        // Finds an Education Level by ID
        public static clsEducationLevel Find(string educationLevelName)
        {
            int educationLevelID = -1;
            DateTime createdDate = DateTime.MinValue;
            string description = "";

            if (clsEducationLevelData.GetEducationLevelByName(educationLevelName, ref educationLevelID, ref createdDate, ref description))
            {
                return new clsEducationLevel(educationLevelID, educationLevelName, createdDate, description);
            }
            return null;
        }
        
        // Finds an Education Level by Name
        public static clsEducationLevel Find(int educationLevelID)
        {
            string educationLevelName = "";
            DateTime createdDate = DateTime.MinValue;
            string description = "";

            if (clsEducationLevelData.GetEducationLevelByID(educationLevelID, ref educationLevelName, ref createdDate, ref description))
            {
                return new clsEducationLevel(educationLevelID, educationLevelName, createdDate, description);
            }
            return null;
        }

        /// <summary>
        /// Checks if a Education Level exists by its ID.
        /// </summary>
        /// <param name="curriculumID">The CurriculumID to check.</param>
        /// <returns>True if the curriculum exists, False otherwise.</returns>
        public static bool IsEducationLevelExist(int educationLevelID)
        {
            return clsEducationLevelData.IsEducationLevelExist(educationLevelID);
        }

    }
}
