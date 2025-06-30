using Microsoft.Data.Sqlite;

namespace SqliteLibrary
{
    public class DataAccessLayerLite
    {
        public static string FileName { get; set; } = "GamesStore.sqlite";
        private static SqliteConnectionStringBuilder _builder = new() 
        { 
            DataSource = Path.Combine(Environment.CurrentDirectory, FileName)
        };
        public static string ConnectionString = _builder.ConnectionString;

        public static object GetScalarValue(string query)
        {
            using SqliteConnection connection = new(ConnectionString);
            connection.Open();

            SqliteCommand command = new(query, connection);
            object value = command.ExecuteScalar();
            connection.Close();
            return value;
        }
    }
}
