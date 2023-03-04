using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebEncantadas.Controllers
{
    public class ChaController : Controller
    {

        public IActionResult Cha()
        {
            return View();
        }

     
    }
}
