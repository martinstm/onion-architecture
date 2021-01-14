using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Group
    {
        public int Id { get; }
        public string Name { get; }
        public IEnumerable<int> Users { get; }

        public Group(int id, string name, IEnumerable<int> users)
        {
            Id = id;
            Name = name;
            Users = users;
        }
    }
}
