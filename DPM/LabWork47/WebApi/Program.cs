using DbLibrary.Database;
using DbLibrary.Repository;

var builder = WebApplication.CreateBuilder(args);

// Db work
string connectionString = "Data Source=mssql;Initial Catalog=ispp3108;Persist Security Info=True;User ID=ispp3108;Password=3108;Trust Server Certificate=True";
builder.Services.AddSingleton<IDbConnectionFactory>(new MsSqlFactory(connectionString));
builder.Services.AddScoped<GamesRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
