namespace SOPApp.Mobile.Pages;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}
    private async void LoginClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Pages.LoginPage());
    }
}