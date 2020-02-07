using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proveedor.Models.DatosBancarios;
using Proveedor.ViewModels.DatosBancarios;
namespace Proveedor.Controllers
{
    public class DatosBancariosController : Controller
    {
        // GET: DatosBancarios
        public ActionResult ListaDatosBancarios(string c)
        {
            ViewBag.pro = Request.Params["pro"];
            GestionDatosBancarios g = new GestionDatosBancarios();
            ViewBag.listaDatosBancarios = g.ListarDatosBancariosC(c);
            return View();
        }
        public ActionResult Lista(string c)
        {
            ViewBag.pro = Request.Params["pro"];
            GestionDatosBancarios g = new GestionDatosBancarios();
            ViewBag.listaDatosBancarios = g.ListarDatosBancariosC(c);
            return View();
        }


        [HttpGet]
        public ActionResult AgregarDatosBancarios()
        {
            GestionDatosBancarios g = new GestionDatosBancarios();
            ViewBag.listaBancos = g.ListarBancos();
            ViewBag.listaTipos = g.ListarTipoCuentaBancaria();
            ViewBag.c = Request.Params["c"];
            ViewBag.pro = Request.Params["p"];
            return View("AgregarDatosBancarios");
        }

        [HttpPost]
        public ActionResult AgregarDatosBancarios(DatosBancariosVM pro)
        {
            GestionDatosBancarios g = new GestionDatosBancarios();

            g.AgregarDatosBancarios(pro.DatosBancarios);
            return RedirectToAction("Lista", "DatosBancarios", new { c = pro.DatosBancarios.Sucursal,pro=pro.DatosBancarios.ProveedorC });
        }


        public ActionResult EliminarDatosBancarios(string codigo)
        {
            GestionDatosBancarios g = new GestionDatosBancarios();
            string pr = Request.Params["p"];
            decimal p = g.BuscarDatosBancarios(codigo).Sucursal;
            g.EliminarDatosBancarios(g.BuscarDatosBancarios(codigo));
            return RedirectToAction("Lista", "DatosBancarios", new { c = p,pro=pr });
        }

    }
}