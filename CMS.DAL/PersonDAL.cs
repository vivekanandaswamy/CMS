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
    public class PersonDAL
    {
        IDAL<SqlConnection> _db = null;
        SqlConnection _conn = null;
        public PersonDAL(SqlConnection conn)
        {
            _conn = conn;
            _db = DataAccessFactory<SqlConnection>.CreateInstance(DataType.SqlServer);
        }
        public int InsertPersons(Person _person)
        {
            var parameters = new List<KeyValuePair<string, object>>(){
                new KeyValuePair<string,object>("pname",_person.name),
                new KeyValuePair<string,object>("comments",_person.comments),
            };
            return _db.ExecuteNonQuery(_conn, "cons.insert_persons", CommandType.StoredProcedure, parameters.AsEnumerable());
        }
        public int InsertPersonDetails(PersonDetails _personDetails)
        {
            var parameters = new List<KeyValuePair<string, object>>(){
                new KeyValuePair<string,object>("pname",_personDetails.name),
                new KeyValuePair<string,object>("paddress",_personDetails.address),
                new KeyValuePair<string,object>("rpid",_personDetails.rpid),
                new KeyValuePair<string,object>("mob1",_personDetails.mobile1),
                new KeyValuePair<string,object>("mob2",_personDetails.mobile2),
                new KeyValuePair<string,object>("mail",_personDetails.email),
                new KeyValuePair<string,object>("pcomments",_personDetails.comments),
            };
            return _db.ExecuteNonQuery(_conn, "cons.insert_persondetails", CommandType.StoredProcedure, parameters.AsEnumerable());
        }
        public DataTable FetchPersons()
        {
            return _db.GetDataTable(_conn, "cons.fetch_persons", CommandType.StoredProcedure, null);
        }
        public DataTable FetchPersonDetails()
        {
            return _db.GetDataTable(_conn, "cons.fetch_persondetails", CommandType.StoredProcedure, null);
        }
    }
}
