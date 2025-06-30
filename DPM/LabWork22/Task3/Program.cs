await Task.WhenAll(ReadFileAsync("random1.txt"), ReadFileAsync("random2.txt"), ReadFileAsync("random3.txt"));

static async Task ReadFileAsync(string fileName)
{
    Console.WriteLine($"чтение из файла {fileName} начато");
    using (StreamReader reader = new(fileName))
    {
        string? line;
        while ((line = await reader.ReadLineAsync()) != null)
        {
            Console.WriteLine($"{fileName}: {line}");
        }
    }
    Console.WriteLine($"чтение из файла {fileName} закончено");
}