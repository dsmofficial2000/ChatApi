using Microsoft.AspNetCore.Mvc;

namespace ChatApi.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
