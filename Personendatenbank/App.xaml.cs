namespace Personendatenbank
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Pg_AddPerson();
        }
    }
}