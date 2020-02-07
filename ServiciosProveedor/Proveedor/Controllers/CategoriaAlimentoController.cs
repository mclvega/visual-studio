using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proveedor.Models.CategoriaAlimento;
using Proveedor.ViewModels.CategoriaAlimento;
namespace Proveedor.Controllers
{
    public class CategoriaAlimentoController : Controller
    {
        // GET: CategoriaAlimento
        public ActionResult ListaCategorias()
        {
            GestionCategoriaAlimento g = new GestionCategoriaAlimento();
            ViewBag.listaCategorias = g.ListarCategoriaAlimentos();
            return View();
        }

        [HttpGet]
        public ActionResult AgregarCategoria()
        {
            GestionCategoriaAlimento g = new GestionCategoriaAlimento();

            return View("AgregarCategoria");
        }

        [HttpPost]
        public ActionResult AgregarCategoria(CategoriaAlimentoVM pro)
        {
            GestionCategoriaAlimento g = new GestionCategoriaAlimento();

            g.AgregarCategoriaAlimentos(pro.CategoriaAlimento);
            return RedirectToAction("ListaCategorias");
        }

        public ActionResult EliminarCategoria(string codigo)
        {
            GestionCategoriaAlimento g = new GestionCategoriaAlimento();
            g.EliminarCategoriaAlimentos(g.BuscarCategoriaAlimento(codigo));
            return RedirectToAction("ListaCategorias");
        }
    }
}