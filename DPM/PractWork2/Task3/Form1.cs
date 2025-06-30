using Excel = Microsoft.Office.Interop.Excel;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateMultiplicationTableButton_Click(object sender, EventArgs e)
        {
            AddMultiplicationTableFile();
        }

        private static void AddMultiplicationTableFile()
        {
            var app = new Excel.Application();
            var document = app.Workbooks.Add();
            var sheet = document.Sheets[1];
            sheet.Name = "Умножение";
            var title = sheet.Range[sheet.Cells[9, 4], sheet.Cells[9, 12]];
            title.Merge();
            title.Value = "Таблица умножения";
            title.Font.Bold = true;
            title.Font.Italic = true;
            title.Font.Size = 20;
            title.HorizontalAligment = Excel.XlHAlign.xlHAlignCenter;

            for (int i = 2; i <= 10; i++)
                for (int j = 2; j <= 10; j++)
                    sheet.Cells[i + 8, j + 2] = (i - 1) * (j - 1);

            var tableRange = sheet.Range[sheet.Cells[10, 4], sheet.Cells[17, 11]];
            tableRange.Font.Size = 15;

            string excelPath = Path.Combine(Environment.CurrentDirectory, "MultiplicationTable.xlsx");
            document.SaveAs(excelPath);
            app.Quit();
        }
    }
}
