namespace Maui_App.Navi;

public partial class RoutingBsp : ContentPage
{
	public RoutingBsp()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		//Mittels des GoToAsync-Befehls k�nnen in der Shell angemeldete Routen angesteuert werden
		Shell.Current.GoToAsync("//main");
    }
}