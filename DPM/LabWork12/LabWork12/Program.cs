Patient patient1 = new();
Patient patient2 = new("Alex Smith", 123456789, 2003);

patient1.Print();
patient2.Print();

patient2.BirthYear = -3;
patient2.FullName = "Alex Alexovich";

Patient[] patients =
{
    new Patient("John Doe", 123456789, 2000),
    new Patient("Alex Smith", 12345678, 2001),
    new Patient("Maria Smith", 1234567, 2002),
};

Console.WriteLine();
foreach (var patient in patients)
    if (patient.Category == Category.Adult)
        patient.Print();

Pet pet1 = new("Misha", "Husky", 7);
Pet pet2 = new("Danya", "Chihuahua", 3);
Pet pet3 = new("Danya", "Chihuahua", 3);

Console.WriteLine();
Console.WriteLine(pet1);
Console.WriteLine(pet2);
Console.WriteLine(pet3);
Console.WriteLine($"pet1 == pet2: {pet1 == pet2}");
Console.WriteLine($"pet1.Equals(pet2): {pet1.Equals(pet2)}");
Console.WriteLine($"pet2 == pet3: {pet2 == pet3}");