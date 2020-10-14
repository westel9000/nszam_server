using ImageWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageWebApp.Repositories
{
    public class UserRepository : IUserRepository
    {
        //public string Name { get; set; }

        private List<User> _users = new List<User>();
        public UserRepository()
        {
            _users.Add(new User { Id = 1, Name = "Para Zita" });
            _users.Add(new User { Id = 2, Name = "Vegh Bela" });
        }
        public List<User> GetAll()
        {
            return _users;
        }
        public User GetById(int id)
        {
            return _users.FirstOrDefault(e => e.Id == id);
        }
    }
}
