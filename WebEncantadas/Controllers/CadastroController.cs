using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEncantadas.Data;
using WebEncantadas.Models.ViewModels;

namespace WebEncantadas.Controllers
{
    public class CadastroController : Controller
    {
        private readonly Contexto _context;

        public CadastroController(Contexto context)
        {
            _context = context;
        }


        public IActionResult Create()
        {
            return View();
        }

        // POST: Produtos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create_([Bind("id, NomeResponsavel,CPF,Email,ConfirmacaoEmail,Contato,ContatoEmergencial,NomeCrianca_1,IdadeCrianca_1,DataDeNascimento_1,RestricaoAlimentar_1,NomeCrianca_2,IdadeCrianca_2,DataDeNascimento_2,RestricaoAlimentar_2,NomeCrianca_3,IdadeCrianca_3,DataDeNascimento_3,RestricaoAlimentar_3,NomeCrianca_4,IdadeCrianca_4,DataDeNascimento_4,RestricaoAlimentar_4, Senha")] CadastroViewModel cadastro)
        {
            // retorno da View precisa ser revisto
            if (ModelState.IsValid)
            {
                _context.Add(cadastro);
                await _context.SaveChangesAsync();

                return RedirectToAction("Login");
            }
            return View(cadastro);
        }
    }
}
