Patient patient1 = new();
Patient patient2 = new();

Console.WriteLine(patient1);
Console.WriteLine(patient1.Equals(patient2));

Console.WriteLine();
Square square = new(5);
Console.WriteLine(square.GetArea());
Console.WriteLine(square.GetPerimeter());
square.GetInfo();
Console.WriteLine(square.Name);

ExtensionRandom arrayRandom = new();
bool[,] array = arrayRandom.NextBools(3, 4, 33);

for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + " ");
}