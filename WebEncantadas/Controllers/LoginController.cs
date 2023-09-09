using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEncantadas.Data;
using WebEncantadas.Helper;
using WebEncantadas.Models.Entities;
using WebEncantadas.Models.ViewModels;

namespace WebEncantadas.Controllers
{
    public class LoginController : Controller
    {
        private readonly Contexto _context;

        private readonly ISessao _sessao;
        private readonly ConnectionManager _connection = new ConnectionManager();

        public LoginController(Contexto context, ISessao sessao)
        {
            _context = context;
            _sessao = sessao;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logar(string login, string senha)
        {
            // retorno da View precisa ser revisto
            if (ModelState.IsValid)
            {
                LoginViewModel loginViewModel = new LoginViewModel();
                loginViewModel.Login = login;
                loginViewModel.Senha = senha;

                List<CadastroViewModel> listaCasdastros = _context.Cadastro.ToList();

                Usuario usuario = new Usuario();

                //essa verificação pode ser feita dentro de uma determinada função

                foreach(var item in listaCasdastros)
                {
                    if(item.Email == login && item.Senha == senha)
                    {
                        usuario.Login = login;
                        usuario.Senha = senha;
                        break; // caso achou eu pulo fora do laço de repetição.
                    }
                }

                //var query =  SqlManager.GetSql(Models.TSql.EFETUAR_LOGIN);

                //List<CadastroViewModel> listaCasdastroList = (List<CadastroViewModel>)_context.Cadastro.Where(x => x.Email == login && x.Senha == senha);

                await _context.SaveChangesAsync();

                return RedirectToAction("Login");
            }
            return View(login);
        }
    }
}
