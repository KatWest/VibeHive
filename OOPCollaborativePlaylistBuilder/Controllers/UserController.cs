using Microsoft.AspNetCore.Mvc;
using PlaylistBuilderOOP;
using PlaylistBuilderOOP.Commands;

namespace OOPCollaborativePlaylistBuilder.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult<List<User>> GetAllUsers() 
        {
            var getUserList = new GetUsersCommand();
            List<User> userList = getUserList.Execute();

            if(userList == null)
            {
                throw new Exception(message: "There was an error getting a list of all users.");
            }

            return Ok(userList);
        }
    }
}
