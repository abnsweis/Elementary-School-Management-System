using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsStudentData
    {

        public static DataTable GetAllStudents()
        {
            DataTable dt = new DataTable();
            string query = @" select * from Students_view;";
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            SqlCommand Command = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                Connection.Close();
            }
            return dt;
        }
        // Add New Student In to Database
        public static int AddNewStudent(int PersonID, int ParentsID, short Status, DateTime AdmissionDate, DateTime LastUpdateStatus, string Notes,int CreatedByUserID)
        {
            int insertedStudentID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);  

            string query = @"
        INSERT INTO Students (
            PersonID,
            ParentsID, 
            Status, 
            AdmissionDate, 
            Notes,
            CreatedByUserID
)
        VALUES (@PersonID, @ParentsID,  @Status, @AdmissionDate, @Notes,@CreatedByUserID);
        SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@ParentsID", ParentsID); 
            command.Parameters.AddWithValue("@Status", Status); 
            command.Parameters.AddWithValue("@AdmissionDate", AdmissionDate);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            if (string.IsNullOrEmpty(Notes))
            {
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            } else
            {
                command.Parameters.AddWithValue("@Notes", Notes);
            }

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    insertedStudentID = insertedID;
                }
            }
            catch (Exception ex)
            {
                 
            }
            finally
            {
                connection.Close();
            }

            return insertedStudentID;
        }
        // Update Student Info
        public static bool UpdateStudent(int StudentID, int PersonID, int ParentsID, short Status, DateTime AdmissionDate, DateTime LastUpdateStatus, string Notes, int CreatedByUserID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);  

            string query = @"
        UPDATE Students
        SET PersonID = @PersonID,
            ParentsID = @ParentsID,
            Status = @Status,
            AdmissionDate = @AdmissionDate,
            Notes = @Notes,
            CreatedByUserID = @CreatedByUserID
        WHERE StudentID = @StudentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@StudentID", StudentID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@ParentsID", ParentsID);
            command.Parameters.AddWithValue("@Status", Status);  
            command.Parameters.AddWithValue("@AdmissionDate", AdmissionDate);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                 
            }
            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }

        public static bool UpdateStudentStatus(int StudentID, short Status)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);

            string query = @" UPDATE Students
        SET  
            Status = @Status,
            LastUpdateStatus = @LastUpdateStatus
             
        WHERE StudentID = @StudentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@StudentID", StudentID); 
            command.Parameters.AddWithValue("@Status", Status); 
            command.Parameters.AddWithValue("@LastUpdateStatus", DateTime.Now.Date); 
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }

        // Delete Student
        public static bool DeleteStudent(int StudentID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);  

            string Query = @"DELETE FROM Students WHERE StudentID = @StudentID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@StudentID", StudentID);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                Connection.Close();
            }

            return RowsAffected > 0;
        }

        // Get Student By ID
        public static bool GetStudentByID(int StudentID, ref int PersonID, ref int ParentsID, ref string StudentNumber, ref short Status, ref DateTime AdmissionDate, ref DateTime LastUpdateStatus, ref string Notes,ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString); 

            string Query = @"SELECT * FROM Students WHERE StudentID = @StudentID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@StudentID", StudentID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    IsFound = true;
                    PersonID = Convert.ToInt32(reader["PersonID"]);
                    ParentsID = Convert.ToInt32(reader["ParentsID"]);
                    StudentNumber = reader["StudentNumber"].ToString();
                    Status = Convert.ToInt16(reader["Status"]);  
                    AdmissionDate = Convert.ToDateTime(reader["AdmissionDate"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);

                    if (reader["Notes"] == DBNull.Value)
                    {
                        Notes = "";
                    } else
                    {
                        Notes = reader["Notes"].ToString();
                    }
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
        // Get Student By Student Number
        public static bool GetStudentByStudentNumber(string StudentNumber, ref int StudentID, ref int PersonID, ref int ParentsID, ref short Status, ref DateTime AdmissionDate, ref DateTime LastUpdateStatus, ref string Notes,ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);  

            string Query = @"SELECT * FROM Students WHERE StudentNumber = @StudentNumber";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@StudentNumber", StudentNumber);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    IsFound = true;
                    StudentID = Convert.ToInt32(reader["StudentID"]);
                    PersonID = Convert.ToInt32(reader["PersonID"]);
                    ParentsID = Convert.ToInt32(reader["ParentsID"]);
                    Status = Convert.ToInt16(reader["Status"]);
                    AdmissionDate = Convert.ToDateTime(reader["AdmissionDate"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    if (reader["Notes"] == DBNull.Value)
                    {
                        Notes = "";
                    } else
                    {
                        Notes = reader["Notes"].ToString();
                    }
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
        // Get Student By Person ID
        public static bool GetStudentByPersonID(int PersonID, ref int StudentID, ref int ParentsID, ref string StudentNumber, ref short Status, ref DateTime AdmissionDate, ref DateTime LastUpdateStatus, ref string Notes, ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);  

            string Query = @"SELECT * FROM Students WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    IsFound = true;
                    StudentID = Convert.ToInt32(reader["StudentID"]);
                    ParentsID = Convert.ToInt32(reader["ParentsID"]);
                    StudentNumber = reader["StudentNumber"].ToString();
                    Status = Convert.ToInt16(reader["Status"]);
                    AdmissionDate = Convert.ToDateTime(reader["AdmissionDate"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    if (reader["Notes"] == DBNull.Value)
                    {
                        Notes = "";
                    } else
                    {
                        Notes = reader["Notes"].ToString();
                    }
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



        public static bool IsStudentExistByStudentID(int StudentID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);  

            string Query = @"SELECT Found = 1 FROM Students WHERE StudentID = @StudentID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@StudentID", StudentID);

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

        public static bool IsStudentExistByPersonID(int PersonID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);  

            string Query = @"SELECT Found = 1 FROM Students WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static bool IsStudentExistByStudentNumber(string StudentNumber)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);  

            string Query = @"SELECT Found = 1 FROM Students WHERE StudentNumber = @StudentNumber";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@StudentNumber", StudentNumber);

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

        public static bool IsPersonAlreadyStudent(int PersonID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);  

            string Query = @"SELECT Found = 1 FROM Students WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

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
