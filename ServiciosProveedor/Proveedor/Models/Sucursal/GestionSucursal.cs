using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.IO;
using System.Text;
using Proveedor.Models.Sucursal;
using Proveedor.Models.Comuna;
using System.Runtime.Serialization.Json;
using System.Net;
namespace Proveedor.Models.Sucursal
{
    public class GestionSucursal
    {
        private string url = "http://proveedores.somee.com/ServiciosProveedor.svc/";


       

        public List<SucursalClase> ListarSucursal()
        {

            try
            {
                var webClient = new WebClient();
                var json = webClient.DownloadData(url + "ListarSucursales");
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<SucursalClase>>(htmlCode);
            }
            catch
            {
                return null;
            }
        }
        public List<ComunaClase> ListarComunas()
        {

            try
            {
                var webClient = new WebClient();
                var json = webClient.DownloadData(url + "ListarComunas");
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<ComunaClase>>(htmlCode);
            }
            catch
            {
                return null;
            }
        }

        public List<SucursalClase> ListarSucursalC(string c)
        {

            try
            {
                var webClient = new WebClient();
                string ur = string.Format(url + "ListarSucursalesC/{0}", c);
                var json = webClient.DownloadData(ur);
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<SucursalClase>>(htmlCode);
            }
            catch
            {
                return null;
            }
        }




        public SucursalClase BuscarSucursal(string rut)
        {

            try
            {
                var webClient = new WebClient();
                string ur = string.Format(url + "BuscarSucursal/{0}", rut);
                var json = webClient.DownloadData(ur);
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<SucursalClase>(htmlCode);
            }
            catch
            {
                return null;
            }
        }

        public bool AgregarSucursal(SucursalClase ali)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(SucursalClase));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, ali);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "AgregarSucursal", "POST", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditarSucursal(SucursalClase ali)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(SucursalClase));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, ali);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                var webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "EditarSucursal", "PUT", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarSucursal(SucursalClase ali)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(SucursalClase));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, ali);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                var webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "EliminarSucursal", "DELETE", data);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}