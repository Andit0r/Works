using Lection0605;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using System.Data;
using DbLibrary;
using DbLibrary.Database;
using DbLibrary.Repositries;

Console.WriteLine("Dapper");

string connectionString = "Data Source=mssql;Initial Catalog=ispp3108;Persist Security Info=True;User ID=ispp3108;Password=3108;Trust Server Certificate=True";
IDatabaseFactory factory = new MsSqlFactory(connectionString);
ReviewRepository repository = new(factory);

var reviews = repository.GetReviews(); 
var review = repository.GetReview(3);
review.Comment = "fasdfasdf";
repository.UpdateReview(review);


//string query = ""

Console.WriteLine("ADO.NET");
//TestSqlite();
//TestMssql();
DataBaseContext.ChangePrice("Robert' DROP TABLE Game--", 999);
var title = DataBaseContext.FindGameTitle(1);
//var reviews = DataBaseContext.GetReviews();
//var review = DataBaseContext.GetReview(2);
//review.Comment = "sdfasdf";
//DataBaseContext.UpdateReview(review);
Console.WriteLine();

void TestMssql()
{
    Console.WriteLine("Microsoft SQL Server");

    #region connection
    string connectionString = "Data Source=mssql;Initial Catalog=ispp3108;Persist Security Info=True;User ID=ispp3108;Password=3108;Trust Server Certificate=True";

    SqlConnectionStringBuilder builder = new();
    {
        builder.DataSource = "mssql"; // server
        builder.InitialCatalog = "ispp3108"; // db
        builder.UserID = "ispp3108"; // login
        builder.Password = "3108"; // pass
        builder.TrustServerCertificate = true;
    };
    connectionString = builder.ConnectionString;
    #endregion

    using SqlConnection connection = new(connectionString);
    connection.Open();

    string query = "UPDATE Game SET Price+=0.01";
    SqlCommand command = new(query, connection);

    //command.ExecuteNonQuery(); // DDL/DML
    // int rowsCount = command.ExecuteNonQuery(); // DML

    //query = "SELECT Price FROM Game WHERE Id=3";
    //command = new(query, connection);
    //var result = command.ExecuteScalar();
    //var result = Convert.ToDouble(command.ExecuteScalar());

    query = "SELECT * FROM Game";
    command = new(query, connection);
    var reader = command.ExecuteReader();

    DataTable shema = reader.GetSchemaTable();
    Console.WriteLine();
    //SqlDataAdapter adapter = new(query, connection);
    //DataTable table = new();
    //adapter.Fill(table); // заполнение

    //// ... изменили таблицу
    //SqlCommandBuilder commandBuilder = new(adapter);
    //adapter.Update(table);
    //table.Clear();
    //adapter.Fill(table);


    

    //DataTable table = new("games");
    //table.Load(reader);

    var columnsCount = reader.FieldCount;

    List<Game> games = new();
    while (reader.Read()) // чтение строки
    {
        games.Add(new()
        {
            Id = Convert.ToInt32(reader["Id"]),
            Title = reader["Title"].ToString(),
            Price = Convert.ToDecimal(reader["Price"]),
        });
        

        //var id = reader.GetInt32(0);
        //var title = reader.GetString(1);
        //var price = reader.GetDecimal(4);
        //Console.WriteLine($"{id} {title} {price}");

        //object[] cells = new object[reader.FieldCount];
        //reader.GetValues(cells);
        //string row = String.Join(",", cells);
        //Console.WriteLine(row);

        //console.writeline($"{reader["id"]} {reader["title"]}");
        //if (reader["description"] != dbnull.value )
        //    console.writeline($"description: {reader["description"]}");
        //else
        //    console.writeline("description: empty");
        //console.writeline();

        // reader[0]
        // reader["Title"]
    }
}

void TestSqlite()
{
    Console.WriteLine("SQLite");

    #region connection
    var fileName = Path.Combine(Environment.CurrentDirectory, "dbl.sqlite");

    SqliteConnectionStringBuilder builder = new();
    builder.DataSource = fileName;   
    string connectionString = builder.ConnectionString;

    connectionString = $"Data Source={fileName}";
    #endregion

    using SqliteConnection connection = new(connectionString);
    connection.Open();

    string query = "";
}

