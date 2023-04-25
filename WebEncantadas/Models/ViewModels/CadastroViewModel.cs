using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebEncantadas.Models.Entities;

namespace WebEncantadas.Models.ViewModels
{
    [Table("Cadastro")]
    public class CadastroViewModel : EntidadeBase
    {
        //Cadastro responsável
        [Column("id")]
        [Display(Name = "ccdigo")]
        public int id { get; set; }

        [Column("NomeResponsavel")]
        [Display(Name = "NomeResponsavel")]
        public string NomeResponsavel { get; set; }

        [Column("CPF")]
        [Display(Name = "CPF")]
        public int CPF { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Column("ConfirmacaoEmail")]
        [Display(Name = "ConfirmacaoEmail")]
        public string ConfirmacaoEmail { get; set; }

        [Column("Contato")]
        [Display(Name = "Contato")]
        public int Contato { get; set; }

        [Column("ContatoEmergencial")]
        [Display(Name = "ContatoEmergencial")]
        public int ContatoEmergencial { get; set; }

        // Cadastro crianças

        [Column("NomeCrianca_1")]
        [Display(Name = "NomeCrianca_1")]
        public string NomeCrianca_1 { get; set; }

        [Column("IdadeCrianca_1")]
        [Display(Name = "IdadeCrianca_1")]
        public int IdadeCrianca_1 { get; set; }

        [Column("DataDeNascimento_1")]
        [Display(Name = "DataDeNascimento_1")]
        public DateTime DataDeNascimento_1 { get; set; } // ajustar conforme mês da festa

        [Column("RestricaoAlimentar_1")]
        [Display(Name = "RestricaoAlimentar_1")]
        public string RestricaoAlimentar_1 { get; set; }

        // para opção de adicionar mais crianças:
        [Column("NomeCrianca_2")]
        [Display(Name = "NomeCrianca_2")]
        public string NomeCrianca_2 { get; set; }

        [Column("IdadeCrianca_2")]
        [Display(Name = "IdadeCrianca_2")]
        public int IdadeCrianca_2 { get; set; }

        [Column("DataDeNascimento_2")]
        [Display(Name = "DataDeNascimento_2")]
        public DateTime DataDeNascimento_2 { get; set; } // ajustar conforme mês da festa

        [Column("RestricaoAlimentar_2")]
        [Display(Name = "RestricaoAlimentar_2")]
        public string RestricaoAlimentar_2 { get; set; }

        [Column("NomeCrianca_3")]
        [Display(Name = "NomeCrianca_3")]
        public string NomeCrianca_3 { get; set; }

        [Column("IdadeCrianca_3")]
        [Display(Name = "IdadeCrianca_3")]
        public int IdadeCrianca_3 { get; set; }

        [Column("DataDeNascimento_3")]
        [Display(Name = "DataDeNascimento_3")]
        public DateTime DataDeNascimento_3 { get; set; } // ajustar conforme mês da festa

        [Column("RestricaoAlimentar_3")]
        [Display(Name = "RestricaoAlimentar_3")]
        public string RestricaoAlimentar_3 { get; set; }

        [Column("NomeCrianca_4")]
        [Display(Name = "NomeCrianca_4")]
        public string NomeCrianca_4 { get; set; }

        [Column("IdadeCrianca_4")]
        [Display(Name = "IdadeCrianca_4")]
        public int IdadeCrianca_4 { get; set; }

        [Column("DataDeNascimento_4")]
        [Display(Name = "DataDeNascimento_4")]
        public DateTime DataDeNascimento_4 { get; set; } // ajustar conforme mês da festa

        [Column("RestricaoAlimentar_4")]
        [Display(Name = "RestricaoAlimentar_4")]
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
