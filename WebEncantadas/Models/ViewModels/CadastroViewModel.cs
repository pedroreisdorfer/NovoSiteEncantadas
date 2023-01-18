using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEncantadas.Models.Entities;

namespace WebEncantadas.Models.ViewModels
{
    public class CadastroViewModel : EntidadeBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string NomeCrianca { get; set; }
        public int IdadeCrianca { get; set; }

        public CadastroViewModel()
        {
        }

        public CadastroViewModel(string id, string nome, string email, string NomeCrianca, int IdadeCrianca)
            : this(nome, email, NomeCrianca, IdadeCrianca)
        {
            this.Id = id;
        }

        public CadastroViewModel(string nome, string email, string nomeCrianca, int idadeCrianca)
        {
            Nome = nome;
            Email = email;
            NomeCrianca = nomeCrianca;
            IdadeCrianca = idadeCrianca;
        }


    }
}
