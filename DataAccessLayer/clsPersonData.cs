using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsPersonData
    {
        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();
            string query = @"
select PersonID,FirstName + ' ' + LastName as FullName,BirthDate,
case 
when Gender = 1 Then 'Male'
when Gender = 0 Then 'Female'
else 'Unknown'
end as Gender,
Phone,Email ,Address,NationalID
from People;
";
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


        public static int AddNewPerson(string firstName, string lastName, DateTime dateOfBirth, bool gender, string phone, string email, string address, string nationalID,int CreatedByUserID,string ImagePath)
        {
            int InsertedPersonID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);

            string Query = @"INSERT INTO [dbo].[People]
                ([FirstName],[LastName],[BirthDate],[Gender],[Phone],[Email],[Address],[NationalID],[CreatedByUserID],[ImagePath])
                VALUES
                (@FirstName,@LastName,@BirthDate,@Gender,@Phone,@Email,@Address,@NationalID,@CreatedByUserID,@ImagePath)

                SELECT SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@FirstName", firstName);
            Command.Parameters.AddWithValue("@LastName", lastName);
            Command.Parameters.AddWithValue("@BirthDate", dateOfBirth);
            Command.Parameters.AddWithValue("@Gender", gender);

            if (string.IsNullOrEmpty(phone))
            {
                Command.Parameters.AddWithValue("@Phone", DBNull.Value);
            } else
            {
                Command.Parameters.AddWithValue("@Phone", phone);
            }
            if (string.IsNullOrEmpty(email))
            {
                Command.Parameters.AddWithValue("@Email", DBNull.Value);
            } else
            {
                Command.Parameters.AddWithValue("@Email", email);
            }


            Command.Parameters.AddWithValue("@Address", address);
            Command.Parameters.AddWithValue("@NationalID", nationalID);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            try
            {
                Connection.Open();

                object results = Command.ExecuteScalar();


                if (results != null && int.TryParse(results.ToString(), out int insertidID))
                {
                    InsertedPersonID = insertidID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }

            return InsertedPersonID;
        }

        public static bool UpdatePerson(int personID, string firstName, string lastName, DateTime dateOfBirth, bool gender, string phone, string email, string address, string nationalID, int CreatedByUserID,string ImagePath)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);

            string Query = @"UPDATE PeopleSET FirstName=@FirstName,LastName=@LastName,
BirthDate=@BirthDate,Gender= @Gender,Phone=@Phone,Email=@Email,Address=@Address,NationalID=@NationalID,CreatedByUserID=@CreatedByUserID,ImagePath = @ImagePath
        WHEREPersonID=@personID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@personID", personID);
            Command.Parameters.AddWithValue("@FirstName", firstName);
            Command.Parameters.AddWithValue("@LastName", lastName);
            Command.Parameters.AddWithValue("@BirthDate", dateOfBirth);
            Command.Parameters.AddWithValue("@Gender", gender);

            if (string.IsNullOrEmpty(phone))
            {
                Command.Parameters.AddWithValue("@Phone", DBNull.Value);
            } else
            {
                Command.Parameters.AddWithValue("@Phone", phone);
            }
            if (string.IsNullOrEmpty(email))
            {
                Command.Parameters.AddWithValue("@Email", DBNull.Value);
            } else
            {
                Command.Parameters.AddWithValue("@Email", email);
            }


            Command.Parameters.AddWithValue("@Address", address);
            Command.Parameters.AddWithValue("@NationalID", nationalID);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            try
            {
                Connection.Open();

                RowsAffected = Command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }

            return RowsAffected > 0;
        }

        public static bool DeletePerson(int personID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            string Query = @"DELETE FROM People WHERE PersonID = @personID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@personID", personID);
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

        public static bool GetPersonByNationalID(string nationalID , ref int personID, ref string firstName, ref string lastName, ref DateTime dateOfBirth,
            ref bool gender, ref string phone, ref string email, ref string address, ref int CreatedByUserID, ref string ImagePath)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            string Query = @"SELECT * FROM People WHERE NationalID = @nationalID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NationalID", nationalID);
            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    IsFound = true;
                    personID = Convert.ToInt32(reader["personID"]);

                    firstName = reader["FirstName"].ToString();
                    lastName = reader["LastName"].ToString();
                    dateOfBirth = Convert.ToDateTime(reader["BirthDate"]);
                    gender = Convert.ToBoolean(reader["Gender"]);
                    phone = reader["Phone"].ToString();
                    email = reader["Email"].ToString();
                    address = reader["Address"].ToString();
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    ImagePath = reader["ImagePath"].ToString(); 
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
        public static bool GetPersonByID(int personID, ref string firstName, ref string lastName, ref DateTime dateOfBirth,
            ref bool gender, ref string phone, ref string email, ref string address, ref string nationalID, ref int CreatedByUserID, ref string ImagePath)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            string Query = @"SELECT * FROM People WHERE PersonID = @personID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@personID", personID);
            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    IsFound = true;
                    firstName = reader["FirstName"].ToString();
                    lastName = reader["LastName"].ToString();
                    dateOfBirth = Convert.ToDateTime(reader["BirthDate"]);
                    gender = Convert.ToBoolean(reader["Gender"]);
                    phone = reader["Phone"].ToString(); 
                    address = reader["Address"].ToString();
                    nationalID = reader["NationalID"].ToString();
                    email = reader["email"].ToString();
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    ImagePath = reader["ImagePath"].ToString();
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
        public static bool GetPersonByEmail( string email, ref int personID, ref string firstName, ref string lastName,
            ref DateTime dateOfBirth, ref bool gender, ref string phone, ref string address, ref string nationalID, ref int CreatedByUserID, ref string ImagePath)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            string Query = @"SELECT * FROM People WHERE Email = @email";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@email", email);
            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    IsFound = true;
                    personID = Convert.ToInt32(reader["PersonID"]);
                    firstName = reader["FirstName"].ToString();
                    lastName = reader["LastName"].ToString();
                    dateOfBirth = Convert.ToDateTime(reader["BirthDate"]);
                    gender = Convert.ToBoolean(reader["Gender"]);
                    phone = reader["Phone"].ToString();
                    email = reader["Email"].ToString();
                    address = reader["Address"].ToString();
                    nationalID = reader["NationalID"].ToString();
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    ImagePath = reader["ImagePath"].ToString();
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


        public static bool IsPersonExist(int PersonID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            string Query = @"SELECT Found = 1 FROM People WHERE PersonID = @PersonID";
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

        public static bool IsPersonExist(string Email)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            string Query = @"SELECT Found = 1 FROM People WHERE Email = @Email";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Email", Email);
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
        
        public static bool IsPersonExistByNationalID(string NationalID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            string Query = @"SELECT Found = 1 FROM People WHERE NationalID = @NationalID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NationalID", NationalID);
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
