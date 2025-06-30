using LabWork46;
using Microsoft.Data.SqlClient;

namespace SqlLibrary
{
    public class SqlDatabase(string dataSource, string initialCatalog, string login, string password) : IDatabase
    {
        private readonly string _connectionString = new SqlConnectionStringBuilder()
        {
            DataSource = dataSource,
            InitialCatalog = initialCatalog,
            UserID = login,
            Password = password,
            TrustServerCertificate = true
        }.ConnectionString;

        public int ExecuteQuery(string query)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            SqlCommand command = new(query, connection);
            return command.ExecuteNonQuery();
        }
    }
}
