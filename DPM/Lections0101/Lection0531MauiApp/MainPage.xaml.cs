namespace Lection0531MauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void AlertButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("header", "info", "ok");
        }

        private async void GoToButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TestPage());
        }
    }

}
