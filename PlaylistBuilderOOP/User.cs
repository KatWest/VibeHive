using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistBuilderOOP
{
    public class User
    {
        public static List<User> Users { get; set; }

        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }

        public User(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
