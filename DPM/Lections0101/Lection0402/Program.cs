using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

Console.WriteLine("MS Office");
//WordWork();

using (ExcelManager excel = new()) 
{
    var fileName1 = Path.Combine(Environment.CurrentDirectory, "1.xlsx");
    var fileName2 = Path.Combine(Environment.CurrentDirectory, "3.xlsx");
    excel.SaveAs(fileName1, fileName2 );
}

void ExcelWork()
{
    var app = new Excel.Application(); // запуск excel
    app.Visible = true;


    var fileName = Path.Combine(Environment.CurrentDirectory, "1.xlsx");
    var document = app.Workbooks.Open(fileName);
    //var document = app.Workbooks.Add();

    // ... работа с документом (чтение/редактирование)

    //document.Save(); // для открытых

    var saveFileName = Path.Combine(Environment.CurrentDirectory, "2.html");
    //document.SaveAs(saveFileName);
    document.SaveAs(saveFileName, Excel.XlFileFormat.xlHtml);
    app.Quit();
}

void WordWork()
{
    var app = new Word.Application(); // запуск excel
    app.Visible = true;


    var fileName = Path.Combine(Environment.CurrentDirectory, "1.docx"); 
    var document = app.Documents.Open(fileName);
    //var document = app.Workbooks.Add();

    // ... работа с документом (чтение/редактирование)

    //document.Save(); // для открытых

    var saveFileName = Path.Combine(Environment.CurrentDirectory, "2.pdf");
    //document.SaveAs(saveFileName);
    document.SaveAs(saveFileName, Word.WdSaveFormat.wdFormatPDF);
    app.Quit();
}

