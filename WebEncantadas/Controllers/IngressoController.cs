using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEncantadas.Business.ServiceReserva.Abstracts;
using WebEncantadas.Data;
using WebEncantadas.Data.ReservaIngresso.Abstractions;
using WebEncantadas.Helper;
using WebEncantadas.Models.Contracts.Services;
using WebEncantadas.Models.Entities;

namespace WebEncantadas.Controllers
{
    public class IngressoController : Controller
    {
        // GET: IngressoController
        private readonly IReservaService _reservaService;

        public IngressoController(IReservaService reservaService)
        {
            _reservaService = reservaService;
        }

        public async Task<IActionResult> Reserve()
        {
            Mesas mesas = await _reservaService.BuscarEconstruirMesas();

            return View(mesas);
        }

        //// GET: IngressoController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: IngressoController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: IngressoController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: IngressoController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: IngressoController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: IngressoController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: IngressoController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
