using Microsoft.Extensions.DependencyInjection;
using solo_todo_list.Views;

namespace solo_todo_list
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new SignInPage()));
        }
    }
}