using Excel = Microsoft.Office.Interop.Excel;

WritePathInfo(@"C:\Temp\ispp31\DPM\PractWork2\Task2", "test");

static void WritePathInfo(string directoryPath, string fileName)
{
    var app = new Excel.Application();
    app.Visible = true;
    var pattern = Path.Combine(Environment.CurrentDirectory, "Шаблон.xlsx");
    var document = app.Workbooks.Add(pattern);

    var filesInfo = app.Sheets[1];
    var subFolders = app.Sheets[2];

    var files = Directory.GetFiles(directoryPath);
    FileInfo fileInfo;
    for (var i = 0; i < files.Length; i++)
    {
        fileInfo = new(files[i]);
        filesInfo.Cells[i + 2, 1] = i + 1;
        filesInfo.Cells[i + 2, 2] = fileInfo.Name;
        filesInfo.Cells[i + 2, 3] = fileInfo.Length;
    }

    var directories = Directory.GetDirectories(directoryPath);
    DirectoryInfo directoryInfo;
    for (var i = 0; i < directories.Length; i++)
    {
        directoryInfo = new(directories[i]);
        subFolders.Cells[i + 2, 1] = i + 1;
        subFolders.Cells[i + 2, 2] = directoryInfo.Name;
    }
    var saveFile = Path.Combine(Environment.CurrentDirectory, fileName);
    document.SaveAs(saveFile, Excel.XlFileFormat.xlWorkbookDefault);
    app.Quit();
}