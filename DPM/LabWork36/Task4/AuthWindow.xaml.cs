using System.Windows;

namespace Task4
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
            if (LoginTextBox.Text == "admin" && passwordBox.Password == "qwerty")
            {
                AdminWindow adminWindow = new();
                Hide();
                adminWindow.ShowDialog();
                Show();
                return;
            }

            if (LoginTextBox.Text == "manager" && passwordBox.Password == "12345")
            {
                ManagerWindow managerWindow = new();
                Hide();
                managerWindow.ShowDialog();
                Show();
                return;
            }

            MessageBox.Show("Неверное введены данные!",
            "Ошибка",
            MessageBoxButton.OK,
            MessageBoxImage.Error);
        }
    }
}
