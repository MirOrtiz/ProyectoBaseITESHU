namespace MovilApp.Pages;

public partial class Perfil : ContentPage
{
	public Perfil()
	{
		InitializeComponent();
	}

    private async void BtnContinuar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}