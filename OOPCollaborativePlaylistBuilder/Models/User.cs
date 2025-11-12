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
        private static List<User> users = new List<User>();
        internal static List<User> UsersList => users;

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
