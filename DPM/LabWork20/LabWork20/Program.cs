var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

List<Cat> cats = new List<Cat>
{
    new Cat { Id = 1, Name = "Усатик", Breed = "Персидская", Color = "Белый", Age = 5 },
    new Cat { Id = 2, Name = "Варежка", Breed = "Сиамская", Color = "Сил-пойнт", Age = 3 },
    new Cat { Id = 3, Name = "Дымок", Breed = "Британская короткошерстная", Color = "Серый", Age = 7 },
    new Cat { Id = 4, Name = "Белла", Breed = "Мейн-кун", Color = "Рыжий", Age = 4 },
    new Cat { Id = 5, Name = "Макс", Breed = "Рэгдолл", Color = "Сил-миттед", Age = 2 },
    new Cat { Id = 6, Name = "Луна", Breed = "Персидская", Color = "Трехцветный", Age = 6 },
    new Cat { Id = 7, Name = "Оливер", Breed = "Британская короткошерстная", Color = "Черный", Age = 8 },
    new Cat { Id = 8, Name = "Клео", Breed = "Сиамская", Color = "Коричневый", Age = 3 },
    new Cat { Id = 9, Name = "Симба", Breed = "Мейн-кун", Color = "Рыжий", Age = 5 },
    new Cat { Id = 10, Name = "Ромашка", Breed = "Персидская", Color = "Белый", Age = 2 }
};

app.MapGet("/cats", (int page, int count) =>
{
    var results = cats.Skip((page - 1) * count).Take(count);
    if (results == null)
        return Results.NotFound();

    return Results.Ok(results);
});

app.MapGet("/cats/{id:int}", (int id) =>
{
    var result = cats.FirstOrDefault(c => c.Id == id);
    if (result == null)
        return Results.NotFound();

    return Results.Ok(result);
});

app.MapGet("/cats/{breed}", (string breed) =>
{
    var results = cats.Where(c => c.Breed == breed);
    if (results == null)
        return Results.NotFound();

    return Results.Ok(results);
});

app.MapPost("/cats", (string name, string breed, string color, int age) =>
{
    cats.Add(new Cat { Id = cats.Count + 1, Name = name, Breed = breed, Color = color, Age = age });

});

app.MapDelete("/cats/{id}", (int id) =>
{
    var cat = cats.FirstOrDefault(c => c.Id == id);
    if (cat == null)
        return Results.NotFound();

    cats.Remove(cat);

    return Results.Ok(cats);
});

app.Run();
