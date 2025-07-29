using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class clsPerson
    {
        public enum enMode {Add,Update}

        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime  DateOfBirth { get; set; }
        public bool Gender { get; set; } // 1 = Male , 0 = Female
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string NationalID { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUser CreatedByUserInfo { get; set; }

        public string ImagePath { get; set; }

        private enMode _Mode;


        public int Age {
            get {

                return DateTime.Now.Year - DateOfBirth.Year ;

            }
        }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public clsPerson()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            DateOfBirth = DateTime.MinValue;
            Gender = true;
            Phone = string.Empty;
            Email = string.Empty;
            Address = string.Empty;
            NationalID = string.Empty;
            CreatedByUserID = -1;
            //CreatedByUserInfo = clsUser.Find(CreatedByUserID);
            ImagePath = string.Empty;
            _Mode = enMode.Add;
        }

        private clsPerson(int personID, string firstName, string lastName, DateTime dateOfBirth, bool gender, string phone, string email, string address, string nationalID,int CreatedByUserID,string ImagePath)
        {
            this.PersonID = personID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Phone = phone;
            this.Email = email;
            this.Address = address;
            this.NationalID = nationalID;
            this.CreatedByUserID = CreatedByUserID;
            this.ImagePath = ImagePath;
            _Mode = enMode.Update;
        }



        private bool _AddNewPerson()
        {
            this.PersonID =  clsPersonData.AddNewPerson(FirstName, LastName, DateOfBirth, Gender, Phone, Email, Address, NationalID, CreatedByUserID, ImagePath);

            return (this.PersonID != -1);
        }        
        
        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this.PersonID, FirstName, LastName, DateOfBirth, Gender, Phone, Email, Address, NationalID, CreatedByUserID, ImagePath);
              
        }

        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }

        public bool Delete()
        {
            return clsPersonData.DeletePerson(this.PersonID);
        }
        public static bool Delete(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }


        public static clsPerson Find(int PersonID)
        {
            string firstName = "";
            string lastName = "";
            DateTime dateOfBirth = DateTime.MinValue;
            bool Gender = true;
            string phone = "";
            string email = "";
            string address = "";
            string nationalID = "";
            int CreatedByUserID = -1;
            string ImagePath = "";
            if (clsPersonData.GetPersonByID(PersonID,ref firstName,ref lastName,ref dateOfBirth,ref Gender,ref phone,ref email,ref address,ref nationalID,ref CreatedByUserID,ref ImagePath))
            {
                return new clsPerson(PersonID,firstName,lastName,dateOfBirth,Gender,phone,email,address,nationalID, CreatedByUserID, ImagePath);
            }
            return null;
        }
        public static clsPerson Find(string Email)
        {
            int PersonID = -1;
            string firstName = "";
            string lastName = "";
            DateTime dateOfBirth = DateTime.MinValue;
            bool Gender = true;
            string phone = ""; 
            string address = "";
            string nationalID = "";
            int CreatedByUserID = -1;
            string ImagePath = ""; 

            if (clsPersonData.GetPersonByEmail(Email, ref PersonID, ref firstName,ref lastName,ref dateOfBirth,ref Gender,ref phone, ref address,ref nationalID,ref CreatedByUserID,ref ImagePath))
            {
                return new clsPerson(PersonID,firstName,lastName,dateOfBirth,Gender,phone, Email, address,nationalID, CreatedByUserID, ImagePath);
            }
            return null;
        }        
        public static clsPerson FindByNationalID(string NationalID)
        {
            int PersonID = -1;
            string firstName = "";
            string lastName = "";
            DateTime dateOfBirth = DateTime.MinValue;
            bool Gender = true;
            string phone = ""; 
            string address = ""; 
            string email = "";
            int CreatedByUserID = -1;

            string ImagePath = "";
            if (clsPersonData.GetPersonByNationalID(NationalID, ref PersonID, ref firstName,ref lastName,ref dateOfBirth,ref Gender,ref phone,ref email,ref address, ref CreatedByUserID, ref ImagePath))
            {
                return new clsPerson(PersonID,firstName,lastName,dateOfBirth,Gender,phone,email,address, NationalID, CreatedByUserID, ImagePath);
            }
            return null;
        }


        public static bool IsPersonExist(int PersonID)
        {
            return clsPersonData.IsPersonExist(PersonID);
        }
        public static bool IsPersonExist(string Email)
        {
            return clsPersonData.IsPersonExist(Email);
        }
        public static bool IsPersonExistByNationalID(string NationalID)
        {
            return clsPersonData.IsPersonExistByNationalID(NationalID);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    {
                        if (_AddNewPerson())
                        {
                            _Mode = enMode.Update;
                            return true;
                        } 
                        
                        else return false;



                    } 
                case enMode.Update:{
                        return _UpdatePerson();
                 }
                
                default:
                    return false;
            } 
            

        }

    }
}
