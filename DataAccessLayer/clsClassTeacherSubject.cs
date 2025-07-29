using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsClassTeacherSubjectData
    {

        bool IsTeacherTeachingSubjectToClass(int teacherId, int subjectId, int classId)
        {
            string query = @"  select IsTeaching = 1  from ClassTeacherSubject 
                where ClassID = @ClassID 
                and TeacherID = @TeacherID
                and SubjectID = @SubjectID;";
            bool IsTeaching = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TeacherID", teacherId);
                command.Parameters.AddWithValue("@SubjectID", subjectId);
                command.Parameters.AddWithValue("@ClassID", classId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        IsTeaching = true;
                    }
                }
                catch (Exception ex)
                {
                    return IsTeaching;
                }
            }

            return IsTeaching;
        }


        public static bool AddTeacherToClassWithSubject(int teacherId, int subjectId, int classId,string Description)
        {
            int rowsAffected = -1;
            string query = @"
                    INSERT INTO ClassTeacherSubject
                   (ClassID
                   ,TeacherID
                   ,SubjectID
                   ,Description)
             VALUES
                   (@ClassID
                   ,@TeacherID
                   ,@SubjectID
                   ,@Description);
        ";

            using (SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection); 
                command.Parameters.AddWithValue("@TeacherID", teacherId);
                command.Parameters.AddWithValue("@SubjectID", subjectId);
                command.Parameters.AddWithValue("@ClassID", classId);
                command.Parameters.AddWithValue("@Description", Description);

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                     
                }
                catch (Exception ex)
                {
                    // Handle exception
                }
            }

            return rowsAffected > 0;
        }

        public static bool UpdateTeacher(int teacherId, int subjectId, int classId, string Description)
        {
            string query = @"
            UPDATE Teachers 
            SET PersonID = @PersonID,
                Salary = @Salary,
                YearsOfExperience = @YearsOfExperience,
                IsActive = @IsActive
            WHERE TeacherID = @TeacherID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TeacherID", teacherId);
                command.Parameters.AddWithValue("@SubjectID", subjectId);
                command.Parameters.AddWithValue("@ClassID", classId);

                try
                {
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    // Handle exception
                    return false;
                }
            }
        }

        public static int GetTeacherIdBySectionAndSubject( int classId, int subjectId)
        {
            string query = @"
                SELECT T.TEACHERID FROM CLASSTEACHERSUBJECT CTS
                INNER JOIN TEACHERS T ON T.TEACHERID = CTS.TEACHERID
                INNER JOIN PEOPLE P ON P.PERSONID = T.PERSONID
                WHERE CTS.CLASSID = @ClassID AND CTS.SUBJECTID =@SubjectID;
                ;";
            int _TEACHERID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection); 
                command.Parameters.AddWithValue("@SubjectID", subjectId);
                command.Parameters.AddWithValue("@ClassID", classId);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int TeacherID))
                    {
                        _TEACHERID = TeacherID;
                    }
                }
                catch (Exception ex)
                {
                    return _TEACHERID;
                }
            }

            return _TEACHERID;
        }


    }
}
