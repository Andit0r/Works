class ExtensionRandom : Random
{
    public bool[,] NextBools(int rows, int cols, double falsePercentage)
    {
        bool[,] array = new bool[rows, cols];
        falsePercentage /= 100;

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                array[i, j] = NextDouble() >= falsePercentage;

        return array;
    }
}