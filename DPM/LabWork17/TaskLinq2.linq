<Query Kind="Statements" />

DirectoryInfo directory = new DirectoryInfo(@"C:\Temp\ispp31\DPM");
FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);

Console.WriteLine("Введите искомый текст");
string enteredString = Console.ReadLine();

var searchedFiles = files
    .Where(f => f.Name.Contains(enteredString))
	.Dump();

var countSearchedFiles = files
	.Count(f => f.Name == enteredString)
	.Dump();