using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Proveedor.Models.Proveedor;
using Proveedor.ViewModels.Proveedor;
namespace Proveedor.Controllers
{
    
    public class ProveedorController : Controller
    {
        // GET: Proveedor
        public ActionResult ListaProveedor(string c)
        {
           
                GestionProveedor g = new GestionProveedor();
                ViewBag.listaProveedor = g.ListarProveedorC(c);
                return View();
            
        }
        public ActionResult Lista()
        {
            GestionProveedor g = new GestionProveedor();

            ViewBag.listaProveedor = g.ListarProveedor();
            return View();
        }

        public ActionResult Logout()
        {
            
            return RedirectToAction("Login","Home");
        }

        [HttpGet]
        public ActionResult AgregarProveedor()
        {
            
            return View("AgregarProveedor");
        }

        [HttpPost]
        public ActionResult AgregarProveedor(ProveedorVM pro)
        {
            GestionProveedor g = new GestionProveedor();
            g.AgregarProveedor(pro.Proveedor);
            return RedirectToAction("Lista");
        }

        
        public ActionResult EliminarProveedor(string rut)
        {
            GestionProveedor g = new GestionProveedor();
            g.EliminarProveedor(g.BuscarProveedor(rut));
            return RedirectToAction("Lista");
        }

        [HttpGet]
        public ActionResult EditarProveedor(string rut)
        {
            GestionProveedor g = new GestionProveedor();
            ProveedorVM p = new ProveedorVM();
            p.Proveedor = g.BuscarProveedor(rut);
            return View("EditarProveedor",p);
        }

        [HttpPost]
        public ActionResult EditarProveedor(ProveedorVM pro)
        {
            GestionProveedor g = new GestionProveedor();
            
            g.EditarProveedor(pro.Proveedor);
            return RedirectToAction("ListaProveedor","Proveedor",new { C=pro.Proveedor.Codigo});
        }

        [HttpGet]
        public ActionResult Editar(string rut)
        {
            GestionProveedor g = new GestionProveedor();
            ProveedorVM p = new ProveedorVM();
            p.Proveedor = g.BuscarProveedor(rut);
            return View("Editar", p);
        }

        [HttpPost]
        public ActionResult Editar(ProveedorVM pro)
        {
            GestionProveedor g = new GestionProveedor();
            g.EditarProveedor(pro.Proveedor);
            return RedirectToAction("Lista");
        }
    }
}