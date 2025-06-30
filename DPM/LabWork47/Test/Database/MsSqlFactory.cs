using Microsoft.Data.SqlClient;
using System.Data;

namespace DbLibrary.Database
{
    public class MsSqlFactory(string connectionString) : IDbConnectionFactory
    {
        public IDbConnection CreateConnection()
            => new SqlConnection(connectionString);
    }
}
