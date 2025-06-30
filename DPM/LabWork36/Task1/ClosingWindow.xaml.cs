using System.Windows;

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для ClosingWindow.xaml
    /// </summary>
    public partial class ClosingWindow : Window
    {
        public ClosingWindow()
        {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
