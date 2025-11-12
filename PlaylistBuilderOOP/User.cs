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

        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }

        public User(string id, string name)
        {
            Id = id;
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
