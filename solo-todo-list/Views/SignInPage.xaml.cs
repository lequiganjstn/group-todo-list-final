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
        User user = UserRepository.SignInUser(EmailEntry.Text, PasswordEntry.Text);
        
        if (user != null)
        {
            UserSession.Id = user.Id;
            UserSession.Name = user.Name;
            UserSession.Email = user.Email;
            UserSession.Password = user.Password;
            
            Application.Current.MainPage = new AppShell();
        } else
        {
            DisplayAlertAsync("Error", "Invalid information!", "OK");
        }  
    }

    private async void SignUpBtn_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new SignUpPage());
        }
        catch (Exception ex)
        {
            await DisplayAlertAsync("Error", ex.Message, "OK");
        }
    }
}