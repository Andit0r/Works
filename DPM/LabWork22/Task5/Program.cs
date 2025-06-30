CancellationTokenSource cts = new();
cts.CancelAfter(2000);
await Task.Run(async () =>
{
    await Task.Delay(1000, cts.Token);
    await ReadFileAsync("random1.txt", cts.Token);
}, cts.Token);

static async Task ReadFileAsync(string fileName, CancellationToken token)
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