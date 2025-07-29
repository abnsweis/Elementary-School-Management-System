using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class clsParents
    {
        public enum enMode { Add, Update  }
        public int ParentsID { get; set; }
        public int FatherID { get; set; }
        public int MotherID { get; set; }

        public clsPerson Father { get; set; }
        public clsPerson Mother { get; set; }

        enMode _Mode = enMode.Add;

        public clsParents(int fatherID, int motherID)
        {
            FatherID = fatherID;
            MotherID = motherID;
        }

        public clsParents() { 
            
            ParentsID = -1;
            FatherID = -1;
            MotherID = -1;
            Father = null;
            Mother = null;
            _Mode = enMode.Add;
        }

        private clsParents(int parentsID, int fatherID, int motherID)
        {
            ParentsID = parentsID;
            FatherID = fatherID;
            MotherID = motherID;
            Father = clsPerson.Find(FatherID) ;
            Mother = clsPerson.Find(MotherID);
            _Mode = enMode.Update;
        }



        public static DataTable GetAllParents()
        {
            return clsParentsData.GetAllParents();
        }

                public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    {
                        if (_AddNewParents())
                        {
                            _Mode = enMode.Update;
                            return true;
                        } else return false;



                    }
                

                default:
                    return false;
            }


        }
   




        private  bool _AddNewParents()
        {
            this.ParentsID =  clsParentsData.AddNewParents(this.FatherID,this.MotherID);

            return this.ParentsID > 0;
        }

        public static clsParents Find(int ParentsID)
        {
 
            int FatherID = -1;
            int MotherID = -1; 
            if (clsParentsData.GetParentsByID(ParentsID, ref FatherID, ref MotherID))
            {
                return new clsParents(ParentsID, FatherID, MotherID);
            }
            return null;
        }

        public static bool IsParentsExist(int ParentsID)
        {
            return clsParentsData.IsParentsExist(ParentsID);
        }
    }
}
