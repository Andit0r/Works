await WriteRandomNumberAsync("random.txt", 100000);
Console.WriteLine("Конец программы");

static async Task WriteRandomNumberAsync(string fileName, int numbersCount)
{
    Random random = new();

    Console.WriteLine($"Запись в файл {fileName} начата");
    using (StreamWriter writer = new(fileName, false))
    {
        for (int i = 1; i <= numbersCount; i++)
            await writer.WriteLineAsync($"Число {i}: {random.Next()}");
    }
    Console.WriteLine($"Запись в файл {fileName} закончена");
}