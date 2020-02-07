using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cementerio.Models.Personas;
using Cementerio.ViewModels.Personas;
namespace Cementerio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string user, string pass)
        {
            try
            {
                GestionEmpleado g = new GestionEmpleado();
                EmpleadoVM p = new EmpleadoVM();

                if ((p.Empleado = g.Login(user, pass)) != null)
                {
                    return RedirectToAction("Index", "Home");
               //     return RedirectToAction("ListaProveedor", "Proveedor", new { C = p.Proveedor.Codigo });
                }
               /* else if (user.Equals("adm") && pass.Equals("adm"))
                {

                    return RedirectToAction("Home", "Home");

                }*/
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