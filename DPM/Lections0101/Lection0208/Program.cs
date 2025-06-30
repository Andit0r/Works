using System.ComponentModel;
#region generic
Print(123);
Print("123");
Print(123.0);

Print<double>(123.0);

int a = 5, b = 10;

Swap(ref a, ref b);
Console.WriteLine($"a:{a} b:{b}");

Console.WriteLine($"min = {GetMin(a, b)}");

static T GetMin<T>(T x, T y)
    where T : IComparable, IComparable<T>
{
    return x.CompareTo(y) < 0 ? x : y;
}

static void Print<T>(T item) 
    => Console.WriteLine($"{item} - {item?.GetType()}");

static void Swap<T>(ref T item1, ref T item2) 
    => (item1, item2) = (item2, item1);
Console.WriteLine();
#endregion

List<string> users = new() { "admin", "user", "student" };
users.Add("guest");
users.AddRange(["guest1", "guest2"]);

users.Insert(0, "guest");
users.InsertRange(2, ["guest1", "guest2"]);

users.Remove("guest");
users.RemoveAt(2);
users.RemoveAt(users.Count - 1);
users.RemoveRange(0, 3);
users.Clear();
users.RemoveAll(u => u.StartsWith("guest"));

if(users.Contains("admin"))
    Console.WriteLine("admin finded");

int firstIndex = users.IndexOf("admin");
int lastIndex = users.LastIndexOf("admin");

Dictionary<int, string> products = new();
products[100] = "tea";
products[200] = "coffee";
products[300] = "milk";
foreach(var product in products)
    Console.WriteLine($"{product.Key} - {product.Value}");

foreach(var key in products.Keys)
    Console.WriteLine($"{key} - {products[key]}");

foreach(var value in products.Values)
    Console.WriteLine($" - {value}");

foreach (var user in users)
    Console.WriteLine(user);

Console.WriteLine();

struct Triangle
{
    public Triangle(int sideA, int sideB, int sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public int SideA { get; set; }
    public int SideB { get; set; }
    public int SideC { get; set; }
    public string Name
    {
        get => "треугольник";
    }

    public int GetPerimeter()
    {
        return SideA + SideB + SideC;
    }
}
