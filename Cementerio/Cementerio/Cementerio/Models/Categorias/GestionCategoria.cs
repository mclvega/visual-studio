using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace Cementerio.Models.Categorias
{
    public class GestionCategoria
    {
       private string url = "http://mbb.somee.com/Servicios.svc/";

        public List<Categorias> ListarCategorias()
        {

            try
            {
                var webClient = new WebClient();
                var json = webClient.DownloadData(url + "ListarCategorias");
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<Categorias>>(htmlCode);
            }
            catch
            {
                return null;
            }
        }
        
        public Categorias BuscarCategorias(string nombre)
        {

            try
            {
                var webClient = new WebClient();
                string ur = string.Format(url + "BuscarCategorias/{0}", nombre);
                var json = webClient.DownloadData(ur);
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<Categorias>(htmlCode);
            }
            catch
            {
                return null;
            }
        }

        public bool AgregarCategorias(Categorias x)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Categorias));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, x);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "AgregarCategorias", "POST", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditarCategorias(Categorias x)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Categorias));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, x);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                var webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "EditarCategorias", "PUT", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarCategorias(Categorias x)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Categorias));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, x);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                var webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "EliminarCategorias", "DELETE", data);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}