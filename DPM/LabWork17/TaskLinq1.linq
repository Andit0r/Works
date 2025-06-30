<Query Kind="Statements" />

DirectoryInfo directory = new DirectoryInfo(@"C:\Temp\ispp31\DPM");
FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);

var nameFiles = files
	.Select(f => new { f.Name, f.DirectoryName, f.Length, f.CreationTime })
    .OrderBy(f => f.Name)
    .ThenByDescending(f => f.CreationTime)
	.Dump();
	
Console.WriteLine("Введите искомый текст");
string enteredString = Console.ReadLine();

var nameFiles2 = files
    .Where(f => f.Name.Contains(enteredString));

var nameFiles3 = files
    .Where(f => f.Name.Contains(enteredString)).Count();