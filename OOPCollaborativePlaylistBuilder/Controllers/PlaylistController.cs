using Microsoft.AspNetCore.Mvc;

namespace OOPCollaborativePlaylistBuilder.Controllers
{
    public class PlaylistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
