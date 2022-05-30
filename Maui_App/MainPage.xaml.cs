namespace Maui_App;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
	}

    private async void Btn_KlickMich_Clicked(object sender, EventArgs e)
    {
        if(await DisplayAlert("FRAGE", "Soll was gemacht werden?", "Ja", "Nein"))
		    Btn_KlickMich.Text = "Button wurde geklickt";
    }

    private void Entry_Completed(object sender, EventArgs e)
    {

    }
}

