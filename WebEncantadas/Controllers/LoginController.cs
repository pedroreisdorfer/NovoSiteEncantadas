using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebEncantadas.Data;
using WebEncantadas.Helper;
using WebEncantadas.Models.ViewModels;

namespace WebEncantadas.Controllers
{
    public class LoginController : Controller
    {
        private readonly Contexto _context;

        private readonly ISessao _sessao;

        public LoginController(Contexto context, ISessao sessao)
        {
            _context = context;
            _sessao = sessao;
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
