namespace MovilApp.Pages;

public partial class Departamento : ContentPage
{
	public Departamento()
	{
		InitializeComponent();
	}
    private async void BtnAprobada_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Mensaje", "Solicitud Aprovada", "OK");
    }
    private async void BtnPendiente_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Mensaje", "Tu Solicitud se encuentra Pendiente", "OK");
    }
    private async void BtnRechazada_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Mensaje", "Tu Solicitud fue Rechazada", "OK");
    }
    private async void BtnContinuar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}