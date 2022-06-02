namespace Maui_App;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage beinhaltet die jeweils angezeigte Seite. Zuweisungen hier definieren die Startpage der App.
        //AppShell beinhaltet die Shell-Navigation dieser App (vgl. Navi.AppShell.cs)
        MainPage = new Navi.AppShell();

        //Alternative Navigation per Flyout-Page (vgl. Navi.FlyoutBsp.*)
        //MainPage = new Navi.FlyoutBsp.FlyoutPage1();

        //Alternative Navigation per Navigation-Page (vgl. Navi.NavPageBsp.cs)
        //In ContentPages innerhalb von NavigationPages können bestimmte Navigations-Befehle verwendet werden
        //MainPage = new Navi.NavPageBsp();

        //Alternative Navigation per Tabbed-Page (vgl. Navi.TabbedPageBsp.cs)
        //MainPage = new Navi.TabbedPageBsp();
    }

    //App beinhaltet die Lifecycle-Methoden der App
    protected override void OnStart()
    {
        //Dieser Code wird bei Start der App ausgeführt
        base.OnStart();
    }

    protected override void OnSleep()
    {
        //Dieser Code wird beim Eintritt in der Ruhephase der App ausgeführt
        base.OnSleep();
        //Setzen einer Instanz-übergreifenden Einstellung (Wird innerhalb des OS gespeichert)
        Preferences.Set("SleepTime", DateTime.Now);
    }

    protected override async void OnResume()
    {
        //Dieser Code wird beim Rückkehr aus der Ruhephase in die aktive Phase der App ausgeführt
        base.OnResume();
        //Abruf einer Instanz-übergreifenden Einstellung und Ausgabe in DisplayAlert
        await MainPage.DisplayAlert($"Zeit", $"Das Handy wurde um {(Preferences.Get("SleepTime", DateTime.Now)).ToShortTimeString()} unterbrochen.", "ok");
    }
}
