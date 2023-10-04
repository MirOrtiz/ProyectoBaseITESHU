using BIZ;
using COMMON.Entidades;

namespace MovilApp.Pages;

public partial class Permisos : ContentPage
{
	//Permisos permimso;
	//PermisosManager permisosManager;
	public Permisos()  //Permisos permiso
    {
		InitializeComponent();
		//this.permimso = permiso;
		//permisosManager = FabricManager.PermisosManager();

		List<string> dias = new List<String>();
		dias.Add("A cuenta de Días de Vacaciones");
		dias.Add("A cuenta de Días no laborales, laborados");

		pickDias.ItemsSource = dias;
	}
    private async void BtnDias_Clicked(object sender, EventArgs e)
    {
        //BtnDias_Clicked.Enabled = true;
    }
    private async void BtnHoras_Clicked(object sender, EventArgs e)
    {
        
    }
	private async void BtnContinuar_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ConfirmarPermiso());

		//Permisos permisos = new Permisos();
		string permisos = " ";
		permisos = idPermiso.Text.Substring(0, 1);
		permisos = fecha.Date.ToString().Substring(0, 2);
		permisos = nombre.Text.Substring(0, 3);
		permisos = clave.Text.Substring(0, 4);
		permisos = departamento.Text.Substring(0, 5);
        permisos = BtnDias.Text.Substring(0, 6);
		permisos = pickDias.SelectedItem.ToString().Substring(0, 7);
		permisos = BtnHoras.Text.Substring(0, 8);
		permisos = diasAusente.Text.Substring(0, 9);
		permisos = fecha1.Date.ToString().Substring(0, 10);
		permisos = fecha2.Date.ToString().Substring(0, 11);
		permisos = horasAusente.Text.Substring(0, 12);
		permisos = hora1.Time.ToString().Substring(0, 13);
		permisos = hora2.Time.ToString().Substring(0, 14);
        permisos = motivoPermiso.Text.Substring(0, 15);

        
    }

    private async void BtnPermiso_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Permisos());
    }
    //private void SelectAll_Checked(object sender, RoutedEventArgs e)
    //{
    //    dias.IsChecked = horas.IsChecked = true;
    //}
}