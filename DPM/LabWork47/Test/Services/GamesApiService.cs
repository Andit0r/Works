using DbLibrary.Models;
using System.Net.Http.Json;

namespace DbLibrary.Services
{
    public class GamesApiService(HttpClient client)
    {
        private readonly HttpClient _client = client;

        public async Task<IEnumerable<Game>?> GetGamesAsync()
            => await _client.GetFromJsonAsync<IEnumerable<Game>>("Games");

        public async Task<Game?> GetGameAsync(int id)
            => await _client.GetFromJsonAsync<Game?>($"Games/{id}");

        public async Task CreateGameAsync(Game game)
        {
            var response = await _client.PostAsJsonAsync($"Games", game);
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateGameAsync(Game game)
        {
            var response = await _client.PutAsJsonAsync($"Games/{game.Id}", game);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteGameAsync(int id)
        {
            var response = await _client.DeleteAsync($"Games/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
