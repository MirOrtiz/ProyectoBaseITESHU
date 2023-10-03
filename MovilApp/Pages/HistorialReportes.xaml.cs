using COMMON.Entidades;

namespace MovilApp.Pages;

public partial class HistorialReportes : ContentPage
{
	public HistorialReportes()
	{
		InitializeComponent();
	}

    private async void BtnContinuar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}