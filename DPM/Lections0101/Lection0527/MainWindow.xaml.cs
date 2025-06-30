using System.Windows;

namespace Lection0527
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Cat MyCat { get; set; }

        public DateTime CurrentDate { get; set; } = DateTime.Now;

        public MainWindow()
        {
            InitializeComponent();

            Cat cat = new() { Id = 1, Name = "ronaldo", Age = 7 };

            MyCat = new() { Id = 2, Name = "og buda", Age = 5 };
            DataContext = this;

            NameTextBox.DataContext = cat.Id;
            DateTime date = DateTime.Now;
            YearTextBox.DataContext = date;

        }
    }
}