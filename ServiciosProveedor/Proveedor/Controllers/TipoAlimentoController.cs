using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proveedor.Models.TipoAlimento;
using Proveedor.ViewModels.TipoAlimento;
namespace Proveedor.Controllers
{
    public class TipoAlimentoController : Controller
    {
        // GET: TipoAlimento
        public ActionResult ListaTipoAlimentos()
        {
            GestionTipoAlimento g = new GestionTipoAlimento();
            ViewBag.listaTipoAlimentos = g.ListarTipoAlimentos();
            return View();
        }

        [HttpGet]
        public ActionResult AgregarTipoAlimentos()
        {
            GestionTipoAlimento g = new GestionTipoAlimento();
            
            return View("AgregarTipoAlimentos");
        }

        [HttpPost]
        public ActionResult AgregarTipoAlimentos(TipoAlimentoVM pro)
        {
            GestionTipoAlimento g = new GestionTipoAlimento();

            g.AgregarTipoAlimentos(pro.TipoAlimento);
            return RedirectToAction("ListaTipoAlimentos");
        }

        public ActionResult EliminarTipoAlimentos(string codigo)
        {
            GestionTipoAlimento g = new GestionTipoAlimento();
            g.EliminarTipoAlimentos(g.BuscarTipoAlimento(codigo));
            return RedirectToAction("ListaTipoAlimentos");
        }
    }
}