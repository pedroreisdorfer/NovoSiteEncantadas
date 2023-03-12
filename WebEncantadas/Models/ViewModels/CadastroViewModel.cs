using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEncantadas.Models.Entities;

namespace WebEncantadas.Models.ViewModels
{
    public class CadastroViewModel : EntidadeBase
    {
        //Cadastro responsável
        public string NomeResponsavel { get; set; }
        public int CPF { get; set; }
        public string Email { get; set; }
        public string ConfirmacaoEmail { get; set; }
        public int Contato { get; set; }
        public int ContatoEmergencial { get; set; }

        // Cadastro crianças

        public string NomeCrianca_1 { get; set; }
        public int IdadeCrianca_1 { get; set; }
        public DateTime DataDeNascimento_1 { get; set; } // ajustar conforme mês da festa
        public string RestricaoAlimentar_1 { get; set; }

        // para opção de adicionar mais crianças:
        public string NomeCrianca_2 { get; set; }
        public int IdadeCrianca_2 { get; set; }
        public DateTime DataDeNascimento_2 { get; set; } // ajustar conforme mês da festa
        public string RestricaoAlimentar_2 { get; set; }

        public string NomeCrianca_3 { get; set; }
        public int IdadeCrianca_3 { get; set; }
        public DateTime DataDeNascimento_3 { get; set; } // ajustar conforme mês da festa
        public string RestricaoAlimentar_3 { get; set; }

        public string NomeCrianca_4 { get; set; }
        public int IdadeCrianca_4 { get; set; }
        public DateTime DataDeNascimento_4 { get; set; } // ajustar conforme mês da festa
        public string RestricaoAlimentar_4 { get; set; }


        public CadastroViewModel()
        {
        }

        //public CadastroViewModel(string id, int cpf, string nome, int contato, string email, string confirmacaoEmail, string NomeCrianca, int IdadeCrianca)
        //    : this(nome, cpf, contato, email, confirmacaoEmail, NomeCrianca, IdadeCrianca)
        //{
        //    this.Id = id;
        //}
    }
}
