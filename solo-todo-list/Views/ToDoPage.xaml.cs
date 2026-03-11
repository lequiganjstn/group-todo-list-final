using solo_todo_list.Models;
using System.Collections.ObjectModel;

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

    }

    private void CompleteBtn_Clicked(object sender, EventArgs e)
    {

    }

    private void AddBtn_Clicked(object sender, EventArgs e)
    {

    }

    private async void ToDoListView_OnItemSelected(object? sender, SelectedItemChangedEventArgs e)
    {
	    await Shell.Current.GoToAsync(nameof(EditTaskPage));
    }
}