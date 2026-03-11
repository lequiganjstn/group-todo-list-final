namespace solo_todo_list.Models
{
    public class ToDoRepository
    {
        public static List<ToDoList> _todolist = new List<ToDoList>()
        {
            new ToDoList() { ItemId = 1, Title = "Pick up the laundry", Details = "Pickup the laundry in Plum's Laundry", Status = "active",  UserId = 1 },
            new ToDoList() { ItemId = 2, Title = "Clean the living room", Details = "Clean the floor and the table", Status = "active",  UserId = 1},
            new ToDoList() { ItemId = 3, Title = "Reply to emails", Details = "Reply to Plum's confirmation email", Status = "active",  UserId = 1},
            new ToDoList() { ItemId = 4, Title = "Attend meeting", Details = "Attend the online meet for resource planning", Status = "active",  UserId = 1},
            new ToDoList() { ItemId = 5, Title = "Complete project deliverables", Details = "Complete the login and signup page for Plum's To-Do List mobile app", Status = "active",  UserId = 1},
            new ToDoList() { ItemId = 6, Title = "Update status report", Details = "Update status report from In Progress to Done",  Status = "active",  UserId = 1},
            new ToDoList() { ItemId = 7, Title = "Schedule appointments", Details = "Schedule tutor appointment from Plum", Status = "active",  UserId = 1},
            new ToDoList() { ItemId = 8, Title = "Go to the gym", Details = "Go to the gym and hit legs", Status = "active",  UserId = 1},
            new ToDoList() { ItemId = 9, Title = "Make your bed", Details = "Fold the blanket, arrange the pillows, and pick up trash in the floor", Status = "active",  UserId = 1},
            new ToDoList() { ItemId = 10, Title = "Buy eggs and chicken breast", Details = "Buy in Plum's supermarket to save 6.7% off", Status = "active",  UserId = 1}
        };

        public static List<ToDoList> GetToDoList() {
            return _todolist.Where(x => x.Status == "active").ToList();
        }

        public static List<ToDoList> GetCompletedToDoList()
        {
            return _todolist.Where(x => x.Status == "inactive").ToList();
        }

        public static ToDoList GetTaskById(int taskId)
        {
            return _todolist.FirstOrDefault(t => t.ItemId == taskId);
        }

        public static void AddTask(string title, string details)
        {
            int id = _todolist.Max(t => t.ItemId) + 1;
            
            _todolist.Add(new ToDoList()
            {
                ItemId = id,
                Title = title,
                Details = details,
                Status = "active",
                UserId = UserSession.Id
            });
        }

        public static void UpdateTask(ToDoList toDoList)
        {
            ToDoList task = _todolist.FirstOrDefault(t => t.ItemId == toDoList.ItemId);
            
            task.Title = toDoList.Title;
            task.Details = toDoList.Details;
            task.Status = toDoList.Status;
        }

        public static void DeleteTask(ToDoList toDoList)
        {
            _todolist.Remove(toDoList);
        }

        public static void CompleteTask(ToDoList toDoList)
        {
            ToDoList task = _todolist.FirstOrDefault(t => t.ItemId == toDoList.ItemId);

            task.Status = "inactive";
        }

        public static void IncompleteTask(ToDoList toDoList)
        {
            ToDoList task = _todolist.FirstOrDefault(t => t.ItemId == toDoList.ItemId);

            task.Status = "active";
        }
    }
}
