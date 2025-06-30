using Microsoft.Win32;
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

namespace LabWork42
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SolidColorBrush BrushColor { get; set; } = new SolidColorBrush(Colors.Black);
        public int BrushSize { get; set; } = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FontSizeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            BrushSize = Convert.ToInt32(FontSizeTextBox.Text);

            if (!(inkCanvas is null))
            {
                inkCanvas.DefaultDrawingAttributes.Height = BrushSize;
                inkCanvas.DefaultDrawingAttributes.Width = BrushSize;
            }
        }

        private void FontSizeTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0)))
            {
                e.Handled = true;
            }
        }

        private void ColorButton_Click(object sender, RoutedEventArgs e)
        {
            BrushColor = ((SolidColorBrush)((Rectangle)((Button)sender).Content).Fill);

            inkCanvas.DefaultDrawingAttributes.Color = BrushColor.Color;
        }

        private void LoadImageButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new();
            dialog.Filter = @"PNG|*.png|
JPG|*.jpg;*.jpeg";

            if (dialog.ShowDialog() != true)
                return;

            var fileName = dialog.FileName;

            BitmapImage image = new();

            image.BeginInit();
            image.UriSource = new Uri(fileName);
            image.EndInit();

            InkCanvasImage.Source = image;
        }
    }
}