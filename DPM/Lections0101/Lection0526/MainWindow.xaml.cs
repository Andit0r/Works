using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lection0526
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

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //if (MessageBox.Show("Закрыть окно?",
            //    "Закрытие",
            //    MessageBoxButton.YesNo,
            //    MessageBoxImage.Question) == MessageBoxResult.No)
            //{
            //    e.Cancel = true;
            //}
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new()
            {
                Title = "Выберите имя файла",
                Filter = "Текстовые файлы|*.txt;.html;.csv|Все файлы|*.*",
                FilterIndex = 2,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                //Multiselect = true,
            };
            dialog.InitialDirectory = System.IO.Path.Combine(@"c:", "Temp", "ispp31");

            if (dialog.ShowDialog() != true)
                return;

            Title = dialog.FileName;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new()
            {
                Title = "Выберите имя файла",
                Filter = "Текстовые файлы|*.txt;*.html;*.csv|Все файлы|*.*",
                FilterIndex = 2,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            };
            dialog.InitialDirectory = System.IO.Path.Combine(@"c:", "Temp", "ispp31");

            if (dialog.ShowDialog() != true)
                return;

            dialog.ShowDialog();
            var fileName = dialog.FileName;
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog dialog = new();

            dialog.ShowDialog();
            dialog.PrintVisual(panel, "print stackPanel");
            //dialog.PrintDocument(...);
        }

        private void ColorButton_Click(object sender, RoutedEventArgs e)
        {
            ColorDialog dialog = new();
            //dialog.Color = "Red";

            //dialog.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            //dialog.Owner = this;

            //Hide();
            Close();
            if (dialog.ShowDialog() != true)
                return;

            //Show();

            //Title = dialog.Color;
            Background = new SolidColorBrush(dialog.Color);
        }
    }
}