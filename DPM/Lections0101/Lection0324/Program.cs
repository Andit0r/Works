
Task task1 = Task.Run(() => ShowFactorial(3)); // CPU
Task task2 = ShowFactorialAsync(6); // I/O
await ShowFactorialAsync(6);

//await Task.WhenAll(task1, task2);

//await Task.WhenAll([task1, task2]);

//List<Task> tasks = [task1, task2];
//await Task.WhenAll(tasks);


//var task1 = GetFactorialAsync(5);
//var task2 = GetFactorialAsync(3);
//var task3 = GetFactorialAsync(6);

//var results = await Task.WhenAll(task1, task2, task3);

//foreach (var result in results)
//    Console.WriteLine(result);

CancellationTokenSource cts = new();
cts.CancelAfter(2000);

CancellationToken token = cts.Token;

await Task.Run(async () =>
{
    if (token.IsCancellationRequested)
        token.ThrowIfCancellationRequested();

    Console.WriteLine("start 1");
    await Task.Delay(3000, cts.Token);
    Console.WriteLine("finish 1");
}, cts.Token);



//var json = await GetJsonAsync("example.com");
//Console.WriteLine(json);

//Console.WriteLine("end");

/*
await Task.Run(() => ShowFactorial(5));

long f = await Task.Run(() => GetFactorial(6));

Console.WriteLine(f);
*/

static async Task<string> GetJsonAsync(string url)
{
    Console.WriteLine("start");
    await Task.Delay(30000);
    Console.WriteLine("finish");
    return "[ ]";
}
static async Task ShowFactorialAsync(int n)
{
    await Task.Run(() => ShowFactorial(n));
}

static void ShowFactorial(int n)
{
    long result = 1;
    for (int i = 2; i <= n; i++)
        result *= i;
    Console.WriteLine($"{n}! = {result}");
}

static long GetFactorial(int n)
{
    long result = 1;
    for (int i = 2; i <= n; i++)
        result *= i;
    return result;
}

static async Task<string> GetFactorialAsync(int n)
{
    return $"{n}! = {GetFactorial(n)}";
}

static async Task<string> ReadFileAsync(string fileName)
{
    using StreamReader reader = new(fileName);
    return await reader.ReadToEndAsync();
}