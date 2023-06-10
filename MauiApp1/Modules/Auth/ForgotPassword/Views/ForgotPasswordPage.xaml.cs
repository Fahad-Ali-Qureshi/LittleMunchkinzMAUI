namespace MauiApp1.Modules.Auth.ForgotPassword.Views;

public partial class ForgotPasswordPage : ContentPage
{
	public ForgotPasswordPage()
	{
		InitializeComponent();
		BindingContext = this;
	}

    private void Button_Submit_Clicked(object sender, EventArgs e)
    {
        IsBusy = true;
        DisplayAlert("Reset Password", "Reset Password functionality will be implemented soon.", "OK");
        IsBusy = false;
        Navigation.PopModalAsync();
    }

    private void Button_Cancel_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}