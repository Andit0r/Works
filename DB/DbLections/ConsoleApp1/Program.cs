using DbLibrary.Database;
using DbLibrary.Models;
using DbLibrary.Repositries;
using DbLibrary.Services;
using System.Runtime.Serialization;

Console.WriteLine("console app 1");

string connectionString = "Data Source=mssql;Initial Catalog=ispp3108;Persist Security Info=True;User ID=ispp3108;Password=3108;Trust Server Certificate=True";
IDatabaseFactory factory = new MsSqlFactory(connectionString);

//IRepository<Review> repository = new ReviewsRepository(factory);
//var repository = new ReviewsRepository(factory);
//ReviewsRepository repository = new(factory);

//var reviews = repository.GetAll();
//var review = repository.GetById(30);

//review.Comment = "qwe qwe";
//repository.Update(review);

ReviewsRepository repository = new(factory);
ReviewsService service = new(repository);

var reviews = service.GetReviews();
var review = service.GetReview(3);

reviews = service.GetReviewsByGameId(1);

Console.WriteLine();