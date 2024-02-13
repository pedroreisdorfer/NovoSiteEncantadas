using WebEncantadas.Models.Dto;
using WebEncantadas.Models.Entities;
using WebEncantadas.Models.ViewModels;

namespace WebEncantadas.Data
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Contexto _context;

        public UsuarioRepository(Contexto context)
        {
            _context = context;
        }
        public Usuario BuscarLogin(LoginViewModel login)
        {
            throw new System.NotImplementedException();
        }


    }
}
