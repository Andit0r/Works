<Query Kind="Statements" />

DirectoryInfo directory = new DirectoryInfo(@"C:\Temp\ispp31\DPM");
FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);

var extensionFiles = files
    .Select(f => f.Extension)
    .Distinct();

var  = files
    .GroupBy(e => e.Extension)
    .Select(group => new { Extension = group.Key, Count = group.Count() });