using ImageWebApp.Models;
using System.Collections.Generic;

namespace ImageWebApp.Repositories
{
    public interface IUserRepository
    {
        //string Name { get; set; }
        List<User> GetAll();
        User GetById(int id);
    }
}