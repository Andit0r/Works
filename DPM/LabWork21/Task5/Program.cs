Dictionary<int, long> factorials = new();
Console.WriteLine(factorial(4));

foreach(var obj in factorials)
    Console.WriteLine(obj);

int factorial(int n)
{
    if(factorials.Keys.Contains(n))
        return factorials[n];
    int result = n < 0 ? -1 : n == 0 ? 1 : n * factorial(n - 1);
    factorials.Add(n, result);
    return result;
}