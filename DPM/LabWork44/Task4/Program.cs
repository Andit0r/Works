using Microsoft.Data.SqlClient;

CreateDatabase();

void CreateDatabase()
{
    SqlConnectionStringBuilder builder = new();
    {
        builder.DataSource = "mssql"; // server
        builder.InitialCatalog = "ispp3108"; // db
        builder.UserID = "ispp3108"; // login
        builder.Password = "3108"; // pass
        builder.TrustServerCertificate = true;
    };

    string connectionString = builder.ConnectionString;

    using SqlConnection connection = new(connectionString);
    connection.Open();

    string query =
        @"CREATE TABLE Roles(
            Id INT IDENTITY(1,1) PRIMARY KEY
            , [Name] NVARCHAR(50) NOT NULL);
        CREATE TABLE Users(
            Id INT IDENTITY(1,1) PRIMARY KEY
            , RoleId INT NOT NULL
            , [Login] NVARCHAR(50) NOT NULL
            , Password NVARCHAR(50) NOT NULL
            , FOREIGN KEY (RoleId) REFERENCES Roles(Id));";
    SqlCommand command = new(query, connection);

    command.ExecuteNonQuery();
    connection.Close();
    Console.WriteLine("Таблицы в БД успешно созданы");
}
