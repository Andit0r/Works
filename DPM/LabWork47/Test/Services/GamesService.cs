using DbLibrary.Models;
using DbLibrary.Repository;

namespace DbLibrary.Services
{
    public class GamesService(GamesRepository repository)
    {

        GamesRepository _repository = repository;

        public IEnumerable<Game> GetAll()
        {
            Console.WriteLine("Получение данных из таблицы Games...");

            var games = _repository.GetAll();

            Console.WriteLine("Получение завершено.");

            return games;
        }

        public Game GetById(int id)
        {
            Console.WriteLine("Получение объекта из таблицы Game...");

            var game = _repository.GetById(id) ?? throw new KeyNotFoundException();

            Console.WriteLine("Получение завершено.");

            return game;
        }

        public void Create(Game game)
        {
            Console.WriteLine("Выполняется добавление строки в таблицу Game...");

            if (IsIncorrectData(game))
                throw new ArgumentException();

            _repository.Create(game);

            Console.WriteLine("Добавление завершено.");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Выполняется обновление строки в таблицы Game...");

            if (IsIncorrectData(game))
                throw new ArgumentException();

            _repository.Update(game);

            Console.WriteLine("Обновление строки завершено.");
        }

        public void Delete(int id)
        {
            Console.WriteLine("Удаление строки из таблицы Game...");

            _repository.Delete(id);

            Console.WriteLine("Удаление завершено.");
        }

        private static bool IsIncorrectData(Game game)
        {
            return string.IsNullOrEmpty(game.Title)
                || game.Price < 0
                || game.PublicationYear > DateTime.Now.Year;
        }
    }
}
