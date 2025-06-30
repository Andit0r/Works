Console.WriteLine("Lection 17/01");

static int GetElement(int[] numbers, int index)
{
    return numbers[index]; // O(1)
}
static int GetElement2(int[] numbers, int index)
{
    int element = numbers[index]; // O(1)
    return numbers[index]; // O(1)
}

// O(n^2)
static int GetSum2d(int[,] numbers)
{
    int sum = 0; // O(1)

    for (int i = 0; i < numbers.GetLength(0); i++) // O(n)
        for (int j = 0; j < numbers.GetLength(1); j++) // O(n)
            sum += numbers[i, j]; // O(1)

    return sum; // O(1)
}

static int GetMax(int[] numbers)
{
    int max = numbers[0];
    for (int i = 1; i < numbers.Length; i++) // O(n)
        if (numbers[i] > max)
            max = numbers[i];
    return max;
}

static int GetMaxElementsSum(int[][] numbers)
{
    int sum = 0;
    for (int i = 1; i < numbers.Length; i++) // O(n)
        sum += GetMax(numbers[i]); // O(n)
    return sum;
}