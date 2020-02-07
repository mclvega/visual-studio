using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.IO;
using System.Text;
using Proveedor.Models.CategoriaAlimento;
using System.Runtime.Serialization.Json;
using System.Net;
namespace Proveedor.Models.CategoriaAlimento
{
    public class GestionCategoriaAlimento
    {
        private string url = "http://proveedores.somee.com/ServiciosProveedor.svc/";




        public List<CategoriaAlimentoClase> ListarCategoriaAlimentos()
        {

            try
            {
                var webClient = new WebClient();
                var json = webClient.DownloadData(url + "ListarCategoriaAlimentos");
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<CategoriaAlimentoClase>>(htmlCode);
            }
            catch
            {
                return null;
            }
        }





        public CategoriaAlimentoClase BuscarCategoriaAlimento(string codigo)
        {

            try
            {
                var webClient = new WebClient();
                string ur = string.Format(url + "BuscarCategoriaAlimentos/{0}", codigo);
                var json = webClient.DownloadData(ur);
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<CategoriaAlimentoClase>(htmlCode);
            }
            catch
            {
                return null;
            }
        }

        public bool AgregarCategoriaAlimentos(CategoriaAlimentoClase ali)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(CategoriaAlimentoClase));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, ali);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "AgregarCategoriaAlimentos", "POST", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditarCategoriaAlimentos(CategoriaAlimentoClase ali)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(CategoriaAlimentoClase));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, ali);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                var webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "EditarCategoriaAlimentos", "PUT", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarCategoriaAlimentos(CategoriaAlimentoClase ali)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(CategoriaAlimentoClase));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, ali);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                var webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "EliminarCategoriaAlimentos", "DELETE", data);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}