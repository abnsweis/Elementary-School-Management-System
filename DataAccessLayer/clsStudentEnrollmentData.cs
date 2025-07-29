using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsStudentEnrollmentData
    {
        public static DataTable GetAllStudentEnrollments()
        {
            DataTable dt = new DataTable();
            string query = @"select * from StudentEnrollment_View;";
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

        public static int AddNewStudentEnrollment(int classID, int studentID, short status, DateTime enrollmentDate, DateTime? exitDate, bool isRepeating, string notes, string exitReason)
        {
            int insertedID = -1;

            string query = @"
        INSERT INTO StudentsEnrollment 
        (ClassID, StudentID, Status, EnrollmentDate, ExitDate, IsRepeating, Notes, ExitReason)
        VALUES 
        (@ClassID, @StudentID, @Status, @EnrollmentDate, @ExitDate, @IsRepeating, @Notes, @ExitReason);

        SELECT SCOPE_IDENTITY();";

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection); ;

            try
            { 
                command.Parameters.AddWithValue("@ClassID", classID);
                command.Parameters.AddWithValue("@StudentID", studentID);
                command.Parameters.AddWithValue("@Status", status);
                command.Parameters.AddWithValue("@EnrollmentDate", enrollmentDate);


                if (exitDate == null || exitDate == DateTime.MinValue)
                    command.Parameters.AddWithValue("@ExitDate", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@ExitDate", exitDate);

                command.Parameters.AddWithValue("@IsRepeating", isRepeating);
                command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(notes) ? DBNull.Value : (object)notes);
                command.Parameters.AddWithValue("@ExitReason", string.IsNullOrEmpty(exitReason) ? DBNull.Value : (object)exitReason);

                 
                connection.Open();
                object result = command.ExecuteScalar();

                 
                if (result != null && int.TryParse(result.ToString(), out int newID))
                {
                    insertedID = newID;
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

        public static bool UpdateStudentEnrollment(int studentEnrollmentID, int classID, int studentID, short status, DateTime enrollmentDate, DateTime? exitDate, bool isRepeating, string notes, string exitReason)
        {
            int rowsAffected = 0;
            string query = @"
        UPDATE StudentsEnrollment 
        SET ClassID = @ClassID, 
            StudentID = @StudentID, 
            Status = @Status, 
            EnrollmentDate = @EnrollmentDate, 
            ExitDate = @ExitDate, 
            IsRepeating = @IsRepeating, 
            Notes = @Notes, 
            ExitReason = @ExitReason 
        WHERE StudentEnrollmentID = @StudentEnrollmentID";

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                
                command.Parameters.AddWithValue("@StudentEnrollmentID", studentEnrollmentID);
                command.Parameters.AddWithValue("@ClassID", classID);
                command.Parameters.AddWithValue("@StudentID", studentID);
                command.Parameters.AddWithValue("@Status", status);
                command.Parameters.AddWithValue("@EnrollmentDate", enrollmentDate);


                if (exitDate == null || exitDate == DateTime.MinValue)
                    command.Parameters.AddWithValue("@ExitDate", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@ExitDate", exitDate);

                command.Parameters.AddWithValue("@IsRepeating", isRepeating);
                command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(notes) ? DBNull.Value : (object)notes);
                command.Parameters.AddWithValue("@ExitReason", string.IsNullOrEmpty(exitReason) ? DBNull.Value : (object)exitReason);

                
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

                 
                
            }
            catch (Exception ex)
            {
                // معالجة الاستثناءات (يمكن تسجيل الخطأ أو إعادة رميه)
                return false;
            }
            finally
            {
                // إغلاق الاتصال
                connection.Close();
            }
            return rowsAffected > 0;
        }

        public static bool DeleteStudentEnrollment(int studentEnrollmentID)
        {
            string query = @"
        DELETE FROM StudentsEnrollment 
        WHERE StudentEnrollmentID = @StudentEnrollmentID";

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                
                command.Parameters.AddWithValue("@StudentEnrollmentID", studentEnrollmentID);

                
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                 
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                 
                return false;
            }
            finally
            {
                // إغلاق الاتصال
                connection.Close();
            }
        }

        public static bool IsStudentEnrollmentExist(int StudentEnrollmentID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            string Query = @"SELECT Found = 1 From StudentsEnrollment WHERE StudentEnrollmentID = @StudentEnrollmentID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@StudentEnrollmentID", StudentEnrollmentID);
            try
            {
                Connection.Open();
                object results = Command.ExecuteScalar();
                if (results != null)
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


        public static bool GetStudentEnrollmentByID(int studentEnrollmentID, ref int classID, ref int studentID, ref short status, ref DateTime enrollmentDate, ref DateTime? exitDate, ref bool isRepeating, ref string notes, ref string exitReason)
        {
            bool IsFound = false;
            DataTable dt = new DataTable();
            string query = @"
        SELECT ClassID, StudentID, Status, EnrollmentDate, ExitDate, IsRepeating, Notes, ExitReason
        FROM StudentsEnrollment
        WHERE StudentEnrollmentID = @StudentEnrollmentID;";

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StudentEnrollmentID", studentEnrollmentID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                    IsFound = true;

                    // تعيين القيم المرجعة
                    classID = Convert.ToInt32(dt.Rows[0]["ClassID"]);
                    studentID = Convert.ToInt32(dt.Rows[0]["StudentID"]);
                    status = Convert.ToInt16(dt.Rows[0]["Status"]);
                    enrollmentDate = Convert.ToDateTime(dt.Rows[0]["EnrollmentDate"]);

                    // التعامل مع ExitDate إذا كان null
                    if (dt.Rows[0]["ExitDate"] != DBNull.Value)
                        exitDate = Convert.ToDateTime(dt.Rows[0]["ExitDate"]);
                    else
                        exitDate = null;

                    isRepeating = Convert.ToBoolean(dt.Rows[0]["IsRepeating"]);
                    notes = dt.Rows[0]["Notes"].ToString();
                    exitReason = dt.Rows[0]["ExitReason"].ToString();
                }
            }
            catch (Exception ex)
            {
                // معالجة الاستثناءات (يمكن تسجيل الخطأ أو إعادة رميه)
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static DataTable GetStudentEnrollmentsByClassID(int classID)
        {
            DataTable dt = new DataTable();
            string query = @"SELECT * FROM StudentEnrollments WHERE ClassID = @ClassID;";
            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassID", classID);

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

        public static DataTable GetStudentEnrollmentsByStudentID(int StudentID)
        {
            DataTable dt = new DataTable();
            string query = @"SELECT * FROM StudentEnrollments WHERE StudentID = @StudentID;";
            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StudentID", StudentID);

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

        public static int GetTotalStudentsInClass(int classID)
        {
            int totalStudents = -1;
            string query = @"SELECT COUNT(*) AS TotalStudents
                         FROM StudentEnrollments
                         WHERE ClassID = @ClassID";

            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassID", classID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int total))
                {
                    totalStudents = total;
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

            return totalStudents;
        }

        public static bool IsStudentEnrolledInClass(int studentID, int classID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
            string query = @"SELECT Found = 1
                         FROM StudentEnrollments
                         WHERE StudentID = @StudentID AND ClassID = @ClassID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StudentID", studentID);
            command.Parameters.AddWithValue("@ClassID", classID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    IsFound = true;
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
            return IsFound;
        }

    }
}
