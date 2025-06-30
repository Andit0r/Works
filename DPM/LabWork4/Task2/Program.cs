using System.Diagnostics;

int LocalMax(int[] values)
{
    int max = 0;
    int lastIndex = values.Length - 1;

    if (values[0] > values[1])
        max = values[0];
    for (int i = 1; i < values.Length - 2; i++)
    {
        if (values[i] > values[i - 1] && values[i] > values[i + 1])
        {
            max = values[i];
            break;
        }
    }
    if (values[lastIndex] > values[lastIndex - 1])
        max = values[lastIndex];


    return max;
}

int[] values = { 1, 3, 6, 5, 80 };
Debug.Assert(LocalMax(values) == 80);
Debug.Assert(LocalMax(values) == 50);
