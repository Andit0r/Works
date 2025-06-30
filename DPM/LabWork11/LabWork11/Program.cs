#region pets
List<string> pets = ["Собака", "Кошка", "Свинья"];

Console.WriteLine("Введите кол-во, которое хотите добавить:");
uint petsCount = Convert.ToUInt32(Console.ReadLine());

for (int i = 0; i < petsCount; i++)
{
    Console.WriteLine("Введите название питомца:");
    pets.Add(Console.ReadLine());
}

for (int i = 0; i < pets.Count; i++)
    Console.WriteLine($"{i + 1} - {pets[i]}");
#endregion

#region products
Dictionary<string, uint> products = new()
{
    ["Хлеб"] = 130,
    ["Пирог"] = 130,
    ["Молоко"] = 80,
    ["Сыр"] = 45
};

Console.WriteLine("Введите кол-во, которое хотите добавить:");
uint productsCount = Convert.ToUInt32(Console.ReadLine());

for (int i = 0; i < productsCount; i++)
{
    Console.WriteLine("Введите название товара:");
    string product = Console.ReadLine();
    Console.WriteLine("Введите цену товара:");
    uint cost = Convert.ToUInt32(Console.ReadLine());
    products[product] = cost;
}

foreach (var product in products)
    Console.WriteLine($"{product.Key} - {product.Value}");
Console.WriteLine($"Количество элементов: {products.Count}");
#endregion

#region task3
Console.WriteLine("Введите искомый ключ:");
string findKey = Console.ReadLine();

if (products.ContainsKey(findKey))
    Console.WriteLine($"Содержится, {products[findKey]}," +
        $"{products.ContainsValue(products[findKey])}");
else
    Console.WriteLine("Ключ отсутствует");

Console.WriteLine("Введите цену товара:");
uint productCost = Convert.ToUInt32(Console.ReadLine());
int count = 0;

foreach (var cost in products.Values)
    if (productCost == cost)
        count++;

Console.WriteLine($"Количество совпадений значения: {count}");

Console.WriteLine("Введите ключ, который хотите удалить:");
string deletedKey = Console.ReadLine();

products.Remove(deletedKey);

foreach (var product in products)
    Console.WriteLine($"{product.Key} - {product.Value}");
#endregion

#region task4
Console.WriteLine("Введите начальную позицию");
int firstIndex = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечную позицию");
int lastIndex = Convert.ToInt32(Console.ReadLine());

if (firstIndex < 0 || lastIndex >= pets.Count || firstIndex > lastIndex)
    Console.WriteLine("Некорректные данные");
else
    for (int i = firstIndex; i <= lastIndex; i++)
        Console.WriteLine($"{pets[i]}");
#endregion





