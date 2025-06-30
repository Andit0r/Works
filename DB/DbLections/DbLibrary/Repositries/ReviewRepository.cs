using Dapper;
using DbLibrary.Database;
using DbLibrary.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DbLibrary.Repositries
{
    public interface IReviewRepository
    {
        Review? GetReview(int id);
        IEnumerable<Review> GetReviews();
        void UpdateReview(Review review);
    }

    public class ReviewRepository(IDatabaseFactory factory) : IReviewRepository
    {
        private readonly IDbConnection _db = factory.CreateConnection();

        public IEnumerable<Review> GetReviews()
            => _db.Query<Review>("SELECT * FROM Review");

        public Review? GetReview(int id)
            => _db.QueryFirstOrDefault<Review>("SELECT * FROM Review WHERE Id=@id;", new { id });

        public void UpdateReview(Review review)
            => _db.Execute("UPDATE Review SET Comment=@Comment WHERE Id=@Id;", review);
    }
}
