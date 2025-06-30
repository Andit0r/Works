namespace WinFormsApp1
{
    public partial class DocumentForm : Form
    {
        public DocumentForm()
        {
            InitializeComponent();
        }

        private void CreateTemplateDocumentButton_Click(object sender, EventArgs e)
        {
            CreateDocument();
            WordManager.SaveDocument();
        }

        private void CreateDocument()
        {
            WordManager manager = new();
            manager.CreateTemplateDocument(inputTextBox, countPagesTextBox, @"C:\Temp\ispp31\DPM\PractWork3\Шаблон.docx");
        }
    }
}
