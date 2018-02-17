using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CMS.Common.Interface
{
    public interface IDAL<T> where T : DbConnection, IDbConnection, new()
    {
        string connectionstring { get; }

        IDbDataParameter CreateParameter(string key, object value);

        DbCommand CreateCommand(T t, string query, CommandType cmdType, IEnumerable<KeyValuePair<string, object>> parameters);

        DbDataReader ExecuteReader(T t, string query, CommandType cmdType, IEnumerable<KeyValuePair<string, object>> parameters);

        Task<DbDataReader> ExecuteReaderAsync(T t, string query, CommandType cmdType, IEnumerable<KeyValuePair<string, object>> parameters);

        void ExecuteScalar(T t, string query, CommandType cmdType, IEnumerable<KeyValuePair<string, object>> parameters);

        Task ExecuteScalarAsync(T t, string query, CommandType cmdType, IEnumerable<KeyValuePair<string, object>> parameters, CancellationToken cncTkn = default(CancellationToken));

        int ExecuteNonQuery(T t, string query, CommandType cmdType, IEnumerable<KeyValuePair<string, object>> parameters);

        Task<int> ExecuteNonQueryAsync(T t, string query, CommandType cmdType, IEnumerable<KeyValuePair<string, object>> parameters, CancellationToken cncTkn = default(CancellationToken));

        DataTable GetDataTable(T t, string query, CommandType cmdType, IEnumerable<KeyValuePair<string, object>> parameters);

        Task<DataTable> GetDataTableAsync(T t, string query, CommandType cmdType, IEnumerable<KeyValuePair<string, object>> parameters);

    }
}
