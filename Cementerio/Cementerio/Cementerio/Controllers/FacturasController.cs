using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Cementerio.Models.Facturas;
using Cementerio.ViewModels.Facturas;
namespace Cementerio.Controllers
{
    public class FacturasController : Controller
    {
        // GET: Facturas
        public ActionResult ListarFacturas()
        {
            GestionFacturas g = new GestionFacturas();
            ViewBag.lista = g.ListarFacturas();
            return View();
        }

        [HttpGet]
        public ActionResult AgregarFactura(string t)
        {
            GestionFacturas g = new GestionFacturas();
            
            Models.Tumbas.GestionTumbas gt = new Models.Tumbas.GestionTumbas();
            int to=0;
            if (gt.BuscarTumbas(t.ToString()).tipo_tumba_id==1)
            {
                to = 12500000;
            }
            else if (gt.BuscarTumbas(t.ToString()).tipo_tumba_id == 2)
            {
                to = 25000000;
            }
            else if (gt.BuscarTumbas(t.ToString()).tipo_tumba_id == 3)
            {
                to = 25000;
            }
            ViewBag.total = to;
            ViewBag.fecha = DateTime.Now;
            ViewBag.fallecido=gt.BuscarTumbas(t.ToString()).fallecido_id;
            ViewBag.fallecido_nombre = gt.BuscarTumbas(t.ToString()).fallecido_nombre;
            ViewBag.fallecido_pa = gt.BuscarTumbas(t.ToString()).fallecido_apellidoPaterno;
            ViewBag.fallecido_ma = gt.BuscarTumbas(t.ToString()).fallecido_apellidoMaterno;
            ViewBag.fallecido_edad = gt.BuscarTumbas(t.ToString()).fallecido_edad;
            ViewBag.fallecido_rut = gt.BuscarTumbas(t.ToString()).fallecido_rut;
            ViewBag.tumba = gt.BuscarTumbas(t.ToString()).id;
            ViewBag.listaSector = g.ListarSectores();
            return View("AgregarFactura");
        }
        [HttpPost]
        public ActionResult AgregarFactura(FacturaVM pro)
        {
            GestionFacturas g = new GestionFacturas();
            g.AgregarFacturas(pro.Factura);
            return RedirectToAction("ListarFacturas");

        }
    }
}