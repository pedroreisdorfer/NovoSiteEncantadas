using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebEncantadas.Controllers
{
    public class Quem_SomosController : Controller
    {

        public IActionResult Quem_Somos()
        {
            return View();
        }

     
    }
}
