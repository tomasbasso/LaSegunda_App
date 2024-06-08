namespace AplicacionMovil.Views;

public partial class PrincipalPage : ContentPage
{
	public PrincipalPage()
	{
		InitializeComponent();
	}

    private void btn_regresar_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AcercaDePage());
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
}