namespace Task1;

public partial class LabWork38Page : ContentPage
{
	public LabWork38Page()
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
}