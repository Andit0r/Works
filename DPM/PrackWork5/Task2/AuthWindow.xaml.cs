using System.Configuration;
using System.Windows;

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow window = new();

            if (LoginTextBox.Text == ConfigurationManager.AppSettings["Login"] &&
                passwordBox.Password == ConfigurationManager.AppSettings["Password"])
            {
                window.ShowDialog();
                return;
            }

            MessageBox.Show("Данные введены неверно",
                "Ошибка",
                MessageBoxButton.OK,
                MessageBoxImage.Error);
        }
    }
}
