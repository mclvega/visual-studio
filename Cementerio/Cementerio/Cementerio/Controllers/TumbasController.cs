using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cementerio.Models.Tumbas;
using Cementerio.ViewModels.Tumbas;

namespace Cementerio.Controllers
{
    public class TumbasController : Controller
    {
        // GET: Tumbas
        public ActionResult ListarTumbas()
        {
            GestionTumbas g = new GestionTumbas();
            ViewBag.lista = g.ListarTumbas();
            return View();
        }
        [HttpGet]
        public ActionResult AgregarTumba()
        {
            GestionTumbas g = new GestionTumbas();
            ViewBag.listaTipo = g.ListarTipoTumbas();
            ViewBag.listaMaterial = g.ListarMateriales();
            return View("AgregarTumba");
        }

        [HttpPost]
        public ActionResult AgregarTumba(TumbaVM pro)
        {
            GestionTumbas g = new GestionTumbas();
            g.AgregarTumbas(pro.Tumba);
            return RedirectToAction("AgregarFactura", "Facturas", new { t = pro.Tumba.fallecido_rut});

        }
    }
}