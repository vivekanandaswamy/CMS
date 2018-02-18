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
    public class MaterialDAL
    {
        IDAL<SqlConnection> _db = null;
        SqlConnection _conn = null;
        public MaterialDAL(SqlConnection conn)
        {
            _conn = conn;
            _db = DataAccessFactory<SqlConnection>.CreateInstance(DataType.SqlServer);
        }
        public int InsertMaterial(Material _material)
        {
            var parameters = new List<KeyValuePair<string, object>>(){
                new KeyValuePair<string,object>("name",_material.mnane),
                new KeyValuePair<string,object>("comments",_material.comments),
            };
            return _db.ExecuteNonQuery(_conn, "cons.insert_material", CommandType.StoredProcedure, parameters.AsEnumerable());
        }
        public int InsertMaterialDealers(MaterialDealers _materialDealers)
        {
            var parameters = new List<KeyValuePair<string, object>>(){
                new KeyValuePair<string,object>("typeOfMaterialId",_materialDealers.tmid),
                new KeyValuePair<string,object>("mname",_materialDealers.name),
                new KeyValuePair<string,object>("address",_materialDealers.address),
                new KeyValuePair<string,object>("mobnum",_materialDealers.mobile),
                new KeyValuePair<string,object>("comments",_materialDealers.comments),
            };
            return _db.ExecuteNonQuery(_conn, "cons.insert_materialdealers", CommandType.StoredProcedure, parameters.AsEnumerable());
        }
        public int InsertTypeofMaterial(TypeOfMaterial _typeofmaterial)
        {
            var parameters = new List<KeyValuePair<string, object>>(){
                new KeyValuePair<string,object>("mid",_typeofmaterial.mid),
                new KeyValuePair<string,object>("tmname",_typeofmaterial.tmname),                
                new KeyValuePair<string,object>("comments",_typeofmaterial.comments),
            };
            return _db.ExecuteNonQuery(_conn, "cons.insert_typeofmaterial", CommandType.StoredProcedure, parameters.AsEnumerable());
        }
        public DataTable FetchMaterial()
        {
            return _db.GetDataTable(_conn, "cons.fetch_material", CommandType.StoredProcedure, null);
        }
    }
}
