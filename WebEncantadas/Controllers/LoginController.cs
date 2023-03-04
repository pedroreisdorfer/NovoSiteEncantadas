using Microsoft.AspNetCore.Mvc;

namespace WebEncantadas.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
