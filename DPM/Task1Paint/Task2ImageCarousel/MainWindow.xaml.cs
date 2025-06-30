using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace Task2ImageCarousel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> PathImages {  get; set; }
        public int Counter { get; set; } = 0;
        public DispatcherTimer CurrentTimer { get; set; } = new(DispatcherPriority.Render);
        public MainWindow()
        {
            InitializeComponent();
            CurrentTimer.Interval = TimeSpan.FromMilliseconds(300);
            CurrentTimer.Tick += CurrentTimer_Tick;
            CurrentTimer.Start();
        }

        private void CurrentTimer_Tick(object? sender, EventArgs e)
        {
            if (PathImages == null)
                return;
            CarouselImage.Source = new BitmapImage(new Uri(PathImages[Counter % PathImages.Count]));
            Counter++;
        }

        private void OpenImagesButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFolderDialog dialog = new();
            if (dialog.ShowDialog() != true)
                return;
            var path = dialog.FolderName;
            PathImages = Directory.GetFiles(path).Where(f => f.ToLower().EndsWith("jpg")
            || f.ToLower().EndsWith("jpeg") || f.ToLower().EndsWith("png")).ToList();
        }
    }
}