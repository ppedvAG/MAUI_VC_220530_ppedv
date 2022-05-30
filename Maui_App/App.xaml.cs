namespace Maui_App;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Layouts();
	}

    protected override void OnStart()
    {
        base.OnStart();
    }

    protected override void OnSleep()
    {
        base.OnSleep();
    }

    protected override void OnResume()
    {
        base.OnResume();
    }
}
