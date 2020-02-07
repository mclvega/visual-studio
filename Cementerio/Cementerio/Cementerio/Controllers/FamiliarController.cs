using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cementerio.Models.Personas;
using Cementerio.ViewModels.Personas;
namespace Cementerio.Controllers
{
    public class FamiliarController : Controller
    {
        // GET: Familiar
        public ActionResult ListarFamiliares()
        {
            GestionFamiliar g = new GestionFamiliar();
            ViewBag.lista = g.ListarFamiliares();
            return View();
        }

        [HttpGet]
        public ActionResult AgregarFamiliar()
        {
            GestionFamiliar g = new GestionFamiliar();

            return View("AgregarFamiliar");
        }

        [HttpPost]
        public ActionResult AgregarFamiliar(FamiliarVM f)
        {
            GestionFamiliar g = new GestionFamiliar();

            g.AgregarFamiliares(f.Familiar);
            return RedirectToAction("ListarFamiliares");
        }

        public ActionResult EliminarFamiliar(string rut)
        {
            GestionFamiliar g = new GestionFamiliar();
            g.EliminarFamiliares(g.BuscarFamiliares(rut));
            g.EliminarPersonas(g.BuscarPersonas(rut));
            return RedirectToAction("ListarFamiliares");
        }

        [HttpGet]
        public ActionResult EditarFamiliar(string c)
        {
            GestionFamiliar g = new GestionFamiliar();
            FamiliarVM p = new FamiliarVM();

            p.Familiar = g.BuscarFamiliares(c);
            return View("EditarFamiliar", p);
        }

        [HttpPost]
        public ActionResult EditarFamiliar(FamiliarVM f)
        {
            GestionFamiliar g = new GestionFamiliar();
            g.EditarFamiliares(f.Familiar);
            return RedirectToAction("ListarFamiliares", "Familiar"/*, new { c = pro.Alimento.Sucursal, pro = pro.Alimento.ProveedorC }*/);
        }
    }
}