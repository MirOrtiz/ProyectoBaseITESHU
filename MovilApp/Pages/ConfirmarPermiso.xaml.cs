
namespace MovilApp.Pages;

public partial class ConfirmarPermiso : ContentPage
{
	public ConfirmarPermiso()
	{
		InitializeComponent();
    }
	private async void BtnConfirmar_Clicked(object sender, EventArgs e)
	{
		//await DisplayAlert("Mensaje", "Tu Solicitud fue Enviada Correctamente", "OK");
		await Navigation.PushAsync(new MainPage());
	}
    
}