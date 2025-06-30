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

            if (LoginTextBox.Text == Properties.Settings.Default.Login &&
                passwordBox.Password == Properties.Settings.Default.Password)
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
