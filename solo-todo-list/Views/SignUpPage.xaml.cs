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
        await Navigation.PopAsync();
    }

    private async Task SignInBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}