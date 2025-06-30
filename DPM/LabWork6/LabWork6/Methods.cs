class Methods
{
    public static double GetPerimeter(double side)
        => side * 4;

    public static double GetPerimeter(double lenght, double width)
        => (lenght + width) * 2;

    public static double Exponentiation(double x, int n)
    {
        if (n < 0)
            return -1;

        double value = 1;

        for (int i = 0; i < n; i++)
            value *= x;

        return value;
    }

    public static double Exponentiation(double x)
        => x * x;
}