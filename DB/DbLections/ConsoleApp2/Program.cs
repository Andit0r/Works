using WebApiServices;

Console.WriteLine("console app 2");

var client = new HttpClient()
{
    BaseAddress = new Uri("http://localhost:5047/api/")
};

ReviewsApiService service = new(client);
try
{
    var reviews = await service.GetReviewsAsync();
    var review = await service.GetReviewAsync(2);
    review.Comment = "asd";
    await service.UpdateReviewAsync(review);
    await service.DeleteReviewAsync(2);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();