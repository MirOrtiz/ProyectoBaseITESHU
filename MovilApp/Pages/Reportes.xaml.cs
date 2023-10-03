namespace MovilApp.Pages;

public partial class Reportes : ContentPage
{
	public Reportes()
	{
		InitializeComponent();

		var diasList = new List<string>();
		diasList.Add("D�as de Vacaciones Autorizados");
		diasList.Add("D�as Restantes de Vacaciones");
		diasList.Add("D�as Detallados por A�os");

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