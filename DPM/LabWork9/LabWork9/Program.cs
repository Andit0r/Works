Patient patient = new();
EquilateralTriangle triangle = new(5);

patient.Print();
triangle.Print();
triangle.WriteInfo();
Console.WriteLine(triangle.GetArea());
Console.WriteLine(triangle.GetPerimeter());

Console.WriteLine();
IPrinter printer1;
printer1 = patient;
printer1.Print();
printer1 = triangle;
printer1.Print();

Console.WriteLine();
IPrinter[] printers =
{
    new Patient("Андреев Андрей Андреевич", 68942, 2004),
    new Patient("Михаилов Михаил Михаилович", 123478, 2003),
    new EquilateralTriangle(8),
    new EquilateralTriangle(3),
};

foreach (var printer in printers)
{
    printer.Print();
    if (printer is IFigure figure)
        Console.WriteLine($"Название фигуры: {figure.Name}");
}
