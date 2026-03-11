using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solo_todo_list.Models;

namespace solo_todo_list.Views;

public partial class AddTaskPage : ContentPage
{
    public AddTaskPage()
    {
        InitializeComponent();
    }

    private async void AddBtn_OnClicked(object? sender, EventArgs e)
    {
        ToDoRepository.AddTask(TitleEntry.Text, DetailsEntry.Text);
        
        await Shell.Current.GoToAsync("..");
    }
}