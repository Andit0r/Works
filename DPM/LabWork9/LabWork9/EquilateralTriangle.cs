class EquilateralTriangle : IPrinter, IFigure
{
    public double Side { get; set; }

    public EquilateralTriangle(double side)
        => Side = side;

    public string Name
        => "равносторонний треугольник";

    public void Print()
        => Console.WriteLine($"Сторона: {Side}");

    public double GetArea()
        => (Side * Side * Math.Sqrt(3)) / 4;

    public double GetPerimeter()
        => Side * 3;

    public void WriteInfo()
        => Console.WriteLine($"Равносторонний треугольник со сторонами {Side}");
}