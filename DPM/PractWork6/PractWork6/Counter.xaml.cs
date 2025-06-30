using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PractWork6
{
    /// <summary>
    /// Логика взаимодействия для Counter.xaml
    /// </summary>
    public partial class Counter : UserControl
    {
        public int MaxValue { get; set; }

        public event RoutedEventHandler ValueChanged;
        public Counter()
        {
            InitializeComponent();
        }

        private void DecreaseButton_Click(object sender, RoutedEventArgs e)
        {
            CounterTextBox.Text = (Convert.ToInt32(CounterTextBox.Text) - 1).ToString();
            ValueChanged?.Invoke(sender, e);

        }

        private void IncreaseButton_Click(object sender, RoutedEventArgs e)
        {
            if(Convert.ToInt32(CounterTextBox.Text) < MaxValue)
            {
                CounterTextBox.Text = (Convert.ToInt32(CounterTextBox.Text) + 1).ToString();
                ValueChanged?.Invoke(sender, e);
                return;
            }
            IncreaseButton.IsEnabled = false;
        }

        private void CounterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Convert.ToInt32(CounterTextBox.Text) >= MaxValue)
            {
                if(IncreaseButton != null)
                    IncreaseButton.IsEnabled = false;
            }
            if (IncreaseButton != null)
                IncreaseButton.IsEnabled = true;
        }
    }
}
