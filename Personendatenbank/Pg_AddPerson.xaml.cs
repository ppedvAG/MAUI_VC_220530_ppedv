namespace Personendatenbank;

public partial class Pg_AddPerson : ContentPage
{
    public Pg_AddPerson()
    {
        InitializeComponent();

        Dpr_Birthdate.MaximumDate = DateTime.Now;
    }

    private void Btn_Ok_Clicked(object sender, EventArgs e)
    {

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
        Swi_Married.Focus();
    }

    //private void Btn_ChangeColor_Clicked(object sender, EventArgs e)
    //{
    //    Lbl_Output.TextColor = (Lbl_Output.TextColor == Colors.Red) ? Colors.Green : Colors.Red;

    //}
}