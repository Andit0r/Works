using Word = Microsoft.Office.Interop.Word;

class WordManager
{
    private Word.Application _app;
    private Word.Document _document;
    private Word.Paragraph _paragraph;

    public void CreateDocument(TextBox inputTextBox, string fontName, int fontSize)
    {
        _app = new Word.Application();
        _app.Visible = true;
        _document = _app.Documents.Add();
        _paragraph = _document.Paragraphs.Add();
        var range = _document.Paragraphs[1].Range;
        range.Text = inputTextBox.Text;
        range.Font.Name = fontName;
        range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
        range.Font.Size = fontSize;
    }

    public void AddTable(string templateDirectory)
    {
        var app1 = new Word.Application();
        var template = templateDirectory;
        var document1 = _app.Documents.Add(template);

        var table = document1.Tables[1];
        _paragraph = _document.Paragraphs.Add();

    }
    public void AddDate()
    {
        var endDocument = _document.Content;
        endDocument.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
        endDocument.Text = $"\n{DateTime.Now}";
    }
}
