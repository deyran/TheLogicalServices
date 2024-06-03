namespace IntellectusSecretaria.Areas.MapaNotas.MVVM.Views;

public partial class MapaNotasView : ContentPage
{
	public MapaNotasView()
	{
		InitializeComponent();        
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        App.Current.Quit();
    }
}