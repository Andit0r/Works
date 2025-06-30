Console.WriteLine("methods");

var login = "admin";
login = login.FormatName(); // параметр.МетодРасширения()
Console.WriteLine(login);

double x = 5.5;
int y = x.ToInt();
Console.WriteLine(y);

Add(b: 5, a: 2); // 5+2=7
Subtract(5, 2); // 5-2=3
Subtract(a: 5, b: 2); //5-2=3
Subtract(b: 2, a: 5); //2-5=3

static int Add(int a, int b = 1) => a + b;

static int Subtract(int a, int b = 1) => a - b;

x = Add(5, 2); // x=7
x = Add(y, 3); // x=8

static void PrintValueInfo(params object[] values)
{
    foreach(object value in values) 
        Console.WriteLine($"{value} - {value.GetType()}");
    Console.WriteLine();
}

PrintValueInfo(x, y);
PrintValueInfo(12, "asd", 0.1, true);
PrintValueInfo([12, "asd", 0.1, true]);

static void GetAbs(ref double x)
{
    if (x < 0)
        x = -x;
}

x = -50;
Console.WriteLine(x);
GetAbs(ref x);
Console.WriteLine(x);

static void Swap(ref int x, ref int y)
{
    (x, y) = (y, x);
}

int a = 5, b = 2;
Swap(ref a, ref b);

int count;
Int32.TryParse("123", out count);
Console.WriteLine(count); // 123

Int32.TryParse("123abc", out count);
Console.WriteLine(count); // 0

void Sum(int a, int b, out int sum)
{
    sum = a + b;
}

Sum(3, 6, out a); // a = 3+6=9
