using Word = Microsoft.Office.Interop.Word;

namespace Task_3
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            CreateDocument();
        }

        private void CreateDocument()
        {
            WordManager manager = new();
            manager.CreateDocument(inputTextBox, "TimesNewRoman", 14);
            manager.AddDate();
        }
    }
}
