using solo_todo_list.Models;

namespace solo_todo_list.Views;

public partial class SignInPage : ContentPage
{
	public SignInPage()
	{
		InitializeComponent();
	}

    private void SignInBtn_Clicked(object sender, EventArgs e)
    {
        if (UserRepository.VerifyUser(EmailEntry.Text, PasswordEntry.Text))
        {
            Application.Current.MainPage = new AppShell();
        } else
        {
            DisplayAlertAsync("Error", "Invalid information!", "OK");
        }  
    }

    private async void SignUpBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SignUpPage());
    }
}