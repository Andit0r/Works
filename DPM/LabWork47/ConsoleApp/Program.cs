using DbLibrary.Services;

var client = new HttpClient()
{
    BaseAddress = new Uri("http://localhost:5139/api/")
};

GamesApiService service = new(client);

var games = await service.GetGamesAsync();
var game = await service.GetGameAsync(3);

game.Description = "aoaoao";
await service.UpdateGameAsync(game);

game = new()
{
    Title = "Satisfactory",
    Description = "Работа на заводе",
    PublicationYear = 2024,
    Price = 1300
};
await service.CreateGameAsync(game);
Console.WriteLine();

