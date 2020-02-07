using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.IO;
using System.Text;
using Proveedor.Models.Sucursal;
using System.Runtime.Serialization.Json;
using System.Net;

namespace Proveedor.Models.Proveedor
{
    public class GestionProveedor
    {

        private string url = "http://proveedores.somee.com/ServiciosProveedor.svc/";


        public ProveedorClase Login(string user,string pass)
        {

            try
            {
                var webClient = new WebClient();
                string ur = string.Format(url + "Login/{0},{1}",user,pass);
                var json = webClient.DownloadData(ur);
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<ProveedorClase>(htmlCode);
            }
            catch
            {
                return null;
            }
        }

        public List<ProveedorClase> ListarProveedor()
        {

            try
            {
                var webClient = new WebClient();
                var json = webClient.DownloadData(url + "ListarProveedor");
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<ProveedorClase>>(htmlCode);
            }
            catch
            {
                return null;
            }
        }

        public List<ProveedorClase> ListarProveedorC(string c)
        {

            try
            {
                var webClient = new WebClient();
                string ur = string.Format(url + "ListarProveedorC/{0}", c);
                var json = webClient.DownloadData(ur);
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<ProveedorClase>>(htmlCode);
            }
            catch
            {
                return null;
            }
        }




        public ProveedorClase BuscarProveedor(string rut)
        {

            try
            {
                var webClient = new WebClient();
                string ur = string.Format(url + "BuscarProveedor/{0}", rut);
                var json = webClient.DownloadData(ur);
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<ProveedorClase>(htmlCode);
            }
            catch
            {
                return null;
            }
        }

        public bool AgregarProveedor(ProveedorClase ali)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(ProveedorClase));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, ali);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "AgregarProveedor", "POST", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditarProveedor(ProveedorClase ali)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(ProveedorClase));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, ali);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                var webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "EditarProveedor", "PUT", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarProveedor(ProveedorClase ali)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(ProveedorClase));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, ali);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                var webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "EliminarProveedor", "DELETE", data);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}