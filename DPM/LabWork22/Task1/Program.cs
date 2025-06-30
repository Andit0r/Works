Console.WriteLine("Последовательный асинхронный вызов:");
await Task.Run(() => Power(3, 4));
await Task.Run(() => Power(2, -2));
await Task.Run(() => Power(4, 1));
Console.WriteLine();

Console.WriteLine("Параллельный асинхронный вызов:");
var task1 = Task.Run(() => Power(4, 3));
var task2 = Task.Run(() => Power(2, -4));
var task3 = Task.Run(() => Power(1, 4));
await Task.WhenAll(task1, task2, task3);

void Power(double a, int x)
{
    Console.WriteLine($"{a}^{x}={Math.Pow(a, x)}");
}