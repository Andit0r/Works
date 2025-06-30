class Square : Figure
{
    public Square(double side)
    {
        Side = side;
    }

    public double Side { get; set; }

    public override double GetArea()
        => Side * Side;

    public override double GetPerimeter()
        => Side * 4;

    public override void GetInfo()
    {
        Console.WriteLine($"Квадрат со сторонами {Side}");
    }

    public override string Name
    {
        get => "квадрат";
    }
}