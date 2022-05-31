namespace Maui_App;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage = new NavigationPage(new Navi.NavPageBsp());

        //MainPage = new Navi.TabbedPageBsp();

        MainPage = new Navi.FlyoutBsp.FlyoutPage1();
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
