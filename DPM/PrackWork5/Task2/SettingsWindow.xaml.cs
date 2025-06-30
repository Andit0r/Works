using System.Configuration;
using System.Windows;

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        private Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public SettingsWindow()
        {
            InitializeComponent();

            LoginTextBox.Text = ConfigurationManager.AppSettings["Login"];
            PasswordTextBox.Text = ConfigurationManager.AppSettings["Password"];
            EmailTextBox.Text = ConfigurationManager.AppSettings["Email"];
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                config.AppSettings.Settings["Login"].Value = LoginTextBox.Text;
                config.AppSettings.Settings["Password"].Value = PasswordTextBox.Text;
                config.AppSettings.Settings["Email"].Value = EmailTextBox.Text;
                config.Save();
                ConfigurationManager.RefreshSection("appSettings");
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
