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

namespace Task5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        byte red;
        byte blue;
        byte green;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RGBCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            var checkBox = (CheckBox)sender;

            if(checkBox.IsChecked == false) {

            if(checkBox.Name == "RedCheckBox")
                RedSlider.IsEnabled = RedCheckBox.IsChecked.Value;
            if (checkBox.Name == "GreenCheckBox")
                GreenSlider.IsEnabled = GreenCheckBox.IsChecked.Value;
            if (checkBox.Name == "BlueCheckBox")
                BlueSlider.IsEnabled = BlueCheckBox.IsChecked.Value;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = (Slider)sender;
            if (slider.Name == "RedSlider")
                red = Convert.ToByte(slider.Value);
            if (slider.Name == "GreenSlider")
                green = Convert.ToByte(slider.Value);
            if (slider.Name == "BlueSlider")
               blue = Convert.ToByte(slider.Value);

            Background = new SolidColorBrush(Color.FromRgb(red, blue, green));
        }
    }
}