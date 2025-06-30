using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace Task1
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

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new()
            {
                Filter = "Текстовые файлы|*.txt;*.cs;*.html;*.css;*.js;*.sql|Все файлы|*.*",
            };

            if (dialog.ShowDialog() != true)
                return;

            var text = File.ReadAllText(dialog.FileName);
            textBox.Text = text;
            Title = dialog.FileName;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new()
            {
                Filter = "Текстовые файлы|*.txt;*.cs;*.html;*.css;*.js;*.sql",
            };
            if (dialog.ShowDialog() != true)
                return;

            File.WriteAllText(dialog.FileName, textBox.Text);

            MessageBox.Show("Файл успешно сохранён",
                "Статус",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Вы хотите закрыть приложение?",
                "Подтверждение",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}