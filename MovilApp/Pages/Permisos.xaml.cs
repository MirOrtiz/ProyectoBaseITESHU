using BIZ;
using COMMON.Entidades;
using System.Linq.Expressions;

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
		dias.IsEnabled = true;
	}
    private async void BtnHoras_Clicked(object sender, EventArgs e)
    {
		horas.IsEnabled = true;
    }
	private async void BtnContinuar_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Permisos());

		//Permisos permisos = new Permisos();
		string permisos = " ";
		permisos = idPermiso.Text;
		permisos = fecha.Date.ToString();
		permisos = nombre.Text;
		permisos = clave.Text;
		permisos = departamento.Text;
        permisos = dias.Text;
		permisos = pickDias.SelectedItem.ToString();
		permisos = horas.Text;
		permisos = diasAusente.Text;
		permisos = fecha1.Date.ToString();
		permisos = fecha2.Date.ToString();
		permisos = horasAusente.Text;
		permisos = hora1.Time.ToString();
		permisos = hora2.Time.ToString();
		permisos = motivoPermiso.Text;

        if (permisosManager.Insertar(permisos) != null)
        {
            DisplayAlert("Solicitud Permisos", "Confirma tu Solicitud de Permiso", "OK");
            await Navigation.PushAsync(new Permsios());

        }
        else
        {
            DisplayAlert("Solicitud Permisos", permisosManager.Error, "OK");
        }

        try
		{
			permisos = $"fecha : {permisos}";
			Console.WriteLine(permisos);
        }catch (Exception ex)
		{
			//Permisos.Add(permisos);
			Console.WriteLine(ex.ToString());
		}
		
		
        
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