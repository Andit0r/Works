string enteredString = Console.ReadLine();
int count = 0;
string[] strings =
{
    "hello!",
    "mimimamamu",
    "blinblin",
    "mama"
};

foreach (string s in strings)
{
    if (s.Contains(enteredString))
    {
        Console.WriteLine(s);
        count++;
    }
}

if (count == 0)
    Console.WriteLine("Ничего не найдено");
