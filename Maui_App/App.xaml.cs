namespace Maui_App;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();

		MainPage = new MainPage();
	}

    protected override void OnStart()
    {
        base.OnStart();


    }
}
