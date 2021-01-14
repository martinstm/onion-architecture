using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        public int Id { get; }
        public string Name { get; }
        public string Email { get; }
        public bool Active { get; }

        public User(int id, string name, string email, bool active)
        {
            Id = id;
            Name = name;
            Email = email;
            Active = active;
        }
    }
}
