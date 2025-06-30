using DbLibrary.Database;
using DbLibrary.Repository;
using DbLibrary.Services;

Console.WriteLine("Testing library");
string? connectionString = "Data Source=mssql;Initial Catalog=ispp3108;Persist Security Info=True;User ID=ispp3108;Password=3108;Trust Server Certificate=True";
IDbConnectionFactory factory = new MsSqlFactory(connectionString);
GamesRepository repository = new(factory);
GamesService service = new(repository);

var games = service.GetAll();
var game = service.GetById(1);

game.Description = "dasdas";
service.Update(game);

game = new()
{
    Title = "Satisfactory",
    Description = "Работа на заводе",
    PublicationYear = 2024,
    Price = 1300
};
service.Create(game);
game = new()
{
    Title = "CS2",
    Description = "Стрелялка",
    PublicationYear = 2023,
    Price = 1200
};
service.Create(game);
service.Delete(12);

Console.WriteLine();