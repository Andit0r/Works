Patient patient1 = new();
Patient patient2 = new();
patient1.GetInfo();

patient1++;
patient2++;
patient1.GetInfo();

Patient patient3 = patient1 + patient2;
patient3.GetInfo();

Console.WriteLine();
Console.WriteLine(patient1 == patient2);
Console.WriteLine(patient1 != patient2);

Console.WriteLine();
if (patient1)
    Console.WriteLine("BirthYear > 0");
else
    Console.WriteLine("BirthYear < 0");