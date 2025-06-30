<Query Kind="Statements" />

DirectoryInfo directory = new DirectoryInfo(@"C:\Temp\ispp31\DPM");
FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);

var lastTenFiles = files
	.Where(f => f.CreationTime.Date == DateTime.Now.Date)
	.OrderByDescending(f => f.CreationTime)
	.Take(10)
	.Dump();