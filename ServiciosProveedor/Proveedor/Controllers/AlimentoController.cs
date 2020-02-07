using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proveedor.Models.Alimento;
using Proveedor.Models.Sucursal;
using Proveedor.ViewModels.Alimento;
namespace Proveedor.Controllers
{
    public class AlimentoController : Controller
    {
        // GET: Alimento
        public ActionResult ListaAlimentos(string c)
        {
            GestionAlimento a = new GestionAlimento();
            ViewBag.listaAlimentos = a.ListarAlimentosC(c);

            ViewBag.pro = Request.Params["pro"];
            return View();
        }
        public ActionResult Lista(string c)
        {
            GestionAlimento a = new GestionAlimento();
            ViewBag.listaAlimentos = a.ListarAlimentosC(c);
            ViewBag.pro = Request.Params["pro"];
            return View();
        }

        [HttpGet]
        public ActionResult AgregarAlimento()
        {
            GestionAlimento a = new GestionAlimento();
            ViewBag.c = Request.Params["c"];
            ViewBag.p = Request.Params["p"];
            ViewBag.listaCategorias = a.ListarCategoriaAlimentos();
            ViewBag.listaTipos = a.ListarTipoAlimentos();
            return View("AgregarAlimento");
        }

        [HttpPost]
        public ActionResult AgregarAlimento(AlimentoVM aliVM)
        {
            GestionAlimento t = new GestionAlimento();
            t.AgregarAlimentos(aliVM.Alimento);
            return RedirectToAction("ListaAlimentos", "Alimento", new { c = aliVM.Alimento.Sucursal ,pro=aliVM.Alimento.ProveedorC});
        }

        [HttpGet]
        public ActionResult Agregar()
        {
            GestionAlimento a = new GestionAlimento();
            ViewBag.c = Request.Params["c"];
            ViewBag.p = Request.Params["p"];
            ViewBag.listaCategorias = a.ListarCategoriaAlimentos();
            ViewBag.listaTipos = a.ListarTipoAlimentos();
            return View("Agregar");
        }

        [HttpPost]
        public ActionResult Agregar(AlimentoVM aliVM)
        {
            GestionAlimento t = new GestionAlimento();
            t.AgregarAlimentos(aliVM.Alimento);
            return RedirectToAction("Lista", "Alimento", new { c = aliVM.Alimento.Sucursal,pro = aliVM.Alimento.ProveedorC });
        }

        public ActionResult EliminarAlimento(string c)
        {
            GestionAlimento g = new GestionAlimento();
            decimal p = g.BuscarAlimentos(c).Sucursal;
            g.EliminarAlimentos(g.BuscarAlimentos(c));
            string pr= Request.Params["pro"];
            return RedirectToAction("ListaAlimentos", "Alimento", new { c = p,pro=pr });
        }

        public ActionResult Eliminar(string c)
        {
            GestionAlimento g = new GestionAlimento();
            decimal p = g.BuscarAlimentos(c).Sucursal;
            g.EliminarAlimentos(g.BuscarAlimentos(c));
            string pr = Request.Params["pro"];
            return RedirectToAction("Lista", "Alimento", new { c = p, pro = pr });
        }

        [HttpGet]
        public ActionResult EditarAlimento(string c)
        {
            GestionAlimento g = new GestionAlimento();
            AlimentoVM p = new AlimentoVM();
            ViewBag.listaCategorias = g.ListarCategoriaAlimentos();
            ViewBag.listaTipos = g.ListarTipoAlimentos();
            ViewBag.p = g.BuscarAlimentos(c).Sucursal;
            p.Alimento = g.BuscarAlimentos(c);
            return View("EditarAlimento", p);
        }

        [HttpPost]
        public ActionResult EditarAlimento(AlimentoVM pro)
        {
            GestionAlimento g = new GestionAlimento();
            g.EditarAlimentos(pro.Alimento);
            return RedirectToAction("ListaAlimentos", "Alimento", new { c = pro.Alimento.Sucursal,pro=pro.Alimento.ProveedorC });
        }

        [HttpGet]
        public ActionResult Editar(string c)
        {
            GestionAlimento g = new GestionAlimento();
            AlimentoVM p = new AlimentoVM();
            ViewBag.listaCategorias = g.ListarCategoriaAlimentos();
            ViewBag.listaTipos = g.ListarTipoAlimentos();
            ViewBag.p = g.BuscarAlimentos(c).Sucursal;
            p.Alimento = g.BuscarAlimentos(c);
            return View("Editar", p);
        }

        [HttpPost]
        public ActionResult Editar(AlimentoVM pro)
        {
            GestionAlimento g = new GestionAlimento();
            g.EditarAlimentos(pro.Alimento);
            return RedirectToAction("Lista", "Alimento", new { c = pro.Alimento.Sucursal, pro = pro.Alimento.ProveedorC });
        }
    }
}