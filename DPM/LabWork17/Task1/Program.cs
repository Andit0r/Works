DirectoryInfo directory = new DirectoryInfo(@"C:\Temp\ispp31\DPM");
FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);

var nameFiles = files
    .OrderBy(f => f.Name)
    .ThenByDescending(f => f.CreationTime)
    .Select(f => new { f.Name, f.DirectoryName, f.Length, f.CreationTime }).ToList();

Console.WriteLine("Введите искомый текст");
string enteredString = Console.ReadLine();

var nameFiles2 = files
    .Where(f => f.Name.Contains(enteredString));

var nameFiles3 = files
    .Count(f => f.Name == enteredString);

var nameFiles4 = files
    .Select(f => f.Extension)
    .Distinct();

var nameFiles5 = files
    .GroupBy(e => e.Extension)
    .Select(group => new { Extension = group.Key, Count = group.Count() });

var nameFiles6 = files
    .Where(f => f.CreationTime.Date ==  DateTime.Now.Date)
    .OrderByDescending(f => f.CreationTime)
    .Take(10);

var nameFiles7 = files
    .Select(f => new { f.Name, f.DirectoryName, Size = f.Length < (1 << 10) ? 
    $"{f.Length} байт" : 
    f.Length < (1 << 20) ? 
    $"{f.Length / (1 << 10)} КБ" : 
    $"{f.Length / (1 << 20)} МБ" });

Console.WriteLine( 1024 / (1 << 10));