namespace MovilApp.Pages;

public partial class Calendarizacion : ContentPage
{
	public Calendarizacion()
	{
		InitializeComponent();
	}
    private async void BtnContinuar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());

    }
}