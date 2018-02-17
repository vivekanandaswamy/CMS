using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.DAL;
using CMS.DAL.Models;
using System.Data.SqlClient;

namespace CMS.BL
{
    public class UserRegistrationBL
    {
        UserRegistrationDAL _userReg;
        public UserRegistrationBL()
        {
            var conn = new SqlConnection();
            _userReg = new CMS.DAL.UserRegistrationDAL(conn);
        }
        public int InsertUserDetails(User _userDetails )
        {
            return  _userReg.InsertUser(_userDetails);
        }
    }
}
