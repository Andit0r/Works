var patient1 = new Patient();
var patient2 = new Patient("Михаилов Михаил Михаилович", 43256, 2003);
patient1.BirthYear = -3;

patient1.Print();
Console.WriteLine();
patient2.Print();
Console.WriteLine();

Patient[] patients =
[
    new Patient("Максимов Максим Максимович", 321425, 2005),
    new Patient("Дорофеев Олег Максимович", 32123465, 2007),
    new Patient("Кузнецов Саня Олегович", 321342925, 2006),
    new Patient("Ефремов Константин Антонович", 321124325, 2002),
];

int searchYear = 2007;
string searchFullName = "Кузнецов Саня Олегович";

foreach (var patient in patients)
{
    if (searchYear == patient.BirthYear)
    {
        patient.Print();
    }
}

Console.WriteLine();

foreach (var patient in patients)
{
    if (searchFullName == patient.FullName)
    {
        patient.Print();
    }
}

