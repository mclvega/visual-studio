using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
namespace Cementerio.Models.Facturas
{
    public class GestionFacturas
    {



        private string url = "http://mbb.somee.com/Servicios.svc/";

       
        public List<Factura> ListarFacturas()
        {

            try
            {
                var webClient = new WebClient();
                var json = webClient.DownloadData(url + "ListarFacturas");
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<Factura>>(htmlCode);
            }
            catch
            {
                return null;
            }
        }

        public List<Sectores.Sector> ListarSectores()
        {

            try
            {
                var webClient = new WebClient();
                var json = webClient.DownloadData(url + "ListarSectores");
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<Sectores.Sector>>(htmlCode);
            }
            catch
            {
                return null;
            }
        }

        public Factura BuscarFacturas(string rut)
        {

            try
            {
                var webClient = new WebClient();
                string ur = string.Format(url + "BuscarFacturas/{0}", rut);
                var json = webClient.DownloadData(ur);
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<Factura>(htmlCode);
            }
            catch
            {
                return null;
            }
        }
       

        public bool AgregarFacturas(Factura x)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Factura));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, x);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "AgregarFacturas", "POST", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditarFacturas(Factura x)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Factura));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, x);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                var webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "EditarFacturas", "PUT", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarFacturas(Factura x)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Factura));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, x);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                var webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "EliminarFacturas", "DELETE", data);
                return true;
            }
            catch
            {
                return false;
            }
        }
       
    }
}