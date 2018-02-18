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
    public class MaterialBL
    {
        MaterialDAL _materialDAL;
        public MaterialBL()
        {
            var conn = new SqlConnection();
            _materialDAL = new MaterialDAL(conn);
        }
        public int InsertMaterial(Material _material)
        {
            return _materialDAL.InsertMaterial(_material);
        }
        public int InsertMaterialDealers(MaterialDealers _materialDealers)
        {
            return _materialDAL.InsertMaterialDealers(_materialDealers);
        }
        public int InsertTypeofMaterial(TypeOfMaterial _typeofmaterial)
        {
            return _materialDAL.InsertTypeofMaterial(_typeofmaterial);
        }
    }
}
