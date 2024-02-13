using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEncantadas.Data;
using WebEncantadas.Models.Contracts.Services;
using WebEncantadas.Models.Dto;
using WebEncantadas.Models.Entities;
using WebEncantadas.Models.ViewModels;

namespace WebEncantadas.Business.ServiceLogin
{
    public class LoginService : IUsuarioService
    {
        private readonly Contexto _context;

        public LoginService(Contexto context)
        {
            _context = context;
        }

        public Task<UsuarioDto> EfetuarLogin(UsuarioDto usuario)
        {
            throw new System.NotImplementedException();
        }

        // criar interface para essa função
        public async Task<bool> ValidarUsuario(string login, string senha)
        {
            bool usuarioValido = false;
            LoginViewModel loginViewModel = new LoginViewModel();
            loginViewModel.Login = login;
            loginViewModel.Senha = senha;

            List<CadastroViewModel> listaCasdastros = _context.Cadastro.ToList();

            //List<CadastroViewModel> listaCasdastroList = (List<CadastroViewModel>)_context.Cadastro.Where(x => x.Email == login && x.Senha == senha);

            foreach (var item in listaCasdastros)
            {
                if (item.Email == login && item.Senha == senha)
                {
                    usuarioValido = true;
                    break;
                }
            }
            return usuarioValido;
        }
    }
}
