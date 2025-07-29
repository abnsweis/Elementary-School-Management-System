using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsTeacherData
    {
        private static readonly string ConnectionString = clsDataAccessLayerSettings.ConnectionString;

        public static int AddTeacher(int personID, DateTime hireDate, decimal salary, int yearsOfExperience, bool isActive, DateTime? terminationDate)
        {
            int newID = -1;
            string query = @"
            INSERT INTO Teachers (PersonID, HireDate, Salary, YearsOfExperience, IsActive, TerminationDate)
            VALUES (@PersonID, @HireDate, @Salary, @YearsOfExperience, @IsActive, @TerminationDate);
            SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PersonID", personID);
                command.Parameters.AddWithValue("@HireDate", hireDate);
                command.Parameters.AddWithValue("@Salary", salary);
                command.Parameters.AddWithValue("@YearsOfExperience", yearsOfExperience);
                command.Parameters.AddWithValue("@IsActive", isActive);
                command.Parameters.AddWithValue("@TerminationDate", (object)terminationDate ?? DBNull.Value);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        newID = insertedID;
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception
                }
            }

            return newID;
        }

        public static bool UpdateTeacher(int teacherID, int personID, decimal salary, int yearsOfExperience, bool isActive)
        {
            string query = @"
            UPDATE Teachers 
            SET PersonID = @PersonID,
                Salary = @Salary,
                YearsOfExperience = @YearsOfExperience,
                IsActive = @IsActive
            WHERE TeacherID = @TeacherID;";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TeacherID", teacherID);
                command.Parameters.AddWithValue("@PersonID", personID); 
                command.Parameters.AddWithValue("@Salary", salary);
                command.Parameters.AddWithValue("@YearsOfExperience", yearsOfExperience);
                command.Parameters.AddWithValue("@IsActive", isActive); 

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

        public static bool DeleteTeacher(int teacherID)
        {
            

            string query = @"DELETE FROM Teachers WHERE TeacherID = @TeacherID";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TeacherID", teacherID);
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
            finally
            {
                connection.Close();
            }
        }

        public static bool GetTeacherByID(int teacherID, ref int personID, ref DateTime hireDate, ref decimal salary, ref int yearsOfExperience, ref bool isActive, ref DateTime? terminationDate)
        {
            string query = @"SELECT * FROM Teachers WHERE TeacherID = @TeacherID";
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TeacherID", teacherID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        personID = Convert.ToInt32(reader["PersonID"]);
                        hireDate = Convert.ToDateTime(reader["HireDate"]);
                        salary = Convert.ToDecimal(reader["Salary"]);
                        yearsOfExperience = Convert.ToInt32(reader["YearsOfExperience"]);
                        isActive = Convert.ToBoolean(reader["IsActive"]);
                        terminationDate = reader["TerminationDate"] != DBNull.Value ? Convert.ToDateTime(reader["TerminationDate"]) : (DateTime?)null;
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception
                }
            }

            return isFound;
        }
        public static bool GetTeacherByPersonID(int PersonID, ref int teacherID, ref DateTime hireDate, ref decimal salary, ref int yearsOfExperience, ref bool isActive, ref DateTime? terminationDate)
        {
            string query = @"SELECT * FROM Teachers WHERE PersonID = @PersonID";
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PersonID", PersonID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        teacherID = Convert.ToInt32(reader["teacherID"]);
                        hireDate = Convert.ToDateTime(reader["HireDate"]);
                        salary = Convert.ToDecimal(reader["Salary"]);
                        yearsOfExperience = Convert.ToInt32(reader["YearsOfExperience"]);
                        isActive = Convert.ToBoolean(reader["IsActive"]);
                        terminationDate = reader["TerminationDate"] != DBNull.Value ? Convert.ToDateTime(reader["TerminationDate"]) : (DateTime?)null;
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception
                }
            }

            return isFound;
        }

        public static DataTable GetAllTeachers()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Teachers_View";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
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
        public static int GetTeachersCounts(bool? Active)
        {
            int TeacherCount = 0;
            string query = @" select Count(*) as TeachersCount from Teachers";



            if (Active != null)
            {
                query += " where IsActive = @IsActive";
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                if (Active != null)
                {
                    command.Parameters.AddWithValue("@IsActive", Active);
                }
                try
                {
                    connection.Open();
                    object results = command.ExecuteScalar();
                    if (results != null && int.TryParse(results.ToString(), out int Count))
                    {
                        TeacherCount = Count;
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception
                }
            }

            return TeacherCount;
        }
        public static decimal GetTotalSalary()
        {
            decimal TotalSalary = 0;
            string query = @"select SUM(Teachers.Salary) as TotalSalary  from Teachers;
";


 

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                
                try
                {
                    connection.Open();
                    object results = command.ExecuteScalar();
                    if (results != null && decimal.TryParse(results.ToString(), out decimal Total))
                    {
                        TotalSalary = Total;
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception
                }
            }

            return TotalSalary;
        }
        public static bool IsTeacherExist(int teacherID)
        {
            string query = "SELECT 1 FROM Teachers WHERE TeacherID = @TeacherID";
            bool exists = false;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TeacherID", teacherID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        exists = true;
                    }
                }
                catch (Exception ex)
                {
                    return exists;
                }
            }

            return exists;
        }
        public static bool isTeacherActive(int teacherID)
        {
            string query = "SELECT IsActive=1 FROM Teachers WHERE TeacherID = @TeacherID And IsActive = 1";
            bool exists = false;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TeacherID", teacherID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        exists = true;
                    }
                }
                catch (Exception ex)
                {
                    return exists;
                }
            }

            return exists;
        }

        public static bool UpdateTeacherStatus(int teacherID, bool isActive)
        {
            string query = "UPDATE Teachers SET IsActive = @IsActive WHERE TeacherID = @TeacherID";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TeacherID", teacherID);
                command.Parameters.AddWithValue("@IsActive", isActive);
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
        public static bool IsThePersonTeacher(int PersonID)
        {
            string query = "SELECT IsTeacher = 1 FROM Teachers WHERE PersonID = @PersonID";
            bool exists = false;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PersonID", PersonID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        exists = true;
                    }
                }
                catch (Exception ex)
                {
                    return exists;
                }
            }

            return exists;
        }
    }
}
