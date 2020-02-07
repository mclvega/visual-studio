using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Cementerio.Models.Personas;
using Cementerio.ViewModels.Personas;
namespace Cementerio.Controllers
{
    public class FallecidosController : Controller
    {
        // GET: Fallecidos
        public ActionResult ListaFallecidos()
        {
            GestionFallecido g = new GestionFallecido();
            ViewBag.lista = g.ListarFallecidos();
            return View();
        }

        [HttpGet]
        public ActionResult AgregarFallecido()
        {
            GestionFallecido g = new GestionFallecido();

            return View("AgregarFallecido");
        }

        [HttpPost]
        public ActionResult AgregarFallecido(FallecidoVM f)
        {
            GestionFallecido g = new GestionFallecido();

            g.AgregarFallecidos(f.Fallecido);
            return RedirectToAction("ListaFallecidos");
        }

        public ActionResult EliminarFallecido(string rut)
        {
            GestionFallecido g = new GestionFallecido();
            g.EliminarFallecidos(g.BuscarFallecidos(rut));
            g.EliminarPersonas(g.BuscarPersonas(rut));
            return RedirectToAction("ListaFallecidos");
        }

        [HttpGet]
        public ActionResult EditarFallecido(string c)
        {
            GestionFallecido g = new GestionFallecido();
            FallecidoVM p = new FallecidoVM();
            
            p.Fallecido = g.BuscarFallecidos(c);
            return View("EditarFallecido", p);
        }

        [HttpPost]
        public ActionResult EditarFallecido(FallecidoVM f)
        {
            GestionFallecido g = new GestionFallecido();
            g.EditarFallecidos(f.Fallecido);
            return RedirectToAction("ListaFallecidos", "Fallecidos"/*, new { c = pro.Alimento.Sucursal, pro = pro.Alimento.ProveedorC }*/);
        }
    }
}