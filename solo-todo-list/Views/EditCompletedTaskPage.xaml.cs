using solo_todo_list.Models;
using System.Threading.Tasks;

namespace solo_todo_list.Views;

[QueryProperty(nameof(taskId), "Id")]
public partial class EditCompletedTaskPage : ContentPage
{
    private ToDoList task;
	public EditCompletedTaskPage()
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
        ToDoRepository.UpdateTask(task);

        await Shell.Current.GoToAsync("..");
    }

    private async void IncompleteBtn_Clicked(object sender, EventArgs e)
    {
        ToDoRepository.IncompleteTask(task);

        await Shell.Current.GoToAsync("..");
    }

    private async void DeleteBtn_Clicked(object sender, EventArgs e)
    {
        ToDoRepository.DeleteTask(task);

        await Shell.Current.GoToAsync("..");
    }
}