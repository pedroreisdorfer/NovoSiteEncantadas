using WebEncantadas.Models.Dto;

namespace WebEncantadas.Data
{
    public interface IUsuarioRepository
    {
        UsuarioDto EfetuarLogin(UsuarioDto usuarioDto);
    }
}
