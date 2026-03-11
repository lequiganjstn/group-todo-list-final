using solo_todo_list.Models;
using System.Threading.Tasks;

namespace solo_todo_list.Views;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}

    private async void SignUpBtn_Clicked(object sender, EventArgs e)
    {
        if (NameEntry.Text != null && EmailEntry.Text != null && PasswordEntry.Text != null && ConfirmPasswordEntry.Text != null && PasswordEntry.Text == ConfirmPasswordEntry.Text)
        {
            UserRepository.SignUpUser(NameEntry.Text, EmailEntry.Text, PasswordEntry.Text);
            await Navigation.PopAsync();
        } else
        {
            await DisplayAlertAsync("Error", "Invalid information!", "OK");
        }
    }

    private async void SignInBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}