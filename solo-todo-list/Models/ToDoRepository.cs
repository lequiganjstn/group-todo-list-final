namespace solo_todo_list.Models
{
    public class ToDoRepository
    {
        public static List<ToDoList> _todolist = new List<ToDoList>()
        {
            new ToDoList() { Id = 1, Title = "Pick up the laundry", Details = "Pickup the laundry in Plum's Laundry"},
            new ToDoList() { Id = 2, Title = "Clean the living room", Details = "Clean the floor and the table"},
            new ToDoList() { Id = 3, Title = "Reply to emails", Details = "Reply to Plum's confirmation email"},
            new ToDoList() { Id = 4, Title = "Attend meeting", Details = "Attend the online meet for resource planning"},
            new ToDoList() { Id = 5, Title = "Complete project deliverables", Details = "Complete the login and signup page for Plum's To-Do List mobile app"},
            new ToDoList() { Id = 6, Title = "Update status report", Details = "Update status report from In Progress to Done"},
            new ToDoList() { Id = 7, Title = "Schedule appointments", Details = "Schedule tutor appointment from Plum"},
            new ToDoList() { Id = 8, Title = "Go to the gym", Details = "Go to the gym and hit legs"},
            new ToDoList() { Id = 9, Title = "Make your bed", Details = "Fold the blanket, arrange the pillows, and pick up trash in the floor"},
            new ToDoList() { Id = 10, Title = "Buy eggs and chicken breast", Details = "Buy in Plum's supermarket to save 6.7% off"}
        };

        public static List<ToDoList> GetToDoList() {
            return _todolist;
        }
    }
}
