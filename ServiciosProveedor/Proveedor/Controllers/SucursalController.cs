using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proveedor.Models.Sucursal;
using Proveedor.ViewModels.Sucursal;
namespace Proveedor.Controllers
{
    public class SucursalController : Controller
    {
        // GET: Sucursal
        public ActionResult ListaSucursal(string c)
        {
            ViewBag.c = c;
            GestionSucursal g = new GestionSucursal();
            ViewBag.listaSucursal = g.ListarSucursalC(c);
            return View();
        }

        public ActionResult Lista(string c)
        {
            ViewBag.c = c;
            GestionSucursal g = new GestionSucursal();
            ViewBag.listaSucursal = g.ListarSucursalC(c);
            return View();
        }

        [HttpGet]
        public ActionResult AgregarSucursal()
        {
            GestionSucursal g = new GestionSucursal();
            ViewBag.listaComunas = g.ListarComunas();
            ViewBag.c = Request.Params["c"];
            return View("AgregarSucursal");
        }

        [HttpPost]
        public ActionResult AgregarSucursal(SucursalVM pro)
        {
            GestionSucursal g = new GestionSucursal();
           
            g.AgregarSucursal(pro.Sucursal);
            return RedirectToAction("ListaSucursal","Sucursal",new { c=pro.Sucursal.Proveedor});
        }


        public ActionResult EliminarSucursal(string rut)
        {
            GestionSucursal g = new GestionSucursal();
            decimal p = g.BuscarSucursal(rut).Proveedor;
            g.EliminarSucursal(g.BuscarSucursal(rut));
            return RedirectToAction("Lista", "Sucursal", new { c = p });
        }

        [HttpGet]
        public ActionResult EditarSucursal(string rut)
        {
            GestionSucursal g = new GestionSucursal();
            SucursalVM p = new SucursalVM();
            ViewBag.listaComunas = g.ListarComunas();
            ViewBag.c = Request.Params["c"];
            p.Sucursal = g.BuscarSucursal(rut);
            return View("EditarSucursal", p);
        }

        [HttpPost]
        public ActionResult EditarSucursal(SucursalVM pro)
        {
            GestionSucursal g = new GestionSucursal();
            g.EditarSucursal(pro.Sucursal);
            return RedirectToAction("ListaSucursal", "Sucursal", new { c = pro.Sucursal.Proveedor });
        }

        [HttpGet]
        public ActionResult Editar(string rut)
        {
            GestionSucursal g = new GestionSucursal();
            SucursalVM p = new SucursalVM();
            ViewBag.listaComunas = g.ListarComunas();
            ViewBag.c = Request.Params["c"];
            p.Sucursal = g.BuscarSucursal(rut);
            return View("Editar", p);
        }

        [HttpPost]
        public ActionResult Editar(SucursalVM pro)
        {
            GestionSucursal g = new GestionSucursal();
            g.EditarSucursal(pro.Sucursal);
            return RedirectToAction("Lista", "Sucursal", new { c = pro.Sucursal.Proveedor });
        }
    }
}