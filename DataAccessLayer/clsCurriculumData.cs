using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsCurriculumData
    {
        /// <summary>
        /// Retrieves all curriculums from the database.
        /// </summary>
        /// <returns>A DataTable containing all curriculums.</returns>
        public static DataTable GetAllCurriculums()
        {
            DataTable dt = new DataTable();
            string query = @"
SELECT C.CurriculumID , EducationLevels.EducationLevelName,C.CurriculumName,C.PublicationDate,C.Description FROM Curriculums C
inner join EducationLevels on EducationLevels.EducationLevelID = C.EducationLevelID
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

        /// <summary>
        /// Adds a new curriculum to the database.
        /// </summary>
        /// <param name="curriculumName">The name of the curriculum.</param>
        /// <param name="description">The description of the curriculum.</param>
        /// <param name="educationLevelID">The education level ID associated with the curriculum.</param>
        /// <param name="publicationDate">The publication date of the curriculum.</param>
        /// <returns>The ID of the newly inserted curriculum.</returns>
        public static int AddNewCurriculum(string curriculumName, string description, int educationLevelID, DateTime publicationDate)
        {
            int insertedID = -1;
            string query = @"INSERT INTO Curriculums (CurriculumName, Description, EducationLevelID, PublicationDate) 
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

        /// <summary>
        /// Updates an existing curriculum in the database.
        /// </summary>
        /// <param name="curriculumID">The ID of the curriculum to update.</param>
        /// <param name="curriculumName">The new name of the curriculum.</param>
        /// <param name="description">The new description of the curriculum.</param>
        /// <param name="educationLevelID">The new education level ID associated with the curriculum.</param>
        /// <returns>True if the update was successful, otherwise false.</returns>
        public static bool UpdateCurriculum(int curriculumID, string curriculumName, string description, int educationLevelID)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Curriculums 
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

        /// <summary>
        /// Deletes a curriculum from the database.
        /// </summary>
        /// <param name="curriculumID">The ID of the curriculum to delete.</param>
        /// <returns>True if the deletion was successful, otherwise false.</returns>
        public static bool DeleteCurriculum(int curriculumID)
        {
            int rowsAffected = 0;
            string query = "DELETE FROM Curriculums WHERE CurriculumID = @CurriculumID";

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

        /// <summary>
        /// Retrieves a curriculum by its name from the database.
        /// </summary>
        /// <param name="curriculumName">The name of the curriculum to retrieve.</param>
        /// <param name="curriculumID">The ID of the retrieved curriculum.</param>
        /// <param name="description">The description of the retrieved curriculum.</param>
        /// <param name="educationLevelID">The education level ID of the retrieved curriculum.</param>
        /// <param name="publicationDate">The publication date of the retrieved curriculum.</param>
        /// <returns>True if the curriculum was found, otherwise false.</returns>
        public static bool GetCurriculumByName(string curriculumName, ref int curriculumID, ref string description, ref int educationLevelID, ref DateTime publicationDate)
        {
            bool isFound = false;
            string query = "SELECT * FROM Curriculums WHERE curriculumName = @curriculumName";

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

        /// <summary>
        /// Retrieves a curriculum by its ID from the database.
        /// </summary>
        /// <param name="curriculumID">The ID of the curriculum to retrieve.</param>
        /// <param name="curriculumName">The name of the retrieved curriculum.</param>
        /// <param name="description">The description of the retrieved curriculum.</param>
        /// <param name="educationLevelID">The education level ID of the retrieved curriculum.</param>
        /// <param name="publicationDate">The publication date of the retrieved curriculum.</param>
        /// <returns>True if the curriculum was found, otherwise false.</returns>
        public static bool GetCurriculumByID(int curriculumID, ref string curriculumName, ref string description, ref int educationLevelID, ref DateTime publicationDate)
        {
            bool isFound = false;
            string query = "SELECT * FROM Curriculums WHERE CurriculumID = @CurriculumID";

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CurriculumID", curriculumID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    isFound = true;
                    curriculumName = reader["CurriculumName"].ToString();
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
            string Query = @"SELECT Found = 1 FROM Curriculums WHERE curriculumID = @curriculumID";
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
        }

    }
}
