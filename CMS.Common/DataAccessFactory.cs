using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Common.Interface;
using System.Data.Common;
using System.Configuration;

namespace CMS.Common
{
    public class DataAccessFactory<T> where T : DbConnection, new()
    {
        public static IDAL<T> CreateInstance(DataType dbase)
        {
            IDAL<T> dbContext = null;
            string connectionString = string.Empty;
            T t = null;
            switch (dbase)
            {
                case DataType.Odbc:
                    connectionString = GetConnection(ConnectionStringMode.OdbcConnectionString);
                    dbContext = new OdbcDAL<T>(connectionString, t);
                    break;
                case DataType.SqlServer:
                    connectionString = GetConnection(ConnectionStringMode.SqlServerConnectionString);
                    dbContext = new SqlServerDAL<T>(connectionString, t);
                    break;
            }
            return dbContext;
        }

        private static string GetConnection(ConnectionStringMode connectionMode)
        {
            string _connection = string.Empty;
            switch (connectionMode)
            {

                case ConnectionStringMode.OdbcConnectionString:
                    _connection = "Driver={Amazon Redshift (x64)}; Server=hadv111.c8qg9vzfzs00.us-east-1.redshift.amazonaws.com; Database=padb; UID=ha; PWD=Hudson234; Port=5439; UseDeclareFetch=1; Fetch=10000";
                    //_connection = "Driver={Amazon Redshift (x64)}; Server=hadv111.c8qg9vzfzs00.us-east-1.redshift.amazonaws.com; Database=padb; UID=ha_readonly; PWD=y863ENI74V; Port=5439; UseDeclareFetch=1; Fetch=10000";
                    break;
                case ConnectionStringMode.SqlServerConnectionString:
                    _connection = @"Data Source=DAL0IWRMBSQLP03;Initial Catalog=RMBS;User Id=RMBS_USER;Password=rmbs;MultipleActiveResultSets=True";
                    //_connection = ConfigurationManager.ConnectionStrings["SqlServerConnectionString"].ToString();
                    break;

            }
            return _connection;
        }
    }


}
