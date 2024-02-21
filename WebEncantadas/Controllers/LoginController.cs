using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEncantadas.Data;
using WebEncantadas.Helper;
using WebEncantadas.Models.Contracts.Services;
using WebEncantadas.Models.Entities;
using WebEncantadas.Models.ViewModels;

namespace WebEncantadas.Controllers
{
    public class LoginController : Controller
    {
        private readonly Contexto _context;
        private readonly ISessao _sessao;
        private readonly ConnectionManager _connection = new ConnectionManager();
        private readonly IUsuarioService _usuarioService;

        public LoginController(ISessao sessao, IUsuarioService usuarioService, Contexto contexto)
        {
            _sessao = sessao;
            _usuarioService = usuarioService;
            _context = contexto;
        }
        public IActionResult Login()
        {
            //se usuário estiver logado, redirecionar para a home
            if(_sessao.BuscarSessaoUsuario() != null)
            {
                ViewBag.UsuarioLogado = true;
                return RedirectToAction("Index", "Home");
            }
            ViewBag.UsuarioLogado = false;
            return View();
        }

        public IActionResult SairSessaoUsuario()
        {
            _sessao.RemoverSessaoUsuario();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logar(string login, string senha)
        {
            try
            {
                // retorno da View precisa ser revisto
                if (ModelState.IsValid)
                {
                    bool usuarioValido = await _usuarioService.ValidarUsuario(login, senha);
                    if (usuarioValido)
                    {
                        Usuario usuario = new Usuario();
                        usuario.Login = login;
                        usuario.Senha = senha;
                        _sessao.CriarSessaoUsuario(usuario);
                        TempData["usuarioLogado"] = usuario.Login;
                        TempData["login"] = usuario.Login;
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        TempData["MensagemErro"] = $"Login inválido";
                    }

                    //var query =  SqlManager.GetSql(Models.TSql.EFETUAR_LOGIN);

                }
                return View("Index");

    }
            catch (System.Exception)
            {

                throw;
            };
        }
    }
}
