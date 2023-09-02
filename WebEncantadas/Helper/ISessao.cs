using WebEncantadas.Models.Entities;

namespace WebEncantadas.Helper
{
    public interface ISessao
    {
        public void CriarSessaoUsuario(Usuario usuario);

        public void RemoverSessaoUsuario();

        public Usuario BuscarSessaoUsuario();
    }
}
