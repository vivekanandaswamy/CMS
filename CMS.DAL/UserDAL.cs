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
using System.Data.Common;

namespace CMS.DAL
{
    public class UserDAL
    {
        IDAL<SqlConnection> _db = null;
        SqlConnection _conn = null;
        public UserDAL(SqlConnection conn)
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
                 new KeyValuePair<string,object>("@host",System.Environment.MachineName.ToString()),
            };
         return  _db.ExecuteNonQuery(_conn, "cons.insert_user", CommandType.StoredProcedure, parameters.AsEnumerable());
        }

        public DbDataReader GetPassword(string uname)
        {
            var username = (new List<KeyValuePair<string, object>>() {
                    new KeyValuePair<string, object>("username",uname)
            }).AsEnumerable();
            return _db.ExecuteReader(_conn, "cons.forgot_password", CommandType.StoredProcedure, username);
        }

        public int ChangePassword(string oldPasswd,User _userDetails)
        {
            var parameters = new List<KeyValuePair<string, object>>(){                
                new KeyValuePair<string,object>("oldpasswd",oldPasswd),
                new KeyValuePair<string,object>("username",_userDetails.uname),
                new KeyValuePair<string,object>("newpasswd",_userDetails.passwd),
                new KeyValuePair<string,object>("conpasswd",_userDetails.conpasswd),                
            }.AsEnumerable();
            return _db.ExecuteNonQuery(_conn, "cons.change_password", CommandType.StoredProcedure, parameters);
        }
        public DbDataReader Login(string uname,string passwd)
        {
            var parameters = new List<KeyValuePair<string, object>>(){                
                new KeyValuePair<string,object>("username",uname),
                new KeyValuePair<string,object>("password",passwd),                
            }.AsEnumerable();
            return _db.ExecuteReader(_conn, "cons.get_logindetails", CommandType.StoredProcedure, parameters);
        }
    }
}
