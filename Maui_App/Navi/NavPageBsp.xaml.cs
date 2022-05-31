namespace Maui_App.Navi;

public partial class NavPageBsp : ContentPage
{
	public NavPageBsp()
	{
		InitializeComponent();
	}

    private void Btn_Main_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Grundlagen());
    }

    private void Btn_Controls_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Controls());
    }
}