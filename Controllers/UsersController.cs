using ImageWebApp.Models;
using ImageWebApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageWebApp.Controllers
{
    [Route("api/[controller]")]
    public class UsersController
    {
        private readonly IUserRepository _userRepository;
        //private List<User> _users = new List<User>();

        //public UsersController()
        public UsersController(IUserRepository userRepository)

        {
            _userRepository = userRepository;
            //_users.Add(new User { Id = 1, Name = "Para Zita" });
            //_users.Add(new User { Id = 2, Name = "Vegh Bela" });
        }

        [HttpGet]
        public JsonResult GetUsers()
        {
            return new JsonResult(_userRepository.GetAll());
            //return new JsonResult(_users);
        }

        [HttpGet("{id}")]
        public JsonResult GetUser(int id)
        {
            return new JsonResult(_userRepository.GetById(id));
            //return new JsonResult(_users.FirstOrDefault(e => e.Id == id));
        }
    }
}
