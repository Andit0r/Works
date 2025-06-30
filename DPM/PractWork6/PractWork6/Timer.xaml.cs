using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PractWork6
{
    /// <summary>
    /// Логика взаимодействия для Timer.xaml
    /// </summary>
    public partial class Timer : UserControl
    {
        public DispatcherTimer CurrentTimer { get; set; } = new(DispatcherPriority.Render);

        public Timer()
        {
            InitializeComponent();
            CurrentTimer.Interval = TimeSpan.FromSeconds(1);
            CurrentTimer.Tick += CurrentTimer_Tick;
            CurrentTimer.Start();
        }

        private void CurrentTimer_Tick(object? sender, EventArgs e)
        {
            TimerLabel.Content = DateTime.Now.ToLongTimeString();
        }
    }
}
