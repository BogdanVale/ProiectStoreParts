using Microsoft.AspNetCore.Mvc;

namespace ProiectII.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
