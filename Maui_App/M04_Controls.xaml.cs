namespace Maui_App;

public partial class Controls : ContentPage
{
	public Controls()
	{
		InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        (sender as Button).Text = "Clicked";
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {

        bool result = await DisplayAlert
            (
                "L�schen",
                "Soll dieser Eintrag wirklich gel�scht werden?",
                "Ja",
                "Nein"
            );

        if (result)
            await DisplayAlert("Cool", "Du hast auf ja geklickt", "ok");
    }
}