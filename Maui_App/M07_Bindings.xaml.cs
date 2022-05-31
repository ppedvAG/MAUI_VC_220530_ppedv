namespace Maui_App;

public partial class Bindings : ContentPage
{
    public Bindings()
    {
        InitializeComponent();
    }

    private async void Btn_Show_Clicked(object sender, EventArgs e)
    {
        Person person = Sly_DataBinding.BindingContext as Person;

        await DisplayAlert("PERSON", $"{person.Name} {person.Alter}", "ok");
    }

    private void Btn_Altern_Clicked(object sender, EventArgs e)
    {
        Person person = Sly_DataBinding.BindingContext as Person;

        person.Alter++;
    }

    private void Btn_Add_Clicked(object sender, EventArgs e)
    {
        Person person = Sly_DataBinding.BindingContext as Person;
        person.WichtigeDaten.Add(new DateTime(1999, 2, 23));
    }

    private void Btn_Delete_Clicked(object sender, EventArgs e)
    {
        if (LstV_Personen.SelectedItem != null)
        {
            Person person = Sly_DataBinding.BindingContext as Person;

            person.WichtigeDaten.Remove((DateTime)LstV_Personen.SelectedItem);
        }
    }


}

enum TestEnum { Eins, Zwei, Drei }

[ContentProperty("Type")]
public class EnumBindingSourceExtension : IMarkupExtension
{
    public Type Type { get; set; }

    public object ProvideValue(IServiceProvider serviceProvider)
    {
        if (Type is null || !Type.IsEnum)
            throw new Exception("You must provide a valid enum type");

        return Enum.GetValues(Type);
    }
}