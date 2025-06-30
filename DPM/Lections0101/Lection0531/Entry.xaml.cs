using System.Windows;
using System.Windows.Controls;

namespace Lection0531
{
    /// <summary>
    /// Логика взаимодействия для Entry.xaml
    /// </summary>
    public partial class Entry : UserControl
    {
        public string Hint { get; set; }





        public int MaxLength
        {
            get { return (int)GetValue(MaxLengthProperty); }
            set { SetValue(MaxLengthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MaxLength.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaxLengthProperty =
            DependencyProperty.Register("MaxLength", typeof(int), typeof(Entry), new PropertyMetadata(0));

        public event RoutedEventHandler Edited;
        public event RoutedEventHandler Deleted;
        public Entry()
        {
            InitializeComponent();

            DataContext = this;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Deleted?.Invoke(sender, e);
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Edited?.Invoke(sender, e);
        }
    }
}
