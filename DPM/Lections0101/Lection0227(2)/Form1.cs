namespace Lection0227_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            Form2 form = new();
            form.FormAction = ChangedText;
            form.ShowDialog();
        }

        private void ChangedText(string text)
        {
            label1.Text = text;
        }
    }
}
