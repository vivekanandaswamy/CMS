using CMS.Common.Interface;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace CMS.Common
{
    public class SqlServerDAL<T> : IDAL<T> where T : DbConnection, new()
    {
        #region Properties
        private string connString;

        private int CommandTimeOut { get; set; }
        public string connectionstring
        {
            get
            {
                return connString;
            }
        }
        #endregion

        #region Constructor        

        public SqlServerDAL(string _connectionString, T t)
        {
            t = new T();
            this.connString = _connectionString;
            CommandTimeOut = 6000;
        }

        #endregion

        #region DbParameter, DbConnection & DbCommand
        public IDbDataParameter CreateParameter(string key, object value)
        {
            return new SqlParameter(key, value);
        }

        public DbCommand CreateCommand(T t, string query, CommandType cmdType, IEnumerable<KeyValuePair<string, object>> parameters)
        {
            var cmd = t.CreateCommand();
            if (cmd.Connection.State == ConnectionState.Open)
                t.Close();
            cmd.Connection.ConnectionString = connString;
            cmd.CommandText = query;
            cmd.CommandType = cmdType;
            cmd.CommandTimeout = CommandTimeOut;
            if (parameters != null)
            {
                foreach (KeyValuePair<string, object> param in parameters)
                {
                    cmd.Parameters.Add(CreateParameter(param.Key, param.Value));
                }
            }
            return cmd;
        }
        #endregion

        #region ExecuteNonQuery Methods

        public int ExecuteNonQuery(T t, string query, CommandType cmdType, IEnumerable<KeyValuePair<string, object>> parameters)
        {
            var cmd = CreateCommand(t, query, cmdType, parameters);
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();
            return cmd.ExecuteNonQuery();
        }

        public async Task<int> ExecuteNonQueryAsync(T t, string query, CommandType cmdType, IEnumerable<KeyValuePair<string, object>> parameters, CancellationToken cncTkn = default(CancellationToken))
        {
            var cmd = CreateCommand(t, query, cmdType, parameters);
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();
            return await cmd.ExecuteNonQueryAsync(cncTkn);
        }
        #endregion

        #region ExecuteReader Methods
        public DbDataReader ExecuteReader(T t, string query, CommandType cmdType, IEnumerable<KeyValuePair<string, object>> parameters)
        {
            var cmd = CreateCommand(t, query, cmdType, parameters);
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();
            return cmd.ExecuteReader();
        }

        public async Task<DbDataReader> ExecuteReaderAsync(T t, string query, CommandType cmdType, IEnumerable<KeyValuePair<string, object>> parameters)
        {
            var cmd = CreateCommand(t, query, cmdType, parameters);
            if (cmd.Connection.State != ConnectionState.Open)
                await cmd.Connection.OpenAsync();
            return await cmd.ExecuteReaderAsync(CommandBehavior.Default);
        }

        #endregion

        #region ExecuteScalar Methods
        public void ExecuteScalar(T t, string query, CommandType cmdType, IEnumerable<KeyValuePair<string, object>> parameters)
        {
            var cmd = CreateCommand(t, query, cmdType, parameters);
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();
            cmd.ExecuteScalar();
        }

        public async Task ExecuteScalarAsync(T t, string query, CommandType cmdType, IEnumerable<KeyValuePair<string, object>> parameters, CancellationToken cncTkn = default(CancellationToken))
        {
            var cmd = CreateCommand(t, query, cmdType, parameters);
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();
            await cmd.ExecuteScalarAsync(cncTkn);
        }
        #endregion

        #region DataTable Methods
        public DataTable GetDataTable(T t, string query, CommandType cmdType, IEnumerable<KeyValuePair<string, object>> parameters)
        {
            var resultDataTable = new DataTable();
            var dataReader = ExecuteReader(t, query, cmdType, parameters);
            resultDataTable.Load(dataReader);
            return resultDataTable;
        }

        public async Task<DataTable> GetDataTableAsync(T t, string query, CommandType cmdType, IEnumerable<KeyValuePair<string, object>> parameters)
        {
            TaskCompletionSource<DataTable> source = new TaskCompletionSource<DataTable>();
            var resultDataTable = new DataTable();
            DbDataReader dataReader = null;
            try
            {
                dataReader = await ExecuteReaderAsync(t, query, cmdType, parameters);
                resultDataTable.Load(dataReader);
                source.SetResult(resultDataTable);
            }
            catch (Exception ex)
            {
                source.SetException(ex);
            }
            finally
            {
                if (dataReader != null)
                    dataReader.Close();
            }

            return resultDataTable;
        }
        #endregion
       
    }
}
