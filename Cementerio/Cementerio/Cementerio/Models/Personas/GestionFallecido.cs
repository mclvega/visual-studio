using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace Cementerio.Models.Personas
{
    public class GestionFallecido
    {

        private string url = "http://mbb.somee.com/Servicios.svc/";

        public List<Fallecido> ListarFallecidos()
        {

            try
            {
                var webClient = new WebClient();
                var json = webClient.DownloadData(url + "ListarFallecidos");
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<Fallecido>>(htmlCode);
            }
            catch
            {
                return null;
            }
        }

        public Fallecido BuscarFallecidos(string rut)
        {

            try
            {
                var webClient = new WebClient();
                string ur = string.Format(url + "BuscarFallecidos/{0}", rut);
                var json = webClient.DownloadData(ur);
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<Fallecido>(htmlCode);
            }
            catch
            {
                return null;
            }
        }
        public Persona BuscarPersonas(string rut)
        {

            try
            {
                var webClient = new WebClient();
                string ur = string.Format(url + "BuscarPersonas/{0}", rut);
                var json = webClient.DownloadData(ur);
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<Persona>(htmlCode);
            }
            catch
            {
                return null;
            }
        }

        public bool AgregarFallecidos(Fallecido x)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Fallecido));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, x);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "AgregarFallecidos", "POST", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditarFallecidos(Fallecido x)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Fallecido));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, x);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                var webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "EditarFallecidos", "PUT", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarFallecidos(Fallecido x)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Fallecido));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, x);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                var webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "EliminarFallecidos", "DELETE", data);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool EliminarPersonas(Persona x)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Persona));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, x);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                var webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "EliminarPersonas", "DELETE", data);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}