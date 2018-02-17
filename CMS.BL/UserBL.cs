using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.DAL;
using CMS.DAL.Models;
using System.Data.SqlClient;
using System.Data.Common;

namespace CMS.BL
{
    public class UserBL
    {
        UserDAL _userReg;
        public UserBL()
        {
            var conn = new SqlConnection();
            _userReg = new CMS.DAL.UserDAL(conn);
        }
        public int InsertUserDetails(User _userDetails)
        {
            return _userReg.InsertUser(_userDetails);
        }
        public DbDataReader GetPassword(string uname)
        {
            return _userReg.GetPassword(uname);
        }
        public int ChangePassword(string oldPasswd, User _userDetails)
        {
            return _userReg.ChangePassword(oldPasswd, _userDetails);
        }
        public DbDataReader Login(string uname,string passwd)
        {
            return _userReg.Login(uname, passwd);
        }
    }
}
