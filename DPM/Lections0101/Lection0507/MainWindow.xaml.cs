﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lection0507
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CommandBindings.Add(new CommandBinding(
                ApplicationCommands.New, 
                NewExecuted,
                NewCanExecuted
                ));

            CommandBindings.Add(new CommandBinding(
                ApplicationCommands.Close,
                CloseExecuted
                ));
            
            //ApplicationCommands.
            //MediaCommands.
            //ComponentCommands.
        }

        private void CloseExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }

        private void NewCanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void NewExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            progressBar.Visibility = Visibility.Visible;
            MainWindow window = new();
            window.ShowDialog();
            progressBar.Visibility = Visibility.Hidden;
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            MenuPanel.Width = (MenuPanel.Width == 100) ? 45 : 100;
        }
    }
}