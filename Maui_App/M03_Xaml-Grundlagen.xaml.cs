namespace Maui_App;

public partial class Grundlagen : ContentPage
{
	
	public Grundlagen()
	{
		InitializeComponent();
	}

    private async void Btn_KlickMich_Clicked(object sender, EventArgs e)
    {
        if(await DisplayAlert("FRAGE", "Soll was gemacht werden?", "Ja", "Nein"))
		    Btn_KlickMich.Text = "Button wurde geklickt";
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}

