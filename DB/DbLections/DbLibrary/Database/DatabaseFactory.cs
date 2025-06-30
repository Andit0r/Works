using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using System.Data;

namespace DbLibrary.Database
{
    public interface IDatabaseFactory
    {
        IDbConnection CreateConnection();
    }

    public class MsSqlFactory(string connectionString) : IDatabaseFactory
    {
        public IDbConnection CreateConnection() => new SqlConnection(connectionString);
    }

    public class SqliteFactory(string connectionString) : IDatabaseFactory
    {
        public IDbConnection CreateConnection() => new SqliteConnection(connectionString);
    }
}
