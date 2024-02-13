using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using WebEncantadas.Models.Entities;

namespace WebEncantadas.Helper
{
   
    public class Sessao : ISessao
    {
        private readonly IHttpContextAccessor httpContext_;

        public Sessao(IHttpContextAccessor httpContext_)
        {
            this.httpContext_ = httpContext_;
        }

        public Usuario BuscarSessaoUsuario()
        {
            string sessaoUsuario = httpContext_.HttpContext.Session.GetString("sessaoUsuarioLogado");
            if (string.IsNullOrEmpty(sessaoUsuario))
            {
                return null;
            }

            Usuario usuarioLogado = JsonConvert.DeserializeObject<Usuario>(sessaoUsuario);
            return usuarioLogado;
        }

        public void CriarSessaoUsuario(Usuario usuario)
        {
            string usuarioJson = JsonConvert.SerializeObject(usuario);
            httpContext_.HttpContext.Session.SetString("sessaoUsuarioLogado", usuarioJson);
        }

        public void RemoverSessaoUsuario()
        {
            httpContext_.HttpContext.Session.Remove("sessaoUsuarioLogado");
        }
    }
}
