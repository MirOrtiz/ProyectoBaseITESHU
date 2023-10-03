using COMMON.Entidades;

namespace MovilApp.Pages;

public partial class Permisos : ContentPage
{
	
	public Permisos()
	{
		InitializeComponent();

		var permisoList = new List<String>();
		permisoList.Add("A cuenta de Días de Vacaciones");
		permisoList.Add("A cuenta de Días no laborales, laborados");

		Picker picker = new Picker { Title = "Selecciona el tipo de Permiso por Días" };
		picker.ItemsSource = permisoList;
	}
    private async void BtnDias_Clicked(object sender, EventArgs e)
    {
        
    }
    private async void BtnHoras_Clicked(object sender, EventArgs e)
    {
        
    }
    private async void BtnContinuar_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync (new  ConfirmarPermiso());
			
	}

	private async void BtnPermiso_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Permisos());
    }
	
}