using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;

namespace WebAPI.Controllers
{
    [Route("api/groups")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly ILogger<GroupController> _logger;
        private List<Group> _inMemoryGroups;

        public GroupController(ILogger<GroupController> logger)
        {
            _logger = logger;
            _inMemoryGroups = new List<Group>()
            {
                new Group(1, "Manager", new []{ 1 }),
                new Group(2, "Developers", new []{ 2, 3 })
            };
        }

        [HttpGet("all")]
        public IEnumerable<Group> GetAll()
        {
            return _inMemoryGroups;
        }

        [HttpGet("{id}")]
        public Group GetById(int id)
        {
            return _inMemoryGroups.SingleOrDefault(u => u.Id == id);
        }
    }
}