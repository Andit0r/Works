namespace Task3
{
    public partial class ReplaceForm : Form
    {
        public Action<string, string> ReplaceAction;

        public ReplaceForm()
        {
            InitializeComponent();
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            ReplaceAction?.Invoke(searchTextBox.Text, replaceTextBox.Text);
        }
    }
}
