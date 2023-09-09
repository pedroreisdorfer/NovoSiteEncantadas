using WebEncantadas.Models.Dto;
using WebEncantadas.Models.Entities;
using WebEncantadas.Models.ViewModels;

namespace WebEncantadas.Data
{
    public interface IUsuarioRepository
    {
        LoginViewModel EfetuarLogin(LoginViewModel login);
        Usuario BuscarLogin(LoginViewModel login); // quando achar um login, vai criar objeto de Usuario, pois o mesmo se torna usuário após estar logado
    }
}
