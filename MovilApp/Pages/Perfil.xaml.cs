using BIZ;

namespace MovilApp.Pages;

public partial class Perfil : ContentPage
{
    Perfil perfil;
    PerfilManager perfilManager;
	public Perfil(Perfil perfil) //Perfil perfil
	{
		InitializeComponent();
        this.perfil = perfil;
        perfilManager = FabricManager.PerfilManager();
	}

    private async void BtnContinuar_Clicked(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new MainPage());

        Perfil perfiil = new Perfil(this);

        perfiil.nombre.Text = "";
        perfiil.clave.Text = "";
        perfiil.departamento.Text = "";
        perfiil.telefono.Text = "";
        perfiil.email.Text = "";
        perfiil.fechaIngreso.Text = "";

        if(perfilManager.Insertar(perfiil) != null)
        {
            DisplayAlert("Perfil", "Este es tu Perfil", "OK");
            await Navigation.PushAsync(new MainPage());
        }
        else
        {
            DisplayAlert("Perfil", perfilManager.Error, "OK");
        }
    }
}