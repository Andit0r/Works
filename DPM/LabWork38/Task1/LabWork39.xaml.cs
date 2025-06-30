namespace Task1;

public partial class LabWork39 : ContentPage
{
	public LabWork39()
	{
		InitializeComponent();
	}

    private async void Task1Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Lab39Task1Page());
    }

    private async void Task2Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Lab39Task2Page());
    }

    private async void Task3Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Lab39Task3Page());
    }

    private async void Task4Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Lab39Task4Page());
    }

    private async void Task5Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Lab39Task5Page());
    }
}