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
        CompletedToDoListView.ItemsSource = toDoLists;
    }

    private async void CompletedToDoListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (CompletedToDoListView.SelectedItem != null)
        {
            await Shell.Current.GoToAsync($"{nameof(EditCompletedTaskPage)}?Id={((ToDoList)CompletedToDoListView.SelectedItem).ItemId}");
        }
    }

    private void CompletedToDoListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        CompletedToDoListView.SelectedItem = null;
    }

    private void DeleteBtn_Clicked(object sender, EventArgs e)
    {
        var menuItem = sender as Button;
        ToDoList task = menuItem.CommandParameter as ToDoList;

        ToDoRepository.DeleteTask(task);
        LoadToDoList();
    }
}