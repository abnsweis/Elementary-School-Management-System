using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class clsUser
    {
        public enum enMode { Add, Update }
        private enMode _Mode;
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public clsPerson Person { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsUser(int userID, int personID, string userName, string password, bool isActive)
        {
            _Mode = enMode.Update;
            UserID = userID;
            PersonID = personID;

            Person = clsPerson.Find(PersonID);
            UserName = userName;
            Password = password;
            IsActive = isActive;
        }
        public clsUser()
        {
            _Mode = enMode.Add;
            UserID = -1;
            PersonID = -1;
            Person = null;
            UserName = string.Empty;
            Password = string.Empty;
            IsActive = true;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    {
                        if (_AddNewUser())
                        {
                            _Mode = enMode.Update;
                            return true;
                        } else return false;



                    }
                case enMode.Update:
                    {
                        return _UpdateUser();
                    }

                default:
                    return false;
            }


        }
        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();   
        }




        private  bool _AddNewUser()
        {
            this.UserID =  clsUserData.AddNewUser(PersonID, UserName, Password, IsActive);

            return this.UserID > 0;
        }
        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser (this.UserID, PersonID, UserName, Password, IsActive);

        }


        public bool Delete()
        {
            return clsUserData.DeleteUser(this.UserID);
        }
        public static bool Delete(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

        public static clsUser Find(int UserID)
        {
            int PersonID = -1;
            string Username = "";
            string Password = ""; 
            bool IsActive = true; 
             
            if (clsUserData.GetUserByID(UserID, ref PersonID, ref Username, ref Password, ref IsActive ))
            {
                return new clsUser(UserID,PersonID,Username,Password,IsActive );
            }
            return null;
        }
        public static clsUser FindByPersonID(int PersonID)
        {
            int UserID = -1;
            string Username = "";
            string Password = ""; 
            bool IsActive = true; 
             
            if (clsUserData.GetUserByPersonID(PersonID, ref UserID, ref Username, ref Password, ref IsActive ))
            {
                return new clsUser(UserID,PersonID,Username,Password,IsActive );
            }
            return null;
        }


        public static bool IsUserExist(int UserID)
        {
            return clsUserData.IsUserExist(UserID);
        }
        public static bool IsUserExist(string Username)
        {
            return clsUserData.IsUserExist(Username);
        }
        public static bool IsUserExistByPersonID(int PersonID)
        {
            return clsUserData.IsUserExistByPersonID(PersonID);
        }
    }

}
 

 