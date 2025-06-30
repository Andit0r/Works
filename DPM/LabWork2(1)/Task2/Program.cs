void BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i; j < array.Length - 1; j++)
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        ShowArray(array);
    }
}

static void ShowArray(int[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    Console.WriteLine("\n");
}

int[] array = { 7, 0, -4, 3, 1, -2, 5 };
ShowArray(array);
BubbleSort(array);
