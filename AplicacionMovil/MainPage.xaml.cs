using Microsoft.Maui.Platform;

namespace AplicacionMovil;

public partial class MainPage : ContentPage 
{
    
    public MainPage()
	{
		InitializeComponent();

    }

    private async void presion_Clicked(object sender, EventArgs e)
    {
        Presion datosPresion = new Presion();
        datosPresion.presionSistolica = presionSistolica.Text;

        datosPresion.presionDiastolica= presionDistolica.Text;
        if (Platform.CurrentActivity.CurrentFocus != null)
            Platform.CurrentActivity.HideKeyboard(Platform.CurrentActivity.CurrentFocus);

        if (datosPresion.presionSistolica == null || datosPresion.presionDiastolica == null)
        {
            await DisplayAlert("Error", "Debes llenar todos los campos.", "OK");
        }
        else
        {
            await Navigation.PushAsync(new Sintomas(datosPresion));
        }

        


    }

    private void presionDistolica_Completed(object sender, EventArgs e)
    {
        if (Platform.CurrentActivity.CurrentFocus != null)
            Platform.CurrentActivity.HideKeyboard(Platform.CurrentActivity.CurrentFocus);
    }

    private void presionSistolica_Completed(object sender, EventArgs e)
    {
        if (Platform.CurrentActivity.CurrentFocus != null)
            Platform.CurrentActivity.HideKeyboard(Platform.CurrentActivity.CurrentFocus);
    }
}

