using solo_todo_list.Models;

namespace solo_todo_list.Views;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();

		NameLabel.Text = UserSession.Name;
	}

    private void SignOutBtn_Clicked(object sender, EventArgs e)
    {
		Application.Current.MainPage = new NavigationPage(new SignInPage());
    }
}