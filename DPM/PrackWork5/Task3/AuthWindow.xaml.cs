using System.IO;
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
            var data = File.ReadAllLines("userData.txt");
            SettingsWindow window = new();

            if (LoginTextBox.Text == data[0] &&
                passwordBox.Password == data[1])
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
