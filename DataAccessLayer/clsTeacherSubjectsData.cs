using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsTeacherSubjectsData
    {




        public static bool AssignSubjectToTeacher(int TeacherID, int SubjectID)
        {
            bool isAddedSuccessfully = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);

            string Query = @"INSERT INTO TeacherSubjects ([TeacherID], [SubjectID]) VALUES (@TeacherID, @SubjectID);";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@TeacherID", TeacherID);
            Command.Parameters.AddWithValue("@SubjectID", SubjectID);

            try
            {
                Connection.Open();
                int rowsAffected = Command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    isAddedSuccessfully = true;
                }
            }
            catch (Exception ex)
            {
                // Log or handle exception  
            }
            finally
            {
                Connection.Close();
            }

            return isAddedSuccessfully;
        }

        public static bool RemoveSubjectFromTeacher(int TeacherID, int SubjectID)
        {
            bool isRemovedSuccessfully = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);

            string Query = @"DELETE FROM TeacherSubjects WHERE TeacherID = @TeacherID And SubjectID = @SubjectID;";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@TeacherID", TeacherID);
            Command.Parameters.AddWithValue("@SubjectID", SubjectID);

            try
            {
                Connection.Open();
                int rowsAffected = Command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    isRemovedSuccessfully = true;
                }
            }
            catch (Exception ex)
            {
                // Log or handle exception  
            }
            finally
            {
                Connection.Close();
            }

            return isRemovedSuccessfully;
        }

        public static DataTable GetTeacherSubjects(int TeacherID)
        {
            DataTable dt = new DataTable();
            string query = @"  select ts.TeacherID ,s.* from Subjects as s
                 inner join TeacherSubjects as ts
                 on s.SubjectID = ts.SubjectID
                 where TeacherID =  @TeacherID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TeacherID", TeacherID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    dt.Load(reader);
                }
                catch (Exception ex)
                {
                    // Handle exception
                }
            }

            return dt;
        }

        public static DataTable GetSubjectTeachers(int SubjectID)
        {
            DataTable dt = new DataTable();
            string query = @"  
                  select ts.SubjectID ,t.* from Teachers as t
                 inner join TeacherSubjects as ts
                 on t.TeacherID = ts.TeacherID
                 where SubjectID =  @SubjectID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SubjectID", SubjectID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    dt.Load(reader);
                }
                catch (Exception ex)
                {
                    // Handle exception
                }
            }

            return dt;
        }

        public static bool IsTeacherAlreadyStudyingSubject(int TeacherID, int SubjectID)
        {
            bool IsAlreadyStudying = false;
            string query = @"SELECT IsAlreadyStudying = 1 FROM TeacherSubjects WHERE SubjectID = @SubjectID and TeacherID = @TeacherID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@SubjectID", SubjectID);
                command.Parameters.AddWithValue("@TeacherID", TeacherID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    IsAlreadyStudying = reader.HasRows;
                }
                catch (Exception ex)
                {
                    // Log or handle exception
                }
            }

            return IsAlreadyStudying;
        }
        public static bool IsTeachingAnySubject(int TeacherID)
        {
            bool IsStudying = false;

            // Check if the teacher is already studying any subject
            string query = @"SELECT IsStudying = 1 FROM TeacherSubjects WHERE  TeacherID = @TeacherID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TeacherID", TeacherID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    IsStudying = reader.HasRows;
                }
                catch (Exception ex)
                {
                    // Log or handle exception
                }
            }

            return IsStudying;
        }

    }
}
