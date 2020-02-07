using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cementerio.Models.Categorias;
using Cementerio.ViewModels.Categorias;
namespace Cementerio.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult ListaCategorias()
        {
            GestionCategoria g = new GestionCategoria();
            ViewBag.lista = g.ListarCategorias();
            return View();
        }

        [HttpGet]
        public ActionResult AgregarCategoria()
        {
            GestionCategoria g = new GestionCategoria();

            return View("AgregarCategoria");
        }

        [HttpPost]
        public ActionResult AgregarCategoria(CategoriaVM pro)
        {
            GestionCategoria g = new GestionCategoria();

            g.AgregarCategorias(pro.Categoria);
            return RedirectToAction("ListaCategorias");
        }

        public ActionResult EliminarCategoria(string nombre)
        {
            GestionCategoria g = new GestionCategoria();
            g.EliminarCategorias(g.BuscarCategorias(nombre));
            return RedirectToAction("ListaCategorias");
        }
    }
}