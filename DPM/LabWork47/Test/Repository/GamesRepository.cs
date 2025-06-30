using Dapper;
using DbLibrary.Database;
using DbLibrary.Models;
using System.Data;

namespace DbLibrary.Repository
{
    public class GamesRepository(IDbConnectionFactory connection)
    {
        private readonly IDbConnection _connection = connection.CreateConnection();

        public IEnumerable<Game> GetAll()
            => _connection.Query<Game>("SELECT * FROM Game");

        public Game? GetById(int id)
            => _connection.QueryFirstOrDefault<Game>("SELECT * FROM Game WHERE Id=@Id", new { id });

        public void Create(Game game)
            => _connection.Execute(@"INSERT INTO Game(Title
, Description
, Price
, PublicationYear) VALUES(@Title, @Description, @Price, @PublicationYear)", game);

        public void Update(Game game)
            => _connection.Execute(@"UPDATE Game SET Title=@Title
, Description=@Description
, PublicationYear=@PublicationYear
, Price=@Price WHERE Id=@Id", game);

        public void Delete(int id)
            => _connection.Execute("DELETE Game WHERE Id=@id", new { id });
    }
}
