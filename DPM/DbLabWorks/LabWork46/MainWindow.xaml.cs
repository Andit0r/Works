using SqlLibrary;
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

namespace LabWork46
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IDatabase _database { get; }
        public MainWindow()
        {
            InitializeComponent();
            _database = new SqliteDatabase(Environment.CurrentDirectory, "GamesStore.sqlite");
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            int rows = 0;
            try
            {
                if (QueryTextBox.Text.Trim() != "")
                    rows = _database.ExecuteQuery(QueryTextBox.Text);
                else
                    rows = _database.ExecuteQuery("UPDATE Game SET Price = Price + 1;");

                MessageBox.Show($"Количество изменённых строк: {rows}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверно введена команда");
            }
        }
    }
}