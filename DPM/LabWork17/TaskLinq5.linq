<Query Kind="Statements" />

DirectoryInfo directory = new DirectoryInfo(@"C:\Temp\ispp31\DPM");
FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);

var nameFiles7 = files
    .Select(f => new { f.Name, f.DirectoryName, f.Extension, Size = f.Length < (1 << 10) ? 
	$"{f.Length} байт" : f.Length < (1 << 20) ? 
	$"{f.Length / (1 << 10)} КБ" : $"{f.Length / (1 << 20)} МБ" })
	.Dump();