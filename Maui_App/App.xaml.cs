namespace Maui_App;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage = new NavigationPage(new Navi.NavPageBsp());

        //MainPage = new Navi.TabbedPageBsp();

        //MainPage = new Navi.FlyoutBsp.FlyoutPage1();

        MainPage = new Navi.AppShell();
	}

    protected override void OnStart()
    {
        base.OnStart();
    }

    protected override void OnSleep()
    {
        base.OnSleep();
        Preferences.Set("SleepTime", DateTime.Now);
    }

    protected override async void OnResume()
    {
        base.OnResume();
        await MainPage.DisplayAlert($"Zeit", $"Das Handy wurde um {(Preferences.Get("SleepTime", DateTime.Now)).ToShortTimeString()} unterbrochen.", "ok");
    }
}
