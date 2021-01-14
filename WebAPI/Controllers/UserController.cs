using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/users/")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private List<User> _inMemoryUsers;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;

            _inMemoryUsers = new List<User>()
            {
                new User(1, "John", "john@mail.com", true),
                new User(2, "Lisa", "lisa@mail.com", true),
                new User(3, "Bernard", "bernard@mail.com", false)
            };
        }

        [HttpGet("all")]
        public IEnumerable<User> GetAll()
        {
            return _inMemoryUsers;
        }

        [HttpGet("{id}")]
        public User GetById(int id)
        {
            return _inMemoryUsers.SingleOrDefault(u => u.Id == id);
        }
    }
}
