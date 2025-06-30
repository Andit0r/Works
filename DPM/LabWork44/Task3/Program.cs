using Microsoft.Data.Sqlite;

Console.WriteLine("Введите название файла");
string name = Console.ReadLine();
CreateDatabase(name);

void CreateDatabase(string name)
{
    var fileName = Path.Combine(Environment.CurrentDirectory, name);
    if (File.Exists(fileName))
    {
        Console.WriteLine("Файл уже есть");
        return;
    }

    SqliteConnectionStringBuilder builder = new();
    builder.DataSource = fileName;
    string connectionString = builder.ConnectionString;

    connectionString = $"Data Source={fileName}";

    using SqliteConnection connection = new(connectionString);
    connection.Open();

    string query = @"CREATE TABLE Game (Id INTEGER PRIMARY KEY AUTOINCREMENT, Title TEXT NOT NULL,Description TEXT NOT NULL, PublicationYear INTEGER NOT NULL, Price REAL NOT NULL);
        CREATE TABLE Review (Id INTEGER PRIMARY KEY AUTOINCREMENT, GameId INTEGER NOT NULL, User TEXT NOT NULL, Comment TEXT NOT NULL, PublicationDate TEXT NOT NULL, FOREIGN KEY (GameId) REFERENCES Game(Id));";
    SqliteCommand command = new(query, connection);
    command.ExecuteNonQuery();
    connection.Close();
    Console.WriteLine("БД успешно создана");
}