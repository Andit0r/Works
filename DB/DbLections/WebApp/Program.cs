using WebApiServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var client = new HttpClient()
{
    BaseAddress = new Uri("http://localhost:5047/api/")
};
builder.Services.AddSingleton<ReviewsApiService>(new ReviewsApiService(client));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
