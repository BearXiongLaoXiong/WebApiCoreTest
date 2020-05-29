using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace WebApiCoreTest.Common
{
    public class ConnectionOptions
    {
        public static string ConnectionString { get; set; }

    }

    public class DapperHelper
    {
        static IDbConnection _db = new SqlConnection();
        public string ConnectionString => ConnectionOptions.ConnectionString;
        public DapperHelper()
        {
            _db.ConnectionString = ConnectionString;
        }

        public T Find<T>(string sql, params object[] list)
        {
            return _db.QueryFirst<T>(sql);
        }

        public IEnumerable<T> FindList<T>(string sql, params string[] list)
        {
            return _db.Query<T>(sql);
        }
    }
}