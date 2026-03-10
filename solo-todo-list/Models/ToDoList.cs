using System;
using System.Collections.Generic;
using System.Text;

namespace solo_todo_list.Models
{
    public class ToDoList()
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
    }
}
