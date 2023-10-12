using BIZ;
using COMMON.Entidades;
using System.Linq.Expressions;

namespace MovilApp.Pages;

public partial class Permisos : ContentPage
{
	Permisos permimso;
	PermisosManager permisosManager;
	public Permisos(Permisos permiso)  //Permisos permiso
    {
		InitializeComponent();
		this.permimso = permiso;
		permisosManager = FabricManager.PermisosManager();

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
		//await Navigation.PushAsync(new Permisos());

		Permisos permisos = new Permisos(this);    // @

        permisos.idPermiso = idPermiso;
        permisos.nombre = nombre;
        permisos.clave = clave;
        permisos.departamento = departamento;
        permisos.pickDias = null; ;
        permisos.dias = null;
        permisos.horas = horas;
        permisos.diasAusente = null;
        permisos.fecha1.Date.ToString();
        permisos.fecha2.Date.ToString();
        permisos.horasAusente = horasAusente;
        permisos.hora1 = hora1;
        permisos.hora2 = hora2;
        permisos.motivoPermiso = motivoPermiso;

        //if (permisosManager.Insertar(permisos) != null)
        //{
        //    DisplayAlert("Solicitud Permisos", "Confirma tu Solicitud de Permisos", "OK");
        //    await Navigation.PushAsync(new Permisos(permimso));
            
        //}
        //else
        //{
        //    DisplayAlert("Solicitud Permiso", permisosManager.Error, "OK");
        //    //DisplayAlert("Solicitud Permisos", permisosManager.Error, "OK");
        //}




        //string permisos = " ";
        //permisos = idPermiso.Text;
        //permisos = fecha.Date.ToString();
        //permisos = nombre.Text;
        //permisos = clave.Text;
        //permisos = departamento.Text;
        //permisos = dias.Text;
        //permisos = pickDias.SelectedItem.ToString(); 
        //permisos = horas.Text;
        //permisos = diasAusente.Text;
        //permisos = fecha1.Date.ToString();
        //permisos = fecha2.Date.ToString();
        //permisos = horasAusente.Text;
        //permisos = hora1.Time.ToString();
        //permisos = hora2.Time.ToString();
        //permisos = motivoPermiso.Text;

        //string cadena = "insert into Permisos(idPermiso,fecha,nombre,clave,departamento,dias,pickDias,horas,diasAusente,fecha1,fecha2,hora1,hora2,motivoPermiso) values (" + idPermiso + ", " + fecha + ", " + nombre + ", " + clave + ", " + departamento + ", " + dias + ", " + pickDias + ", " + horas + ", " + diasAusente + ", " + fecha1 + ", " + fecha2 + ", " + horasAusente + ", " + hora1 + ", " + hora2 + ", " + motivoPermiso + ")";


        //      try
        //{
        //	permisos = $"fecha : {permisos}";
        //	Console.WriteLine(permisos);
        //      }catch (Exception ex)
        //{
        //	//Permisos.Add(permisos);
        //Console.WriteLine(idPermiso);
        //}



}

    private async void BtnPermiso_Clicked(object sender, EventArgs e)
	{
		//await Navigation.PushAsync(new Permisos());
    }
    //private void SelectAll_Checked(object sender, RoutedEventArgs e)
    //{
    //    dias.IsChecked = horas.IsChecked = true;
    //}
}