using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebEncantadas.Models.Entities;

namespace WebEncantadas.Models.ViewModels
{

    public class CadastroViewModel 
    {
        //Cadastro responsável

        [Key]
        [Display(Name = "id")]
        public int id { get; set; }

    
        [Display(Name = "NomeResponsavel")]
        public string NomeResponsavel { get; set; }

        [Display(Name = "CPF")]
        public string CPF { get; set; } // ver se não precisará mudar nada no banco

     
        [Display(Name = "Email")]
        public string Email { get; set; }

     
        [Display(Name = "ConfirmacaoEmail")]
        public string ConfirmacaoEmail { get; set; }

      
        [Display(Name = "Contato")]
        public string Contato { get; set; }

    
        [Display(Name = "ContatoEmergencial")]
        public string ContatoEmergencial { get; set; }

        // Cadastro crianças

       
        [Display(Name = "NomeCrianca_1")]
        public string NomeCrianca_1 { get; set; }


        [Display(Name = "IdadeCrianca_1")]
        public int IdadeCrianca_1 { get; set; }

    
        [Display(Name = "DataDeNascimento_1")]
        public DateTime DataDeNascimento_1 { get; set; } // ajustar conforme mês da festa

        [Display(Name = "RestricaoAlimentar_1")]
        public string RestricaoAlimentar_1 { get; set; }

        // para opção de adicionar mais crianças:
     
        [Display(Name = "NomeCrianca_2")]
        public string NomeCrianca_2 { get; set; }


        [Display(Name = "IdadeCrianca_2")]
        public int IdadeCrianca_2 { get; set; }


        [Display(Name = "DataDeNascimento_2")]
        public DateTime DataDeNascimento_2 { get; set; } // ajustar conforme mês da festa

        [Display(Name = "RestricaoAlimentar_2")]
        public string RestricaoAlimentar_2 { get; set; }

        [Display(Name = "NomeCrianca_3")]
        public string NomeCrianca_3 { get; set; }

  
        [Display(Name = "IdadeCrianca_3")]
        public int IdadeCrianca_3 { get; set; }

   
        [Display(Name = "DataDeNascimento_3")]
        public DateTime DataDeNascimento_3 { get; set; } // ajustar conforme mês da festa

    
        [Display(Name = "RestricaoAlimentar_3")]
        public string RestricaoAlimentar_3 { get; set; }

   
        [Display(Name = "NomeCrianca_4")]
        public string NomeCrianca_4 { get; set; }


        [Display(Name = "IdadeCrianca_4")]
        public int IdadeCrianca_4 { get; set; }

        [Display(Name = "DataDeNascimento_4")]
        public DateTime DataDeNascimento_4 { get; set; } // ajustar conforme mês da festa

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
