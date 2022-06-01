namespace Personendatenbank.Pages;

public partial class Pg_AddPerson : ContentPage
{
    public Pg_AddPerson()
    {
        InitializeComponent();

        Dpr_Birthdate.MaximumDate = DateTime.Now;
    }

    private async void Btn_Ok_Clicked(object sender, EventArgs e)
    {
        Model.Person person = this.BindingContext as Model.Person;

        if(await DisplayAlert($"{person.Name} speichern?", $"Soll diese Person abgespeichert werden:\n{person.Name} ({person.Geschlecht})\ngeboren am {person.Geburtsdatum.ToShortDateString()}\nVerheiratet: {person.Verheiratet}", "Ja", "Nein"))
        {
            Services.ToastService.ShowToast($"{person.Name} wurde hinzugefügt", true);
        }
    }

    private void Ent_Name_Completed(object sender, EventArgs e)
    {
        Dpr_Birthdate.Focus();
    }

    private void Dpr_Birthdate_DateSelected(object sender, DateChangedEventArgs e)
    {
        Pkr_Gender.Focus();
    }

    private void Pkr_Gender_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Swi_Married.Focus();
    }

    //private void Btn_ChangeColor_Clicked(object sender, EventArgs e)
    //{
    //    Lbl_Output.TextColor = (Lbl_Output.TextColor == Colors.Red) ? Colors.Green : Colors.Red;

    //}
}