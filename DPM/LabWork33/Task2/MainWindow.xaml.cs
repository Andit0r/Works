using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<User> users =
                [
                    new User
                    {
                        Address = "www.yandex.ru",
                        Login = "Misha1330",
                        Password = "MishaPro",
                        Category = "Сайт",
                        IsArchived = false,
                    },
                    new User
                    {
                        Address = "www.google.com",
                        Login = "PetyaAFK",
                        Password = "samsa3310",
                        Category = "Сайт",
                        IsArchived = true,
                    },
                    new User
                    {
                        Address = "www.mail.ru",
                        Login = "Maxim78k",
                        Password = "KrytoiPocan",
                        Category = "БД",
                        IsArchived = false,
                    },
                    new User
                    {
                        Address = "www.rambler.ru",
                        Login = "Polina",
                        Password = "Polesosq3t0",
                        Category = "Сайт",
                        IsArchived = true,
                    },
                    new User
                    {
                        Address = "www.google.com",
                        Login = "SashokLixx",
                        Password = "Dimitriy38",
                        Category = "email",
                        IsArchived = true,
                    }
                ];

            List<string> categories =
                [
                    "email",
                    "БД",
                    "Сайт",
                ];

            UsersDataGrid.ItemsSource = users;
            CategoryColumn.ItemsSource = categories;
        }

        private void CopyPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            var user = (e.Source as Button).DataContext as User;
            Clipboard.SetDataObject(user.Password);
        }
    }
}