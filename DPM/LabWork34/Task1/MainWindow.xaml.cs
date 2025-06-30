using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Input;

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
            CommandBindings.Add(new CommandBinding(
                ApplicationCommands.Save,
                SaveExecuted,
                SaveCanExecuted
                ));
            DateStatusBarItem.Content = DateTime.Now.Date;
        }

        private void SaveCanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = textBox.Text.Length > 0;
        }

        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new();

            saveFileDialog.Filter = "Текстовые документы (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
            }
        }

        private void textBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            TextLenghtStatusBarItem.Content = $"Количество символов: {textBox.Text.Length}";
        }

        private void ScaleSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(ScaleLabel != null)
                ScaleLabel.Content = $"{(int)ScaleSlider.Value}%";
        }

        private void DecreaseScaleButton_Click(object sender, RoutedEventArgs e)
        {
            ScaleSlider.Value = ScaleSlider.Value - 10;
        }

        private void IncreaseScaleButton_Click(object sender, RoutedEventArgs e)
        {
            ScaleSlider.Value = ScaleSlider.Value + 10;
        }

        private void MenuItem_Checked(object sender, RoutedEventArgs e)
        {
            if (statusBar != null)
                statusBar.Visibility = Visibility.Visible;
        }

        private void StateStatusBar_Unchecked(object sender, RoutedEventArgs e)
        {
            if (statusBar != null)
                statusBar.Visibility = Visibility.Collapsed;
        }


        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ClearMenuItem_Click(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
        }

        private void FontSizeLoad()
        {
            for(int i = 0;  i < 64; i++)
            {
                
            }
        }
    }
}