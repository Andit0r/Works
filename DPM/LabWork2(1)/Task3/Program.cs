void InsertionSort(int[] array)
{
    int temp;
    for (int i = 1; i < array.Length; i++)
    {
        temp = array[i];

        int j = i - 1;

        while (j >= 0 && array[j] > temp)
        {
            array[j + 1] = array[j];
            j = j - 1;
        }
        array[j + 1] = temp;
    }
    ShowArray(array);
}

void ShowArray(int[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    Console.WriteLine("\n");
}

int[] array = { 7, 0, -4, 3, 1, -2, 5 };
ShowArray(array);

InsertionSort(array);


