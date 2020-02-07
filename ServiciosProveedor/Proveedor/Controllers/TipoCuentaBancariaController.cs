using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proveedor.Models.TipoCuentaBancaria;
using Proveedor.ViewModels.TipoCuentaBancaria;
namespace Proveedor.Controllers
{
    public class TipoCuentaBancariaController : Controller
    {
        // GET: TipoCuentaBancaria
        public ActionResult ListaTipoCuentas()
        {
            GestionTipoCuentaBancaria g = new GestionTipoCuentaBancaria();
            ViewBag.listaTipoCuentaBancaria = g.ListarTipoCuentaBancaria();
            return View();
        }

        [HttpGet]
        public ActionResult AgregarTipoCuentaBancarias()
        {
            GestionTipoCuentaBancaria g = new GestionTipoCuentaBancaria();

            return View("AgregarTipoCuentaBancarias");
        }

        [HttpPost]
        public ActionResult AgregarTipoCuentaBancarias(TipoCuentaBancariaVM pro)
        {
            GestionTipoCuentaBancaria g = new GestionTipoCuentaBancaria();

            g.AgregarTipoCuentaBancaria(pro.TipoCuentaBancaria);
            return RedirectToAction("ListaTipoCuentas");
        }

        public ActionResult EliminarTipoCuentaBancarias(string codigo)
        {
            GestionTipoCuentaBancaria g = new GestionTipoCuentaBancaria();
            g.EliminarTipoCuentaBancaria(g.BuscarTipoCuentaBancaria(codigo));
            return RedirectToAction("ListaTipoCuentas");
        }
    }
}