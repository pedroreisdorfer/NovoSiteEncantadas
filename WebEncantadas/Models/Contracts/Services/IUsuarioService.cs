using WebEncantadas.Models.Dto;

namespace WebEncantadas.Models.Contracts.Services
{
    public interface IUsuarioService
    {
        UsuarioDto EfetuarLogin(UsuarioDto usuario);
    }
}
