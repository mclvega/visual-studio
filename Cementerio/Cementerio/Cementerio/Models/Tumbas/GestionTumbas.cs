using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace Cementerio.Models.Tumbas
{
    public class GestionTumbas
    {

        private string url = "http://mbb.somee.com/Servicios.svc/";


        public List<Tumba> ListarTumbas()
        {

            try
            {
                var webClient = new WebClient();
                var json = webClient.DownloadData(url + "ListarTumbas");
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<Tumba>>(htmlCode);
            }
            catch
            {
                return null;
            }
        }

        public List<TipoTumba> ListarTipoTumbas()
        {

            try
            {
                var webClient = new WebClient();
                var json = webClient.DownloadData(url + "ListarTipoTumbas");
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<TipoTumba>>(htmlCode);
            }
            catch
            {
                return null;
            }
        }

        public List<Materiales.Material> ListarMateriales()
        {

            try
            {
                var webClient = new WebClient();
                var json = webClient.DownloadData(url + "ListarMateriales");
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<Materiales.Material>>(htmlCode);
            }
            catch
            {
                return null;
            }
        }

        public Tumba BuscarTumbas(string rut)
        {

            try
            {
                var webClient = new WebClient();
                string ur = string.Format(url + "BuscarTumbas/{0}", rut);
                var json = webClient.DownloadData(ur);
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<Tumba>(htmlCode);
            }
            catch
            {
                return null;
            }
        }


        public bool AgregarTumbas(Tumba x)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Tumba));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, x);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "AgregarTumbas", "POST", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditarTumbas(Tumba x)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Tumba));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, x);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                var webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "EditarTumbas", "PUT", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarTumbas(Tumba x)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Tumba));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, x);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                var webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "EliminarTumbas", "DELETE", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}