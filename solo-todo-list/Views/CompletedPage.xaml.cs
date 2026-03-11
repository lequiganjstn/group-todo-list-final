using solo_todo_list.Models;
using System.Collections.ObjectModel;

namespace solo_todo_list.Views;

public partial class CompletedPage : ContentPage
{
	public CompletedPage()
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
        ObservableCollection<ToDoList> toDoLists = new ObservableCollection<ToDoList>(ToDoRepository.GetCompletedToDoList());
        ToDoListView.ItemsSource = toDoLists;
    }

    private async void ToDoListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (ToDoListView.SelectedItem != null)
        {
            await Shell.Current.GoToAsync($"{nameof(EditCompletedTaskPage)}?Id={((ToDoList)ToDoListView.SelectedItem).ItemId}");
        }
    }

    private void ToDoListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        ToDoListView.SelectedItem = null;
    }

    private void DeleteBtn_Clicked(object sender, EventArgs e)
    {
        var menuItem = sender as Button;
        ToDoList task = menuItem.CommandParameter as ToDoList;

        ToDoRepository.DeleteTask(task);
        LoadToDoList();
    }
}