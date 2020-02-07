using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proveedor.Models.Banco;
using Proveedor.ViewModels.Banco;

namespace Proveedor.Controllers
{
    public class BancoController : Controller
    {
        // GET: Banco
        public ActionResult ListaBancos()
        {
            GestionBanco g = new GestionBanco();
            ViewBag.listaBancos = g.ListarBancos();
            return View();
        }

        [HttpGet]
        public ActionResult AgregarBanco()
        {
            GestionBanco g = new GestionBanco();

            return View("AgregarBanco");
        }

        [HttpPost]
        public ActionResult AgregarBanco(BancoVM pro)
        {
            GestionBanco g = new GestionBanco();

            g.AgregarBancos(pro.Banco);
            return RedirectToAction("ListaBancos");
        }

        public ActionResult EliminarBancos(string codigo)
        {
            GestionBanco g = new GestionBanco();
            g.EliminarBancos(g.BuscarBanco(codigo));
            return RedirectToAction("ListaBancos");
        }
    }
}