using DataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

public class clsClassData
{
    private static readonly string ConnectionString = clsDataAccessLayerSettings.ConnectionString;

    public static DataTable GetAllClasses()
    {
        DataTable dt = new DataTable();
        string query = @"select * from Classes_View;";
        SqlConnection connection = new SqlConnection(ConnectionString);
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
    public static DataTable GetClassesByGradeLevelID(int GradeLevelID)
    {
        DataTable dt = new DataTable();
        string query = @"select Classes.ClassName from Classes where GradeLevelID = @GradeLevelID;";
        SqlConnection connection = new SqlConnection(ConnectionString);
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

    public static int AddNewClass(int gradeLevelID, string className, int maxStudents, string roomNumber, short shiftType )
    {
        int insertedID = -1;

        string query = @"INSERT INTO Classes (GradeLevelID, ClassName, MaxStudents, RoomNumber, ShiftType )
VALUES (@GradeLevelID, @ClassName, @MaxStudents, @RoomNumber ,  @ShiftType);

        SELECT SCOPE_IDENTITY();";

        SqlConnection connection = new SqlConnection(ConnectionString);
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@GradeLevelID", gradeLevelID);
        command.Parameters.AddWithValue("@ClassName", className);
        command.Parameters.AddWithValue("@MaxStudents", maxStudents);
        command.Parameters.AddWithValue("@RoomNumber", roomNumber);
        command.Parameters.AddWithValue("@ShiftType", shiftType); 
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
            return insertedID;
        }
        finally
        {
            connection.Close();
        }

        return insertedID;
    }

    public static bool UpdateClass(int classID, int gradeLevelID, string className, int maxStudents, string roomNumber, short shiftType )
    {
        string query = @"UPDATE Classes SET GradeLevelID = @GradeLevelID, ClassName = @ClassName, MaxStudents = @MaxStudents, RoomNumber = @RoomNumber, ShiftType = @ShiftType  WHERE ClassID = @ClassID";
        SqlConnection connection = new SqlConnection(ConnectionString);
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@ClassID", classID);
        command.Parameters.AddWithValue("@GradeLevelID", gradeLevelID);
        command.Parameters.AddWithValue("@ClassName", className);
        command.Parameters.AddWithValue("@MaxStudents", maxStudents);
        command.Parameters.AddWithValue("@RoomNumber", roomNumber);
        command.Parameters.AddWithValue("@ShiftType", shiftType); 
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

    public static bool DeleteClass(int classID)
    {
        string query = @"DELETE From Classes WHERE ClassID = @ClassID";
        SqlConnection connection = new SqlConnection(ConnectionString);
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@ClassID", classID);
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


    public static bool GetClassByID(int classID, ref int gradeLevelID, ref string className, ref int maxStudents, ref string roomNumber, ref short shiftType )
    {
        bool IsFound = false;
        DataTable dt = new DataTable();
        string query = @"
                SELECT GradeLevelID, ClassName, MaxStudents, RoomNumber, ShiftType  
               From Classes 
                WHERE ClassID = @ClassID;";

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
                IsFound = true;

                 
                gradeLevelID = Convert.ToInt32(dt.Rows[0]["GradeLevelID"]);
                className = dt.Rows[0]["ClassName"].ToString();
                maxStudents = Convert.ToInt32(dt.Rows[0]["MaxStudents"]);
                roomNumber = dt.Rows[0]["RoomNumber"].ToString();
                shiftType = Convert.ToInt16(dt.Rows[0]["ShiftType"]) ;

                 
            }
        }
        catch (Exception ex)
        {
             
        }
        finally
        {
            connection.Close();
        }

        return IsFound;
    }

    public static bool GetClassByIDName(string className, ref int gradeLevelID, ref int classID, ref int maxStudents, ref string roomNumber, ref short shiftType)
    {
        bool IsFound = false;
        DataTable dt = new DataTable();
        string query = @"
                SELECT GradeLevelID, ClassID, MaxStudents, RoomNumber, ShiftType  
               From Classes 
                WHERE className = @className;";

        SqlConnection connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@className", className);

        try
        {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                dt.Load(reader);
                IsFound = true;


                classID = Convert.ToInt32(dt.Rows[0]["ClassID"]);
                gradeLevelID = Convert.ToInt32(dt.Rows[0]["GradeLevelID"]); 
                maxStudents = Convert.ToInt32(dt.Rows[0]["MaxStudents"]);
                roomNumber = dt.Rows[0]["RoomNumber"].ToString();
                shiftType = Convert.ToInt16(dt.Rows[0]["ShiftType"]);


            }
        }
        catch (Exception ex)
        {

        }
        finally
        {
            connection.Close();
        }

        return IsFound;
    }

    public static bool IsClassExist(int ClassID)
    {
        bool IsFound = false;
        SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
        string Query = @"SELECT Found = 1 from Classes WHERE ClassID = @ClassID";
        SqlCommand Command = new SqlCommand(Query, Connection);
        Command.Parameters.AddWithValue("@ClassID", ClassID);
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
    public static bool IsClassExist(string ClassName)
    {
        bool IsFound = false;
        SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
        string Query = @"SELECT Found = 1 from Classes WHERE ClassName = @ClassName";
        SqlCommand Command = new SqlCommand(Query, Connection);
        Command.Parameters.AddWithValue("@ClassName", ClassName);
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

    public static bool IsStudentEnrollmentInThisClass(int ClassID,int StudentID)
    {
        bool IsFound = false;
        SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.ConnectionString);
        string Query = @"select Found = 1 from StudentEnrollment where ClassID = @ClassID And StudentID = @StudentID;";
        SqlCommand Command = new SqlCommand(Query, Connection);
        Command.Parameters.AddWithValue("@ClassID", ClassID);
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

    public static int GetTotalStudents(int ClassID)
    {
        int TotalStudents = -1;

        string query = @"SELECT COUNT(*) AS TotalStudents  
FROM StudentsEnrollment  
WHERE ClassID = @ClassID;";

        SqlConnection connection = new SqlConnection(ConnectionString);
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@ClassID", ClassID);
         
        try
        {
            connection.Open();
            object result = command.ExecuteScalar();
            if (result != null && int.TryParse(result.ToString(), out int TotalStudentsCount))
            {
                TotalStudents = TotalStudentsCount;
            }
        }
        catch (Exception ex)
        {
            // Handle exception
            return TotalStudents;
        }
        finally
        {
            connection.Close();
        }

        return TotalStudents;
    }
}
