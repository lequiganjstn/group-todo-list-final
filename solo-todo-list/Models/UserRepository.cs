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

        public static User? SignInUser(string email, string password)
        {
            return _users.FirstOrDefault(u => u.Email.ToLower() == email && u.Password == password);
        }

        public static void SignUpUser(string name, string email, string password)
        {
            int userId = _users.Max(u => u.Id) + 1;
            
            _users.Add(new User()
            {
                Id = userId,
                Name = name,
                Email = email,
                Password = password
            });
        }
    }
}
