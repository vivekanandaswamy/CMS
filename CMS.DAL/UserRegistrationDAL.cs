using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Common.Interface;
using System.Data.SqlClient;
using CMS.DAL.Models;
using System.Data;
using CMS.Common;

namespace CMS.DAL
{
    public class UserRegistrationDAL
    {
        IDAL<SqlConnection> _db = null;
        SqlConnection _conn = null;
        public UserRegistrationDAL(SqlConnection conn)
        {
            _conn = conn;
            _db = DataAccessFactory<SqlConnection>.CreateInstance(DataType.SqlServer);
        }
        public int InsertUser(User _userDetails)
        {
            var parameters = new List<KeyValuePair<string, object>>(){
                new KeyValuePair<string,object>("fname",_userDetails.fname),
                new KeyValuePair<string,object>("lname",_userDetails.lname),
                new KeyValuePair<string,object>("uname",_userDetails.uname),
                new KeyValuePair<string,object>("passwd",_userDetails.passwd),
                new KeyValuePair<string,object>("conpasswd",_userDetails.conpasswd),
                new KeyValuePair<string,object>("dor",_userDetails.dor),
            };
         return  _db.ExecuteNonQuery(_conn, "cons.insert_user", CommandType.StoredProcedure, parameters.AsEnumerable());
        }
    }
}
