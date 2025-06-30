using LabWork46;
using Microsoft.Data.Sqlite;

namespace SqlLibrary
{
    public class SqliteDatabase(string path, string fileName) : IDatabase
    {
        private readonly string _connectionString = new SqliteConnectionStringBuilder()
        {
            DataSource = Path.Combine(path, fileName)
        }.ConnectionString;

        public int ExecuteQuery(string query)
        {
            using SqliteConnection connection = new(_connectionString);
            connection.Open();
            SqliteCommand command = new(query, connection);
            return command.ExecuteNonQuery();
        }
    }
}
