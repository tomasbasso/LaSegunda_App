namespace AplicacionMovil.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

        bool isValid = ValidateCredentials(username, password);
        if (!isValid)
        {
            ErrorMessageLabel.Text = "Usuario o contrase�a incorrectos. Por favor, int�ntelo de nuevo.";
            ErrorMessageLabel.IsVisible = true;
        }
        else
        {
            // Redirigir a la p�gina principal o realizar otra acci�n
            await Navigation.PushAsync(new PrincipalPage());
        }
    }

    private bool ValidateCredentials(string username, string password)
    {
        // L�gica de validaci�n de credenciales
        // Esto es solo un ejemplo, debes reemplazarlo con tu l�gica de autenticaci�n real
        return username == "admin" && password == "admin";
    }
}
