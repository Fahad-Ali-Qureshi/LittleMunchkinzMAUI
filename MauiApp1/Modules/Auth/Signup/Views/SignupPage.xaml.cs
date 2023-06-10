using MauiApp1.Modules.Auth.Login.Views;

namespace MauiApp1.Modules.Auth.Signup.Views;

public partial class SignupPage : ContentPage
{
	public SignupPage()
	{
		InitializeComponent();
		BindingContext = this;
	}

    private void Button_Login_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new LoginPage();
    }

    private void Button_Signup_Clicked(object sender, EventArgs e)
    {
        IsBusy = true;
        DisplayAlert("Signup", "Signup functionality will be implemented soon.", "OK");
        IsBusy = false;
    }

    private void Label_GuestMode_Tapped(object sender, TappedEventArgs e)
    {
        DisplayAlert("Guest Mode", "User will proceed without signup and will be guest mode.", "OK");
    }

    private void Label_TermsOfService_Tapped(object sender, TappedEventArgs e)
    {
        DisplayAlert("Terms of Service", "This will show you he terms and service.", "OK");
    }
}