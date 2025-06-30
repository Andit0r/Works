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

            BirthDatePicker.DisplayDateEnd = DateTime.Today;
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordLenghtTextBlock.Text = $"Длина пароля: {PasswordBox.Password.Length}.";
        }

        private void AboutTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            RemainingSymbolsTextBlock.Text = $"Оставшееся количество символов: {AboutTextBox.MaxLength - AboutTextBox.Text.Length}.";
        }

        private void BirthDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var age = DateTime.Today.Date.Year - BirthDatePicker.SelectedDate.Value.Year;
            

            AgeTextBlock.Text = $"Ваш возраст: {DateTime.Today.Date}.";
        }

        private void WorkExperienceSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ValueWorkExperienceTextBlock.Text = $"Стаж: {WorkExperienceSlider.Value:0} год/года/лет";
        }
    }
}