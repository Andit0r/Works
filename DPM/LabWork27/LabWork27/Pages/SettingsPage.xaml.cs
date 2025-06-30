using System;
using System.Collections.Generic;
using System.IO;
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

namespace LabWork27.Pages
{
    /// <summary>
    /// Логика взаимодействия для SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void LoadCategories()
        {
            string filePath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "LINQ.txt");

            string[] parts;
            string category;
            List games;
            foreach (var line in File.ReadLines(filePath))
            {
                parts = line.Split(':');
                category = parts[0].Trim();
                games = parts[1].Split(',').Select(g => g.Trim()).ToList();
            }
        }
    }
}
