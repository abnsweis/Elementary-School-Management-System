using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsEducationLevelData
    {
        /// <summary>
        /// Retrieves all education levels from the database.
        /// </summary>
        /// <returns>A DataTable containing all education levels.</returns>
        public static DataTable GetAllEducationLevels()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM EducationLevels";
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
        /// Adds a new education level to the database.
        /// </summary>
        /// <param name="educationLevelName">The name of the education level.</param>
        /// <param name="createdDate">The date the education level was created.</param>
        /// <param name="description">The description of the education level.</param>
        /// <returns>The ID of the newly inserted education level.</returns>
        public static int AddNewEducationLevel(string educationLevelName, DateTime createdDate, string description)
        {
            int insertedID = -1;
            string query = @"INSERT INTO EducationLevel (EducationLevelName, CreatedDate, Description) 
                             VALUES (@EducationLevelName, @CreatedDate, @Description);
                             SELECT SCOPE_IDENTITY();";

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@EducationLevelName", educationLevelName);
            command.Parameters.AddWithValue("@CreatedDate", createdDate);
            command.Parameters.AddWithValue("@Description", description);

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
        /// Updates an existing education level in the database.
        /// </summary>
        /// <param name="educationLevelID">The ID of the education level to update.</param>
        /// <param name="educationLevelName">The new name of the education level.</param>
        /// <param name="createdDate">The new creation date of the education level.</param>
        /// <param name="description">The new description of the education level.</param>
        /// <returns>True if the update was successful, otherwise false.</returns>
        public static bool UpdateEducationLevel(int educationLevelID, string educationLevelName, DateTime createdDate, string description)
        {
            int rowsAffected = 0;
            string query = @"UPDATE EducationLevel 
                             SET EducationLevelName = @EducationLevelName, 
                                 CreatedDate = @CreatedDate, 
                                 Description = @Description
                             WHERE EducationLevelID = @EducationLevelID";

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@EducationLevelID", educationLevelID);
            command.Parameters.AddWithValue("@EducationLevelName", educationLevelName);
            command.Parameters.AddWithValue("@CreatedDate", createdDate);
            command.Parameters.AddWithValue("@Description", description);

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
        /// Deletes an education level from the database.
        /// </summary>
        /// <param name="educationLevelID">The ID of the education level to delete.</param>
        /// <returns>True if the deletion was successful, otherwise false.</returns>
        public static bool DeleteEducationLevel(int educationLevelID)
        {
            int rowsAffected = 0;
            string query = "DELETE FROM EducationLevels WHERE EducationLevelID = @EducationLevelID";

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@EducationLevelID", educationLevelID);

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
        /// Retrieves an education level by its ID.
        /// </summary>
        /// <param name="educationLevelID">The ID of the education level to retrieve.</param>
        /// <param name="educationLevelName">The name of the education level.</param>
        /// <param name="createdDate">The creation date of the education level.</param>
        /// <param name="description">The description of the education level.</param>
        /// <returns>True if the education level was found, otherwise false.</returns>
        public static bool GetEducationLevelByID(int educationLevelID, ref string educationLevelName, ref DateTime createdDate, ref string description)
        {
            bool isFound = false;
            string query = "SELECT * FROM EducationLevels WHERE EducationLevelID = @EducationLevelID";

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@EducationLevelID", educationLevelID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    isFound = true;
                    educationLevelName = reader["EducationLevelName"].ToString();
                    createdDate = Convert.ToDateTime(reader["CreatedDate"]);
                    description = reader["Description"].ToString();
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

        public static bool GetEducationLevelByName(string educationLevelName, ref int educationLevelID, ref DateTime createdDate, ref string description)
        {
            bool isFound = false;
            string query = "SELECT * FROM EducationLevels WHERE educationLevelName = @educationLevelName";

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@educationLevelName", educationLevelName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    isFound = true;
                    educationLevelID = Convert.ToInt32( reader["educationLevelID"]);
                    createdDate = Convert.ToDateTime(reader["CreatedDate"]);
                    description = reader["Description"].ToString();
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


        public static bool IsEducationLevelExist(int educationLevelID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            string Query = @"SELECT Found = 1 FROM EducationLevels WHERE educationLevelID = @educationLevelID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@educationLevelID", educationLevelID);
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
