var numbers = Enumerable.Range(1, 5).ToList();

List<string> users = [ "admin", "user1", "user2" ];

List<Cat> cats =
[
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
];

var cats1 = cats.Select(cat => cat.Name).ToList;
var cats2 = cats.Select(cat => new { cat.Name, cat.Age }).ToList;
var cats3 = cats.Select(cat => new CatDto { Name = cat.Name, Breed = cat.Breed }).ToList;


Console.WriteLine();

var numbers1 = numbers.Where(x => x % 2 == 0).ToList();
var users1 = users.Where(u => u.StartsWith("user")).ToList();

var cats4 = cats.Where(cat => cat.Breed == "Сиамская").ToList();
var cats5 = cats.Where(cat => cat.Breed == "Сиамская" && cat.Age < 5).ToList();

var cats6 = cats.Where(cat => cat.Color == "Рыжий"); // цвен выбран всегда
cats6 = cats6.Where(cat => cat.Age < 30); // если выбран возраст
cats6 = cats6.Where(cat => cat.Breed == "Мейн-кун"); // если выбрана порода
cats6 = cats6.AsEnumerable();

var cats7 = cats.AsEnumerable();
cats7 = cats7.Where(cat => cat.Age < 3); // если выбран возраст
cats7 = cats7.Where(cat => cat.Breed == "Мейн-кун"); // если выбрана порода

var cats8 = cats
    .Where(cat => cat.Age < 3)
    .Where(cat => cat.Breed == "Мейн-кун");

var cats9 = cats.OrderBy(cat => cat.Name).ToList();
var cats10 = cats.OrderByDescending(cat => cat.Name).ToList();

var cats11 = cats
    .OrderByDescending(cat => cat.Breed)
    .ThenByDescending(cat => cat.Age)
    .ThenBy(cat => cat.Name)
    .ToList();

Console.WriteLine();

int pageSize = 3; // pageSize / elementsCount
int currentPage = 1;

var Cats = cats
    .Skip((currentPage - 1) * pageSize)
    .Take(pageSize);

int lastPage = (int)Math.Ceiling(1.0 * cats.Count() / pageSize);

cats.Count(c => c.Breed == "Персидская");
var maxAge = cats.Max(c => c.Age);
var names = cats.Sum(c => c.Age);

var multResult = numbers.Aggregate((x, y) => x * y);
Console.WriteLine();

var names2 = cats.Aggregate((x, y) => new Cat { Name = x.Name + ";" + y.Name }).Name;

var cats13 = cats
    .GroupBy(c => c.Color)
    .Select(group => new { Color = group.Key , Count = group.Count() })
    .ToList();

var cats14 = cats
    .GroupBy(c => new { c.Color , c.Breed })
    .Select(group => new { group.Key.Color, group.Key.Breed, Count = group.Count() })
    .ToList();

var cats15 = cats
    .Select(c => c.Breed)
    .Distinct();

var cats16 = cats.Select(c => c.Color)
    .Concat(cats.Select(c => c.Breed))
    .Distinct()
    .ToList();

bool areRed = cats.All(c => c.Color == "Рыжий");
bool notKitten = cats.All(c => c.Age > 1);

bool haveKitten = cats.Any(c => c.Age <= 1);
bool haveCats = cats.Any(); // 

var redCat1 = cats.FirstOrDefault(c => c.Color == "Рыжий");
var redCat2 = cats.LastOrDefault(c => c.Color == "Рыжий");
var redCat3 = cats.SingleOrDefault(c => c.Color == "Рыжий");