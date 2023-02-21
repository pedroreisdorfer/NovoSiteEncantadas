using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebEncantadas.Controllers
{
    public class PagamentoController : Controller
    {
        public double valorIngresso { get; set; }



        //[HttpPost]
        //public JsonResult AtualizaPagamento()
        //{
        //    double valorIngresso = 200.00;
        //    return Json(new
        //    {
        //        ValorIngresso = valorIngresso
        //    });
        //}

        public IActionResult Index()
        {
            double valorIngresso = 200.00;
            var valorIngresso_json = JsonConvert.SerializeObject(valorIngresso);
            return Json(valorIngresso_json);
        }

        public IActionResult CalcularValorTotal(int numero_deCadeiras)
        {
            double valorPorCadeira = 200.00;
            double valorToal = numero_deCadeiras * valorPorCadeira;
            var valorToal_json = JsonConvert.SerializeObject(valorToal);  
            return Json(valorToal_json);
        }
    }
}
