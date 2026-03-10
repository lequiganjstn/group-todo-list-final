using System;
using System.Collections.Generic;
using System.Text;

namespace solo_todo_list.Models
{
    public class UserRepository
    {
        public static List<User> _users = new List<User>()
        {
            new User() { Id = 1, Name = "Justine Lequigan", Email = "justinlequigan06@gmail.com", Password = "1234" }
        };

        public static bool VerifyUser(string email, string password)
        {
            return _users.Any(u => u.Email == email && u.Password == password);
        }
    }
}
