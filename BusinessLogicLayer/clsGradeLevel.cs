using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessLogicLayer
{
    public class clsGradeLevel
    {
        public enum enMode { Add, Update }
        private enMode _Mode;

        public int GradeLevelID { get; set; }
        public int CurriculumID { get; set; }
        public string GradeLevelName { get; set; }
        public int BooksCount { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public clsCurriculum Curriculum;

        public clsGradeLevel()
        {
            _Mode = enMode.Add;
            GradeLevelID = -1;
            CurriculumID = -1;
            GradeLevelName = string.Empty;
            BooksCount = -1;
            MinAge = -1;
            MaxAge = -1;
            Curriculum = null;
        }

        private clsGradeLevel(int gradeLevelID, int curriculumID, string gradeLevelName, int booksCount, int minAge, int maxAge)
        {
            _Mode = enMode.Update;
            GradeLevelID = gradeLevelID;
            CurriculumID = curriculumID;
            GradeLevelName = gradeLevelName;
            BooksCount = booksCount;
            MinAge = minAge;
            MaxAge = maxAge;
            Curriculum = clsCurriculum.Find(curriculumID);
        }

        public static DataTable GetAllGradeLevels()
        {
            return clsGradeLevelData.GetAllGradeLevels();
        }        
        
        public static List<clsSubject> GetGradeLevelsSubject(int GradeLevelID )
        {  
            return clsGradeLevelData.GetGradeLevelsSubject(GradeLevelID).ToList<clsSubject>();
        }
         
        // generate  find method 
        public static clsGradeLevel Find(int gradeLevelID)
        {
            int CurriculumID = -1;
            string GradeLevelName = "";
            int BooksCount = -1;
            int MinAge = -1;
            int MaxAge = -1;
            if (clsGradeLevelData.GetGradeLevelByID(gradeLevelID, ref CurriculumID, ref GradeLevelName, ref BooksCount, ref MinAge, ref MaxAge))
            {
                return new clsGradeLevel(gradeLevelID, CurriculumID, GradeLevelName, BooksCount, MinAge, MaxAge);
            }
            return null;
        }


        public bool isValidAge(int age)
        {
            return age >= MinAge && age <= MaxAge;
        }
         

        
    }
}
