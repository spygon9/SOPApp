namespace SOPApp.Mobile.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
    private async void LoginClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Pages.HomePage());
    }

    private async void RegisterClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Pages.RegisterPage());
    }
}