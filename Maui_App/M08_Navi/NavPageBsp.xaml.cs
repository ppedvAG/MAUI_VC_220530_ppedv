namespace Maui_App.Navi;

public partial class NavPageBsp : ContentPage
{
	public NavPageBsp()
	{
		InitializeComponent();
	}

    private void Btn_Main_Clicked(object sender, EventArgs e)
    {
        //Mittels PushAsync kann innerhalb einer NavigatinPage zu der n�chsten Seite navigiert werden.
        //Vorherige Pages werden f�r die Back-Navigation auf den NavigationStack gelegt.
        Navigation.PushAsync(new Grundlagen());
    }

    private void Btn_Controls_Clicked(object sender, EventArgs e)
    {
        //Modal-Pushes verhindern die Anzeige von Titelleiste und Software-Back-Button bei der n�chsten Seite
        Navigation.PushModalAsync(new Controls());
    }

    //Button zur Verwendung des Messaging-Centers
    private void Button_Clicked(object sender, EventArgs e)
    {
        //Instanzierung des Empf�nger-Objekts (dies aboniert im Konstruktor)
        Page subscriber = new McSubscriberPage();
        //Senden einer Nachricht mit Titel und Inhalt
        MessagingCenter.Send(this, "nachricht", "HALLO");
        //Navigation zu Empf�nger-Objekt
        Navigation.PushAsync(subscriber);
    }
}