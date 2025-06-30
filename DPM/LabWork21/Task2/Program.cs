int n = 10;
int r1 = 3;
int r2 = 5;

double square = Math.PI * (r1 - r2) * (r1 + r2);
square = square > 0 ? square : -square;

int sum = (1 + n) * n / 2;

Console.WriteLine(square);
Console.WriteLine(sum);
Console.WriteLine(GetSize(2100000000));

static string GetSize(int bytes)
{
    if (bytes >= (1 << 30))
        return $"{bytes >> 30} ГБ";
    if (bytes >= (1 << 20))
        return $"{bytes >> 20} МБ";
    if (bytes >= (1 << 10))
        return $"{bytes >> 10} КБ";

    return $"{bytes} Б";
}