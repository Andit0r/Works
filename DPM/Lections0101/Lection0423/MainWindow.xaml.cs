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

namespace Lection0423
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            PriceSlider.Value = 10;

            Calendar.BlackoutDates.Add(new CalendarDateRange(DateTime.Today, DateTime.Today.AddDays(5)));
            Calendar.SelectedDates.Add(DateTime.Today.AddDays(-1));
            Calendar.SelectedDates.Add(DateTime.Today.AddDays(-2));
            Calendar.SelectedDates.Add(DateTime.Today.AddDays(-4));
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void AllowCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            OkButton.IsEnabled = AllowCheckBox.IsChecked.Value;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = e.OriginalSource as RadioButton;
            Title = radioButton.Content.ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataTextBox.BorderBrush = DataTextBox.Text.Length > 5 ? Brushes.Black : Brushes.Red;
        }

        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }

        private void PriceSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //var slider = (Slider)sender;
            //slider.SelectionEnd = slider.Value;
            PriceLabel.Content = PriceSlider.Value.ToString("0.00");
            PriceLabel.Content = $"{PriceSlider.Value:0.00} руб";

            var price = Math.Round(PriceSlider.Value, 2);
            PriceLabel.Content = price;
        }

        private void StackPanel_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}