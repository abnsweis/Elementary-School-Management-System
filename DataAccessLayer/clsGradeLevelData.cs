using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccessLayer
{
    public class clsGradeLevelData
    {
         
        public static DataTable GetAllGradeLevels()
        {
            DataTable dt = new DataTable();
            string query = @"
             select gl.GradeLevelID , gl.CurriculumID , gl.GradeLevelName,CurriculumName,gl.BooksCount,gl.MinAge,gl.MaxAge from GradeLevels as gl 
             inner join Curriculums on Curriculums.CurriculumID = gl.CurriculumID;
   ;";
            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
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
                // Handle exception
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static DataTable GetGradeLevelsSubject(int GradeLevelID)
        {
            DataTable dt = new DataTable();
            string query = @"select  s.* from CurriculumsSubjects cs
                inner join GradeLevels gl on gl.CurriculumID = cs.CurriculumID
                inner join Subjects s on s.SubjectID = cs.SubjectID 
                where GradeLevelID = @GradeLevelID;";



            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@GradeLevelID", GradeLevelID);
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
                // Handle exception
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

    
        public static bool GetGradeLevelByID(int gradeLevelID, ref int CurriculumID, ref string GradeLevelName, ref int BooksCount, ref int MinAge, ref int MaxAge)
        {
            bool isFound = false;
            string query = @"SELECT * FROM GradeLevels WHERE GradeLevelID = @GradeLevelID;";
            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@GradeLevelID", gradeLevelID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    isFound = true;
                    reader.Read();
                    CurriculumID = Convert.ToInt32(reader["CurriculumID"]);
                    GradeLevelName = reader["GradeLevelName"].ToString();
                    BooksCount = Convert.ToInt32(reader["BooksCount"]); 
                    MinAge = Convert.ToInt32(reader["MinAge"]);
                    MaxAge = Convert.ToInt32(reader["MaxAge"]);
                }
            }
            catch (Exception ex)
            {
                // Handle exception
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }


        /*      public static int AddNewGradeLevels(string curriculumName, string description, int educationLevelID, DateTime publicationDate)
              {
                  int insertedID = -1;
                  string query = @"INSERT INTO GradeLevels (CurriculumName, Description, EducationLevelID, PublicationDate) 
                                   VALUES (@CurriculumName, @Description, @EducationLevelID, @PublicationDate);
                                   SELECT SCOPE_IDENTITY();";

                  SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
                  SqlCommand command = new SqlCommand(query, connection);
                  command.Parameters.AddWithValue("@CurriculumName", curriculumName);
                  command.Parameters.AddWithValue("@Description", description);
                  command.Parameters.AddWithValue("@EducationLevelID", educationLevelID);
                  command.Parameters.AddWithValue("@PublicationDate", publicationDate);

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
                      // Handle exception
                  }
                  finally
                  {
                      connection.Close();
                  }
                  return insertedID;
              }


              public static bool UpdateCurriculum(int curriculumID, string curriculumName, string description, int educationLevelID)
              {
                  int rowsAffected = 0;
                  string query = @"UPDATE GradeLevels 
                                   SET CurriculumName = @CurriculumName, 
                                       Description = @Description, 
                                       EducationLevelID = @EducationLevelID

                                   WHERE CurriculumID = @CurriculumID";

                  SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
                  SqlCommand command = new SqlCommand(query, connection);
                  command.Parameters.AddWithValue("@CurriculumID", curriculumID);
                  command.Parameters.AddWithValue("@CurriculumName", curriculumName);
                  command.Parameters.AddWithValue("@Description", description);
                  command.Parameters.AddWithValue("@EducationLevelID", educationLevelID);

                  try
                  {
                      connection.Open();
                      rowsAffected = command.ExecuteNonQuery();
                  }
                  catch (Exception ex)
                  {
                      // Handle exception
                  }
                  finally
                  {
                      connection.Close();
                  }
                  return rowsAffected > 0;
              }


              public static bool DeleteCurriculum(int curriculumID)
              {
                  int rowsAffected = 0;
                  string query = "DELETE FROM GradeLevels WHERE CurriculumID = @CurriculumID";

                  SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
                  SqlCommand command = new SqlCommand(query, connection);
                  command.Parameters.AddWithValue("@CurriculumID", curriculumID);

                  try
                  {
                      connection.Open();
                      rowsAffected = command.ExecuteNonQuery();
                  }
                  catch (Exception ex)
                  {
                      return false;
                  }
                  finally
                  {
                      connection.Close();
                  }
                  return rowsAffected > 0;
              }


              public static bool GetCurriculumByName(string curriculumName, ref int curriculumID, ref string description, ref int educationLevelID, ref DateTime publicationDate)
              {
                  bool isFound = false;
                  string query = "SELECT * FROM GradeLevels WHERE curriculumName = @curriculumName";

                  SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
                  SqlCommand command = new SqlCommand(query, connection);
                  command.Parameters.AddWithValue("@curriculumName", curriculumName);
                  try
                  {
                      connection.Open();
                      SqlDataReader reader = command.ExecuteReader();
                      if (reader.HasRows)
                      {
                          reader.Read();
                          isFound = true;
                          curriculumID = Convert.ToInt32(reader["curriculumID"]);
                          description = reader["Description"].ToString();
                          educationLevelID = Convert.ToInt32(reader["EducationLevelID"]);
                          publicationDate = Convert.ToDateTime(reader["PublicationDate"]);
                      }
                  }
                  catch (Exception ex)
                  {
                      return isFound;
                  }
                  finally
                  {
                      connection.Close();
                  }
                  return isFound;
              }





              public static bool IsCurriculumExist(int curriculumID)
              {
                  bool IsFound = false;
                  SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
                  string Query = @"SELECT Found = 1 FROM GradeLevels WHERE curriculumID = @curriculumID";
                  SqlCommand Command = new SqlCommand(Query, Connection);
                  Command.Parameters.AddWithValue("@curriculumID", curriculumID);
                  try
                  {
                      Connection.Open();
                      SqlDataReader reader = Command.ExecuteReader();
                      if (reader.HasRows)
                      {
                          IsFound = true;
                      }
                  }
                  catch (Exception ex)
                  {
                      return IsFound;
                  }
                  finally
                  {
                      Connection.Close();
                  }
                  return IsFound;
              }*/

    }
}
