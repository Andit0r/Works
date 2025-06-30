Patient[] patients =
{
new Patient("Андреев Андрей Андреевич", 68942, 2004),
new Patient("Михаилов Михаил Михаилович", 123478, 2003),
new Patient("Иванов Иван Иванович", 676767, 2001),
new Patient("Игорев Игорь Игоревич", 939393, 2008),
new Patient("Игорев Игорь Игоревич", 939393, 2008)
};

Patient patient1 = new("Игорев Игорь Игоревич", 939393, 2008);
Patient patient2 = new("Игорев Игорь Игоревич", 939393, 2008);
Patient patient3 = (Patient)patient2.Clone();


Array.Sort(patients);
foreach(var patient in patients)
    Console.WriteLine(patient);

Console.WriteLine(patient1.Equals(patient2));
Console.WriteLine(patient3);

int[] numbers = { 4, 7, 2, 9, 123, 42 };
string[] words = { "hello", "goodbye", "bye" };
Array.Sort(numbers, new DescendingComparer());

foreach(var number in numbers)
    Console.Write(number + " ");

Console.WriteLine();
Array.Sort(words, new StringComparer());
foreach (var word in words)
    Console.Write(word + " ");

