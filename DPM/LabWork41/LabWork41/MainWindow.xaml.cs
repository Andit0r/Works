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

namespace LabWork41
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _isMenuOpen = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new()
            {
                Duration = TimeSpan.FromSeconds(1),
                EasingFunction = new PowerEase()
                {
                    EasingMode = EasingMode.EaseInOut,
                }
            };

            if (_isMenuOpen)
                animation.To = 0;
            else
                animation.To = 200;

            _isMenuOpen = !_isMenuOpen;
            MenuStackPanel.BeginAnimation(Border.WidthProperty, animation);
        }
    }
}