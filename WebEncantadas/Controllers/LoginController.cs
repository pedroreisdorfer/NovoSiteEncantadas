using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebEncantadas.Data;
using WebEncantadas.Models.ViewModels;

namespace WebEncantadas.Controllers
{
    public class LoginController : Controller
    {
        private readonly Contexto _context;

        public LoginController(Contexto context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }

        //public async Task<IActionResult> Login_(LoginViewModel login)
        //{
        //    // retorno da View precisa ser revisto
        //    if (ModelState.IsValid)
        //    {
        //        _context.Find(login.Login);
        //        await _context.SaveChangesAsync();

        //        return RedirectToAction("Login");
        //    }
        //    return View(login);
        //}
    }
}
