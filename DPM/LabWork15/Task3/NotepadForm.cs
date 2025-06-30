namespace Task3
{
    public partial class NotepadForm : Form
    {
        public NotepadForm()
        {
            InitializeComponent();
        }

        private void OpenReplaceFormButton_Click(object sender, EventArgs e)
        {
            ReplaceForm replaceForm = new();
            replaceForm.ReplaceAction = ReplacedText;
            replaceForm.ShowDialog();
        }

        private void ReplacedText(string searchText, string replaceText)
        {
            notepadTextBox.Text = notepadTextBox?.Text.Replace(searchText, replaceText);
        }
    }
}
