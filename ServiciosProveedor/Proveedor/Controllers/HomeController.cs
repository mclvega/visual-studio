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
    
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            return View();
        }

        
        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(string user,string pass)
        {
            try
            {
                GestionProveedor g = new GestionProveedor();
                ProveedorVM p = new ProveedorVM();
                
                if((p.Proveedor = g.Login(user, pass))!=null){
                    
                    return RedirectToAction("ListaProveedor","Proveedor",new { C=p.Proveedor.Codigo});
                }
                else if (user.Equals("adm")&&pass.Equals("adm"))
                {
                    
                    return RedirectToAction("Home", "Home");

                }
                TempData["msj"] = "Error al ingresar sus credenciales, Reintente nuevamente";
                ViewBag.msj = TempData["msj"];
                
                return View();
            }
            catch (Exception)
            {
                return View();
            }
            
        }


    }
}