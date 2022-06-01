namespace Maui_App;

public partial class Plattformspezifika : ContentPage
{
	public Plattformspezifika()
	{
		InitializeComponent();


        if (DeviceInfo.Platform == DevicePlatform.Android)
            Lbl_DeviceInfo.Text = "C# - Android";
        else if (DeviceInfo.Platform == DevicePlatform.WinUI)
            Lbl_DeviceInfo.Text = "C# - WinUi";
        else
            Lbl_DeviceInfo.Text = "C# - Default";

        if (DeviceInfo.Idiom == DeviceIdiom.Desktop)
            Lbl_DeviceInfo.BackgroundColor = Colors.Green;
        else if (DeviceInfo.Idiom == DeviceIdiom.Phone)
            Lbl_DeviceInfo.BackgroundColor = Colors.Blue;
        else
            Lbl_DeviceInfo.BackgroundColor = Colors.Red;


#if ANDROID
        Lbl_Complilerbefehle.Text = "ANDROID";

#elif WINDOWS
        Lbl_Complilerbefehle.Text = "WINDOWS";
#endif

        Lbl_Orientation.Text = new Services.DeviceOrientationService().GetOrientation().ToString();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        //try
        //{
          // Turn On
          await Flashlight.TurnOnAsync();
          // Turn Off
          await Flashlight.TurnOffAsync();
        //}
        //catch (FeatureNotSupportedException fnsEx)
        //{
        //    // Handle not supported on device exception
        //}
        //catch (PermissionException pEx)
        //{
        //    // Handle permission exception
        //}
        //catch (Exception ex)
        //{
        //    // Unable to turn on/off flashlight
        //}

    }
}