MathDelegate math = (x, y) => x + y;
int sum = math(2, 5);
Console.WriteLine(sum);

Action hello = () => Console.WriteLine("hello world");
hello += WriteCurrentDate;
hello();

Func<int, int> square = x => x * x;
int result = square(5);
Console.WriteLine(result);

Func<int, int, bool> areEquals = (x, y) => x == y;
if (areEquals(123, 234))
    Console.WriteLine("равны");

Predicate<int> isPositive = x => x > 0;
Console.WriteLine(isPositive(-5));
Console.WriteLine(isPositive(0));
Console.WriteLine(isPositive(5));

static void WriteCurrentDate()
{
    Console.WriteLine(DateTime.Now);
}
//List<string> list = new();
//list.Find(item => item.StartsWith("a"));
//list.Count(item => item.StartsWith("a"));