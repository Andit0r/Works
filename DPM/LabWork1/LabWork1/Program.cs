using System.Diagnostics;

int LinearSearch(int[] arr, int value)
{
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] == value)
            return i;
    return -1;
}

int[] array = { 3, 4, 5, 6, 45 };

Console.WriteLine("Введите число:");
int value = Convert.ToInt32(Console.ReadLine());
Debug.Assert(LinearSearch(array, value) == 2);

