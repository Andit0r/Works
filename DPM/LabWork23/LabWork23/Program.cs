using LabWorkLibrary;

Console.WriteLine(Maths.Add(6, 2));
Console.WriteLine(Maths.Subtract(6, 2));
Console.WriteLine(Maths.Multiply(6, 2));
Console.WriteLine(Maths.Divide(5, 3));
Console.WriteLine(Maths.GetRectangleArea(-6, 2));
Console.WriteLine(Maths.BinaryFactor);

User user = new();
user.Login = "admin";
user.Password = "admin";
user.Role = (Role)1;


