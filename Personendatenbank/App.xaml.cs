namespace Personendatenbank
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            //MainPage = new Pages.Pg_AddPerson();

            //MainPage = new Layoutuebungen.Pg_GridLab();

            //MainPage = new Layoutuebungen.Pg_AbsoluteLayoutLab();
        }
    }
}