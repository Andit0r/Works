using Word = Microsoft.Office.Interop.Word;

class WordManager
{
    private Word.Application _app;
    private Word.Document _document;

    public void CreateTemplateDocument(TextBox inputTextBox, TextBox countPagesTextBox, string templateDirectory)
    {
        _app = new Word.Application();
        _app.Visible = true;
        var template = templateDirectory;
        _document = _app.Documents.Add(template);

        _document.Content.Find.Execute(FindText: "ТекстИзПоляВвода",
            ReplaceWith: inputTextBox.Text, Replace: Word.WdReplace.wdReplaceAll);
        _document.Content.Find.Execute(FindText: "дд.мм.гггг чч:мм",
            ReplaceWith: DateTime.Now, Replace: Word.WdReplace.wdReplaceAll);

        var table = _document.Tables[1];
        for (int i = 2; i <= Convert.ToInt32(countPagesTextBox.Text); i++)
            table.Rows.Add(table.Rows[i]);

        for (int i = 2; i <= table.Rows.Count; i++)
            table.Rows[i].Range.Text = Convert.ToString(i - 1);
    }

    public static void SaveDocument()
    {
        SaveFileDialog saveFileDialog = new();
        saveFileDialog.Filter = "Pdf files(*.pdf)|*.pdf|Docx files(*.docx)|*.docx";
        if(saveFileDialog.ShowDialog() == DialogResult.OK)
        {

        }

    }
}