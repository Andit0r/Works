int[] numbers = { 3 };
FindSum(numbers);
Console.WriteLine(GetDaysCount(4, 2024));

void FindSum(int[] numbers)
{
    if (numbers.Length == 0)
        throw new InvalidOperationException("в массиве нет чисел");

    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
        sum += numbers[i];
    Console.WriteLine($"sum = {sum}");
}

int GetDaysCount(int month, int year)
{
    if (month > 12 || month < 1)
        return -1;

    switch (month)
    {
        case 4:
        case 6:
        case 9:
        case 11:
            return 30;
        case 2:
            return (year % 400 == 0 || year % 100 != 0 && year % 4 == 0) ? 29 : 28;
        default:
            return 31;
    }
}
