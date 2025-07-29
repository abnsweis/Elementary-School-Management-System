using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsSubjectData
    {
        public static bool GetSubjectByID(int subjectID,
            ref string subjectName,
            ref byte maxMarks,
            ref byte passingMarks,
            ref string description)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            SqlCommand command = new SqlCommand("select  * from Subjects where SubjectID = @SubjectID;", connection);
         
            command.Parameters.AddWithValue("@SubjectID", subjectID);

            SqlDataReader reader;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    subjectName = (string)reader["SubjectName"];
                    maxMarks = (byte)reader["MaxMarks"];
                    passingMarks = (byte)reader["PassingMarks"];
                    description = (reader["Description"] != DBNull.Value) ? (string)reader["Description"] : "";

                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // ممكن تسجل الخطأ أو تعالجه حسب مشروعك
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }        
        
        
        
        public static bool GetSubjectByName(string subjectName,
            ref int subjectID,
            ref byte maxMarks,
            ref byte passingMarks,
            ref string description)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            SqlCommand command = new SqlCommand("select  * from Subjects where SubjectName = @subjectName;", connection);
            
            command.Parameters.AddWithValue("@subjectName", subjectName);

            SqlDataReader reader;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    subjectID = (int)reader["SubjectID"];
                    maxMarks = (byte)reader["MaxMarks"];
                    passingMarks = (byte)reader["PassingMarks"];
                    description = (reader["Description"] != DBNull.Value) ? (string)reader["Description"] : "";

                }

                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }



        public static int AddNewSubject(string subjectName, int maxMarks, int passingMarks, string description)
        {
            int insertedID = -1;
            string query = @"INSERT INTO [dbo].[Subjects]([SubjectName],[MaxMarks],[PassingMarks],[Description]) VALUES VALUES (@SubjectName, @MaxMarks, @PassingMarks, @Description);

   SELECT SCOPE_IDENTITY();
";
             SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@SubjectName", subjectName);
            command.Parameters.AddWithValue("@MaxMarks", maxMarks);
            command.Parameters.AddWithValue("@PassingMarks", passingMarks);
            command.Parameters.AddWithValue("@Description", description ?? "");

            

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int newID))
                {
                    insertedID = newID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return insertedID;
        }

        public static bool UpdateSubject(int subjectID, string subjectName, int maxMarks, int passingMarks, string description)
        {
            bool isUpdated = false;

            string query = "UPDATE Subjects SET SubjectName = @SubjectName, MaxMarks = @MaxMarks, PassingMarks = @PassingMarks, Description = @Description WHERE SubjectID = @SubjectID";

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@SubjectID", subjectID);
            command.Parameters.AddWithValue("@SubjectName", subjectName);
            command.Parameters.AddWithValue("@MaxMarks", maxMarks);
            command.Parameters.AddWithValue("@PassingMarks", passingMarks);
            command.Parameters.AddWithValue("@Description", description ?? "");

            try
            {
                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();
                isUpdated = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isUpdated;
        }

        public static bool DeleteSubject(int subjectID)
        {
            string query = @"DELETE FROM Subjects WHERE SubjectID = @SubjectID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@SubjectID", subjectID);

                try
                {
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    // Log or handle exception
                    return false;
                }
            }
        }

        public static DataTable GetAllSubjects()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT * FROM Subjects";

            using (SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    // Log or handle exception
                }
            }

            return dt;
        }

        public static bool IsSubjectExists(int subjectID)
        {
            bool isFound = false;
            string query = @"SELECT 1 FROM Subjects WHERE SubjectID = @SubjectID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@SubjectID", subjectID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    isFound = reader.HasRows;
                }
                catch (Exception ex)
                {
                    // Log or handle exception
                }
            }

            return isFound;
        }
        public static bool IsSubjectExists(string SubjectName)
        {
            bool isFound = false;
            string query = @"SELECT 1 FROM Subjects WHERE SubjectName = @SubjectName";

            using (SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@SubjectName", SubjectName);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    isFound = reader.HasRows;
                }
                catch (Exception ex)
                {
                    // Log or handle exception
                }
            }

            return isFound;
        }
        
    }

}
