using System.IO;
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

            var data = File.ReadAllLines("userData.txt");
            LoginTextBox.Text = data[0];
            PasswordTextBox.Text = data[1];
            EmailTextBox.Text = data[2];
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string[] data = { LoginTextBox.Text, PasswordTextBox.Text, EmailTextBox.Text };
                File.WriteAllLines("userData.txt", data);

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
