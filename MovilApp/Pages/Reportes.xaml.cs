namespace MovilApp.Pages;

public partial class Reportes : ContentPage
{
	public Reportes()
	{
		InitializeComponent();

		var diasList = new List<string>();
		diasList.Add("Días de Vacaciones Autorizados");
		diasList.Add("Días Restantes de Vacaciones");
		diasList.Add("Días Detallados por Años");

		Picker picker = new Picker { Title = "Selecciona el Reporte a Generar" };
		picker.ItemsSource = diasList;

		//Label diasNameLabel = new Label();
		//diasNameLabel.SetBinding(Label.TextProperty, new Binding("SelectedItem", source: picker)); 
	}
    private async void BtnReportes_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());  //Cambiar MainPage por la ruta del archivo de Reportes
    }
    private async void BtnHistorial_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HistorialReportes());
    }
}