using System.Threading.Tasks;
using WebEncantadas.Models.Dto;

namespace WebEncantadas.Models.Contracts.Services
{
    public interface IUsuarioService
    {
        Task<UsuarioDto> EfetuarLogin(UsuarioDto usuario);
        Task<bool> ValidarUsuario(string login, string senha);
    }
}
