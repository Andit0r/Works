using System.Diagnostics;

int JumpSearch(int[] array, int value)
{
    int previous = 0;
    int n = array.Length;
    int jumpStep = (int)Math.Sqrt(n);

    while (array[Math.Min(jumpStep, n) - 1] < value)
    {
        previous = jumpStep;
        jumpStep += (int)Math.Sqrt(n);
        if (previous >= n)
            return -1;
    }

    for (int i = previous; i < Math.Min(jumpStep, n); i++)
        if (array[i] == value)
            return i;
    return -1;
}

int[] array = { 322, 46, 13, 98, 45 };
Array.Sort(array); // int[] array = { 13, 45, 46, 98, 322 };

Console.WriteLine("Введите число:");
int value = Convert.ToInt32(Console.ReadLine());
Debug.Assert(JumpSearch(array, value) == 2);


