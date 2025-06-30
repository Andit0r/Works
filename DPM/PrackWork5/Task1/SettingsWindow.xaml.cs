using System.Windows;

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();

            LoginTextBox.Text = Properties.Settings.Default.Login;
            PasswordTextBox.Text = Properties.Settings.Default.Password;
            EmailTextBox.Text = Properties.Settings.Default.Email;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Properties.Settings.Default.Login = LoginTextBox.Text;
                Properties.Settings.Default.Password = PasswordTextBox.Text;
                Properties.Settings.Default.Email = EmailTextBox.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Данные были сохранены",
                    "Успех",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка",
                "Ошибка",
                MessageBoxButton.OK,
                MessageBoxImage.Error);
            }
        }
    }
}
