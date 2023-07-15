using Microsoft.EntityFrameworkCore;
using WebEncantadas.Models.ViewModels;

namespace WebEncantadas.Data
{
    public class Contexto : DbContext
    {
        //dbset define os modelos que serão controlados
        public DbSet<CadastroViewModel> Cadastro { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        // Construtor: My Context recebe DbConetextOptions, que tem como parâmetro o Contexto e devolve um options. Depois do :, ai a classe é passada para a base. Construtor padrão, pois preciso passar Contexto para a Base - injetando options dentro da base.
    }
}
