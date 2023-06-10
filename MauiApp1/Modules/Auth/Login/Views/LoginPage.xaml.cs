using MauiApp1.Modules.Auth.ForgotPassword.Views;
using MauiApp1.Modules.Auth.Signup.Views;

namespace MauiApp1.Modules.Auth.Login.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = this;
    }

    private void Button_Signup_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new SignupPage();
    }

    private void Button_Login_Clicked(object sender, EventArgs e)
    {
        IsBusy = true;
        DisplayAlert("Login", "Login functionality will be implemented soon.", "OK");
        IsBusy = false;
    }

    private void Label_ForgotPasswordOption_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushModalAsync(new ForgotPasswordPage());
    }

    private void Label_TermsOfService_Tapped(object sender, TappedEventArgs e)
    {
        DisplayAlert("Terms of Service", "This will show you he terms and service.", "OK");
    }
}