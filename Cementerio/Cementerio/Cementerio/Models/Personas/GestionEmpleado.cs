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
    public class GestionEmpleado
    {

        private string url = "http://www.mbb.somee.com/Servicios.svc/";

        public Empleado Login(string rut, string nombre)
        {

            try
            {
                var webClient = new WebClient();
                string ur = string.Format(url + "Login/{0},{1}", rut, nombre);
                var json = webClient.DownloadData(ur);
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<Empleado>(htmlCode);
            }
            catch
            {
                return null;
            }
        }

        

        public List<Empleado> ListarEmpleados()
        {

            try
            {
                var webClient = new WebClient();
                var json = webClient.DownloadData(url + "ListarEmpleados");
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<Empleado>>(htmlCode);
            }
            catch
            {
                return null;
            }
        }

        public Empleado BuscarEmpleados(string rut)
        {

            try
            {
                var webClient = new WebClient();
                string ur = string.Format(url + "BuscarEmpleados/{0}", rut);
                var json = webClient.DownloadData(ur);
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<Empleado>(htmlCode);
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

        public bool AgregarEmpleados(Empleado x)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Empleado));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, x);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "AgregarEmpleados", "POST", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditarEmpleados(Empleado x)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Empleado));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, x);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                var webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "EditarEmpleados", "PUT", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarEmpleados(Empleado x)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Empleado));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, x);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                var webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "EliminarEmpleados", "DELETE", data);
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