using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsParentsData
    {
        public static DataTable GetAllParents()
        {
            DataTable dt = new DataTable();
            string query = @"  select * from Parents_View;";
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

        public static bool GetParentsByID(int ParentsID, ref int FatherID ,ref int MotherID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            string Query = @"SELECT * FROM Parents WHERE ParentsID = @ParentsID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ParentsID", ParentsID);
            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    IsFound = true;
                    FatherID = Convert.ToInt32(reader["FatherID"]);
                    MotherID = Convert.ToInt32(reader["MotherID"]);

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


        public static bool IsParentsExist(int ParentsID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            string Query = @"SELECT Found = 1 FROM Parents WHERE ParentsID = @ParentsID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ParentsID", ParentsID);
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


        public static int AddNewParents(int FatherID,  int MotherID)
        {
            int insertedID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);

            string query = @"INSERT INTO [dbo].[Parents]
                           ([FatherID]
                           ,[MotherID])
                     VALUES
                           (@FatherID
                           ,@MotherID)

                         SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FatherID", FatherID);
            command.Parameters.AddWithValue("@MotherID", MotherID); 

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    insertedID = ID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return insertedID;
        }
    }
}
