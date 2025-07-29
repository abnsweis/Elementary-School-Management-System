using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsDataAccessLayerSettings
    {
        public static string ConnectionString
        {
            get
            {
                return @"Server = . ; Database=AlShamModelSchool;User Id = sa;Password = sweis";
            }
        }
    }
}
