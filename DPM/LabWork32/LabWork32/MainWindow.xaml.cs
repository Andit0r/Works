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

namespace LabWork32
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string[] categories =
            {
                "Бытовая техника",
                "Красота и здоровье",
                "Смартфоны и фототехника",
                "ТВ, консоли и аудио",
                "ПК, ноутбуки и аудио",
                "Комплектующие для ПК",
                "Офис и мебель",
                "Сетевое оборудование",
                "Отдых и развлечения",
            };

            CategoriesListBox.ItemsSource = categories;
            SortTextBlock.Text = $"Сортировка: {((ComboBoxItem)SortComboBox.SelectedItem).Content}";
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            SortTextBlock.Text = $"{SortComboBox.SelectedValue.ToString()}";
        }

        private void SortComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {         
            if (SortTextBlock != null)
                SortTextBlock.Text = $"Сортировка: {((ComboBoxItem)SortComboBox.SelectedItem).Content}";
        }

        private void CategoriesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CategoryTextBlock != null)
                CategoryTextBlock.Text = $"Категория: {CategoriesListBox.SelectedItem}";
        }
    }
}