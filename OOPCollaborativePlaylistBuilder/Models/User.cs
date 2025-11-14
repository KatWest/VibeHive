using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistBuilderOOP
{
    public class User
    {
        private static List<User> users = new List<User>
        {
            new User("Alice"),
            new User("Bob"),
            new User ("Charlie"),
            new User ("Diana"),
            new User ("Ethan"),
            new User ("Fiona"),
            new User ("George"),
            new User ("Hannah"),
            new User ("Isaac"),
            new User ("Julia")
        };
        public static List<User> UsersList => users;

        public string Id { get; set; } 
        public string Name { get; set; }

        public User( string name)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
        }

        public static List<User> GetAllUsers()
        {
            if(UsersList == null)
            {
                return null;
            }
            return UsersList;
        }
    }
}
