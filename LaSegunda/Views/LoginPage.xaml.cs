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
            ErrorMessageLabel.Text = "Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.";
            ErrorMessageLabel.IsVisible = true;
        }
        else
        {
            // Redirigir a la página principal o realizar otra acción
            await Navigation.PushAsync(new PrincipalPage());
        }
    }

    private bool ValidateCredentials(string username, string password)
    {
        // Lógica de validación de credenciales
        // Esto es solo un ejemplo, debes reemplazarlo con tu lógica de autenticación real
        return username == "admin" && password == "admin";
    }
}
