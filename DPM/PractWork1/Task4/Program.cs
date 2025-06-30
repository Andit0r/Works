string folder = Console.ReadLine();

DirectoryInfo directory = new(@"C:\Temp\ispp31\DPM\PractWork1\Task4\$");
FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);

foreach (var file in files)
    Console.WriteLine($"{file.FullName} {GetSize(file.Length)}");

static string GetSize(long bytes)
{
    if (bytes >= (1 << 30))
        return $"{bytes >> 30} ГБ";
    if (bytes >= (1 << 20))
        return $"{bytes >> 20} МБ";
    if (bytes >= (1 << 10))
        return $"{bytes >> 10} КБ";

    return $"{bytes} Б";
}