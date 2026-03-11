using solo_todo_list.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace solo_todo_list.Views;

public partial class ToDoPage : ContentPage
{
	public ToDoPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

		LoadToDoList();
    }

	private void LoadToDoList()
	{
		ObservableCollection<ToDoList> toDoLists = new ObservableCollection<ToDoList>( ToDoRepository.GetToDoList() );
		ToDoListView.ItemsSource = toDoLists; 
	}

    private void DeleteBtn_Clicked(object sender, EventArgs e)
    {
        var menuItem = sender as Button;
        ToDoList task = menuItem.CommandParameter as ToDoList;

        ToDoRepository.DeleteTask(task);
        LoadToDoList();
    }

    private void CompleteBtn_Clicked(object sender, EventArgs e)
    {
        var menuItem = sender as Button;
        ToDoList task = menuItem.CommandParameter as ToDoList;

        ToDoRepository.CompleteTask(task);
        LoadToDoList();
    }

    private async void AddBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AddTaskPage));
    }

    private async void ToDoListView_OnItemSelected(object? sender, SelectedItemChangedEventArgs e)
    {
	    if (ToDoListView.SelectedItem != null)
        {
            await Shell.Current.GoToAsync($"{nameof(EditTaskPage)}?Id={((ToDoList)ToDoListView.SelectedItem).ItemId}");
        }
    }

    private void ToDoListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        ToDoListView.SelectedItem = null;
    }
}