using solo_todo_list.Views;

namespace solo_todo_list
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(AddTaskPage), typeof(AddTaskPage));
            Routing.RegisterRoute(nameof(CompletedPage), typeof(CompletedPage));
            Routing.RegisterRoute(nameof(EditCompletedTaskPage), typeof(EditTaskPage));
            Routing.RegisterRoute(nameof(EditTaskPage), typeof(EditTaskPage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
            //Routing.RegisterRoute(nameof(SignInPage), typeof(SignInPage));
            //Routing.RegisterRoute(nameof(SignUpPage), typeof(SignUpPage));
            Routing.RegisterRoute(nameof(ToDoPage), typeof(ToDoPage));
        }
    }
}
