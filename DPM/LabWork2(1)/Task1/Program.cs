void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minimal = i;

        for (int j = i + 1; j < array.Length; j++)
            if (array[j] < array[minimal])
                minimal = j;

        if (minimal != i)
        {
            int temp = array[i];
            array[i] = array[minimal];
            array[minimal] = temp;
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
SelectionSort(array);


