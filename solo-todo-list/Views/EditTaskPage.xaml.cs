using solo_todo_list.Models;

namespace solo_todo_list.Views;

[QueryProperty(nameof(taskId), "Id")]
public partial class EditTaskPage : ContentPage
{
    private ToDoList task;
    public EditTaskPage()
    {
        InitializeComponent();
    }

    public string taskId
    {
        set
        {
            task = ToDoRepository.GetTaskById(int.Parse(value));

            TitleEntry.Text = task.Title;
            DetailsEntry.Text = task.Details;
        }
    }

    private async void UpdateBtn_Clicked(object sender, EventArgs e)
    {
        task.Title = TitleEntry.Text;
        task.Details = DetailsEntry.Text;

        ToDoRepository.UpdateTask(task);

        await Shell.Current.GoToAsync("..");
    }

    private async void CompleteBtn_Clicked(object sender, EventArgs e)
    {
        ToDoRepository.CompleteTask(task);

        await Shell.Current.GoToAsync("..");
    }

    private async void DeleteBtn_Clicked(object sender, EventArgs e)
    {
        ToDoRepository.DeleteTask(task);

        await Shell.Current.GoToAsync("..");
    }
}