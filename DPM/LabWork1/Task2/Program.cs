using System.Diagnostics;

int BinarySearch(int[] array, int value)
{
    int left = 0;
    int right = array.Length - 1;

    while (left <= right)
    {
        int middle = left + (right - left) / 2;

        if (array[middle] == value)
            return middle;
        else if (array[middle] < value)
            left = middle + 1;
        else
            right = middle - 1;
    }

    return -1;
}

int[] array = { 322, 46, 13, 98, 45 };
Array.Sort(array); // int[] array = { 13, 45, 46, 98, 322 };

Console.WriteLine("Введите число:");
int value = Convert.ToInt32(Console.ReadLine());
Debug.Assert(BinarySearch(array, 13) == 0);
Debug.Assert(BinarySearch(array, 45) == 1);
Debug.Assert(BinarySearch(array, 46) == 2);
Debug.Assert(BinarySearch(array, 98) == 3);
Debug.Assert(BinarySearch(array, 322) == 4);
Debug.Assert(BinarySearch(array, 3233) == -1);
