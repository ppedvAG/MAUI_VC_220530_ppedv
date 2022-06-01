namespace Maui_App;

public partial class Gestures : ContentPage
{
	public Gestures()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
		Lbl_Main.Text = "TAPPED";
    }

    private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
    {
        Lbl_Main.Text = "SWIPED";
    }
}