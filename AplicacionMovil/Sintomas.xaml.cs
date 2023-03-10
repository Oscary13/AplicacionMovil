namespace AplicacionMovil;

public partial class Sintomas : ContentPage
{
    SintomasHiperHipo sintomasHiperHipo = new SintomasHiperHipo();
    public int presionS;
    public int presionD;
    public Sintomas(Presion datosPresion)
    {
        InitializeComponent();
        presionS = int.Parse(datosPresion.presionSistolica);
        presionD = int.Parse(datosPresion.presionDiastolica);
    }

    private async void Sintomasxd_Clicked(object sender, EventArgs e)
    {
        //await DisplayAlert("Error", "Debes llenar todos los campos", "OK");
        if (visionBorrosa.IsToggled == true)
        {
            sintomasHiperHipo.visionBorrosa = true;
        }
        else
        {
            sintomasHiperHipo.visionBorrosa = false;
        }

        if (nauceasVomito.IsToggled == true)
        {
            sintomasHiperHipo.nauseasVomito = true;
        }
        else
        {
            sintomasHiperHipo.nauseasVomito = false;
        }

        if (hemorragiaNasal.IsToggled == true)
        {
            sintomasHiperHipo.hemorragiaNasal = true;
        }
        else
        {
            sintomasHiperHipo.hemorragiaNasal = false;
        }

        if (zumbidoOidos.IsToggled == true)
        {
            sintomasHiperHipo.zumbidoOidos = true;
        }
        else
        {
            sintomasHiperHipo.zumbidoOidos = false;
        }

        if (nerviosismo.IsToggled == true)
        {
            sintomasHiperHipo.nerviosismo = true;
        }
        else
        {
            sintomasHiperHipo.nerviosismo = false;
        }

        if (mareo.IsToggled == true)
        {
            sintomasHiperHipo.mareo = true;
        }
        else
        {
            sintomasHiperHipo.mareo = false;
        }

        if (devilidadMuscular.IsToggled == true)
        {
            sintomasHiperHipo.devilidadMuscular = true;
        }
        else
        {
            sintomasHiperHipo.devilidadMuscular = false;
        }

        if (dolorPecho.IsToggled == true)
        {
            sintomasHiperHipo.dolorPecho = true;
        }
        else
        {
            sintomasHiperHipo.dolorPecho = false;
        }

        if (palidezCuerpo.IsToggled == true)
        {
            sintomasHiperHipo.palidezCuerpo = true;
        }
        else
        {
            sintomasHiperHipo.palidezCuerpo = false;
        }

        if (cansancio.IsToggled == true)
        {
            sintomasHiperHipo.cansancio = true;
        }
        else
        {
            sintomasHiperHipo.cansancio = false;
        }

        if (alteracionSueno.IsToggled == true)
        {
            sintomasHiperHipo.alteracionSueno = true;
        }
        else
        {
            sintomasHiperHipo.alteracionSueno = false;
        }

        if (presionS < 80 || presionD < 60)
        {

            if (sintomasHiperHipo.devilidadMuscular == true || sintomasHiperHipo.nauseasVomito == true || sintomasHiperHipo.dolorPecho == true || sintomasHiperHipo.palidezCuerpo == true || sintomasHiperHipo.cansancio == true || sintomasHiperHipo.alteracionSueno == true)
            {
                await DisplayAlert("Diagnóstico", "Tu presión y sintomas indican una posible Hipotensión \n\n ¡ACUDE A TU MEDICO!", "OK");
            }
            else
            {
                await DisplayAlert("Diagnóstico", "Tu presión indica posible Hipotensión.", "OK");
            }
        }

        else if (presionS >= 80 & presionS <= 120 & presionD >= 60 & presionD <= 80)
        {
            if (sintomasHiperHipo.devilidadMuscular == true || sintomasHiperHipo.nauseasVomito == true || sintomasHiperHipo.dolorPecho == true || sintomasHiperHipo.palidezCuerpo == true || sintomasHiperHipo.cansancio == true || sintomasHiperHipo.alteracionSueno == true)
            {
                await DisplayAlert("Diagnóstico", "Tu presión esta dentro del rango normal. \n\nPero presentas sintomas de Hipotensión", "OK");
            }
            else if (sintomasHiperHipo.visionBorrosa == true || sintomasHiperHipo.nauseasVomito == true || sintomasHiperHipo.hemorragiaNasal == true || sintomasHiperHipo.zumbidoOidos == true || sintomasHiperHipo.nerviosismo == true || sintomasHiperHipo.mareo == true)
            {
                await DisplayAlert("Diagnóstico", "Tu presión esta dentro del rango normal. \n\nPero presentas sintomas de Hipertensión", "OK");
            }
            else
            {
                await DisplayAlert("Diagnóstico", "Tu presión esta dentro del rango normal.", "OK");
            }
        }

        else if (presionS >= 121 & presionS <= 129 & presionD < 80)
        {
            if (sintomasHiperHipo.devilidadMuscular == true || sintomasHiperHipo.nauseasVomito == true || sintomasHiperHipo.dolorPecho == true || sintomasHiperHipo.palidezCuerpo == true || sintomasHiperHipo.cansancio == true || sintomasHiperHipo.alteracionSueno == true)
            {
                await DisplayAlert("Diagnóstico", "Tu presión esta elevada y presentas sintomas de Hipotensión", "OK");
            }
            else if (sintomasHiperHipo.visionBorrosa == true || sintomasHiperHipo.nauseasVomito == true || sintomasHiperHipo.hemorragiaNasal == true || sintomasHiperHipo.zumbidoOidos == true || sintomasHiperHipo.nerviosismo == true || sintomasHiperHipo.mareo == true)
            {
                await DisplayAlert("Diagnóstico", "Tu presión esta elevada y presentas sintomas de Hipertensión", "OK");
            }
            else
            {
                await DisplayAlert("Diagnóstico", "Tu presión esta elevada.", "OK");
            }
        }


        else if (presionS >= 130 & presionS <= 139 || presionD >= 80 & presionD <= 89)
        {
            if (sintomasHiperHipo.devilidadMuscular == true || sintomasHiperHipo.nauseasVomito == true || sintomasHiperHipo.dolorPecho == true || sintomasHiperHipo.palidezCuerpo == true || sintomasHiperHipo.cansancio == true || sintomasHiperHipo.alteracionSueno == true)
            {
                await DisplayAlert("Diagnóstico", "Tu presión y sintomas indican una posible Hipertensión de nivel 1. \n\n ¡ACUDE A TU MEDICO!", "OK");
            }
            else if (sintomasHiperHipo.visionBorrosa == true || sintomasHiperHipo.nauseasVomito == true || sintomasHiperHipo.hemorragiaNasal == true || sintomasHiperHipo.zumbidoOidos == true || sintomasHiperHipo.nerviosismo == true || sintomasHiperHipo.mareo == true)
            {
                await DisplayAlert("Diagnóstico", "Tu presión y sintomas indican una posible Hipertensión de nivel 1. \n\n ¡ACUDE A TU MEDICO!", "OK");
            }
            else
            {
                await DisplayAlert("Diagnóstico", "Tu presión indica posible Hipertensión de nivel 1.", "OK");
            }
        }

        else if (presionS >= 140 & presionS < 180 || presionD >= 90 & presionD < 120)
        {
            if (sintomasHiperHipo.devilidadMuscular == true || sintomasHiperHipo.nauseasVomito == true || sintomasHiperHipo.dolorPecho == true || sintomasHiperHipo.palidezCuerpo == true || sintomasHiperHipo.cansancio == true || sintomasHiperHipo.alteracionSueno == true)
            {
                await DisplayAlert("Diagnóstico", "Tu presión y sintomas indican una posible Hipertensión de nivel 2. \n\n ¡ACUDE A TU MEDICO!", "OK");
            }
            else if (sintomasHiperHipo.visionBorrosa == true || sintomasHiperHipo.nauseasVomito == true || sintomasHiperHipo.hemorragiaNasal == true || sintomasHiperHipo.zumbidoOidos == true || sintomasHiperHipo.nerviosismo == true || sintomasHiperHipo.mareo == true)
            {
                await DisplayAlert("Diagnóstico", "Tu presión y sintomas indican una posible Hipertensión de nivel 2. \n\n ¡ACUDE A TU MEDICO!", "OK");
            }
            else
            {
                await DisplayAlert("Diagnóstico", "Tu presión indica posible Hipertensión de nivel 2.", "OK");
            }
        }

        else if (presionS >= 180 || presionD >= 120)
        {
            if (sintomasHiperHipo.devilidadMuscular == true || sintomasHiperHipo.nauseasVomito == true || sintomasHiperHipo.dolorPecho == true || sintomasHiperHipo.palidezCuerpo == true || sintomasHiperHipo.cansancio == true || sintomasHiperHipo.alteracionSueno == true)
            {
                await DisplayAlert("Diagnóstico", "Tu presión y sintomas indican una posible crisis de Hipertensión. \n\n ¡ACUDE A TU MEDICO!", "OK");
            }
            else if (sintomasHiperHipo.visionBorrosa == true || sintomasHiperHipo.nauseasVomito == true || sintomasHiperHipo.hemorragiaNasal == true || sintomasHiperHipo.zumbidoOidos == true || sintomasHiperHipo.nerviosismo == true || sintomasHiperHipo.mareo == true)
            {
                await DisplayAlert("Diagnóstico", "Tu presión y sintomas indican una posible crisis de Hipertensión. \n\n ¡ACUDE A TU MEDICO!", "OK");
            }
            else
            {
                await DisplayAlert("Diagnóstico", "Tu presión indica posible crisis de Hipertensión.", "OK");
            }
        }
        else
        {
            await DisplayAlert("ERROR", "Verifica los datos ingrsados.", "OK");
        }


    }
}