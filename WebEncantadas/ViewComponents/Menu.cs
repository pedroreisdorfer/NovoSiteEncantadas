using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;
using WebEncantadas.Models.Entities;

namespace WebEncantadas.ViewComponents
{
    public class Menu : ViewComponent
    {
        // dentro do ViewComponent eu já tenho um httpContext
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string sessaoUsuario = HttpContext.Session.GetString("sessaoUsuarioLogado");

            if (string.IsNullOrEmpty(sessaoUsuario))
            {
                return View();
            }


            Usuario usuarioLogado = JsonConvert.DeserializeObject<Usuario>(sessaoUsuario);


            return View(usuarioLogado);
        }
    }
}
