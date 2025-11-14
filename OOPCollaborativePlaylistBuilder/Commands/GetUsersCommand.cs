using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaylistBuilderOOP.Models;

namespace PlaylistBuilderOOP.Commands
{
    internal class GetUsersCommand
    {
        public List<User> userList;
        public GetUsersCommand() { }        

        public List<User> Execute()
        {
            userList = User.GetAllUsers();
            return userList;
        }
    }
}
