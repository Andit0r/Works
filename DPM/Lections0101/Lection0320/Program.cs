Console.WriteLine();

int n = 5;
//var x = Math.Pow(n, 2);
int x = n * n;

//x = 1024 * n; // 1024=2^10
x = n << 10;

int bits = 800;
//int bytes = bits / 8; //8=2^3
int bytes = bits >> 3;

double GetPower(double x, int n)
{
    if (n == 0)
        return 1;
    if (n < 0)
        return 1 / GetPower(x, -n);
    return x * GetPower(x, n - 1);
}

var lines = File.ReadAllLines("1.txt");

StreamReader reader = new("1.txt");
string? line;
while ((line = reader.ReadLine()) != null)
{
    ;
}


