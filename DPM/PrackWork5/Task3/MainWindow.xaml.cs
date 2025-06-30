using System.Windows;
using Task1;

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AuthWindowButton_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow window = new();
            window.ShowDialog();
        }
    }
}