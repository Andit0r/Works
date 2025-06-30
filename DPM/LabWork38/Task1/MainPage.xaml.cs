using System.IO;

namespace Task1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Task1Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Task1Page());
        }

        private async void Task2Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Task2Page());
        }

        private async void Task3Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Task3Page());
        }

        private async void LabWork38Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LabWork38Page());
        }

        private async void LabWork39Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LabWork39());
        }
    }
}
