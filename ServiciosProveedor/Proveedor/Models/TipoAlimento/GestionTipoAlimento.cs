using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.IO;
using System.Text;
using Proveedor.Models.TipoAlimento;
using System.Runtime.Serialization.Json;
using System.Net;
namespace Proveedor.Models.TipoAlimento
{
    public class GestionTipoAlimento
    {
        private string url = "http://proveedores.somee.com/ServiciosProveedor.svc/";




        public List<TipoAlimentoClase> ListarTipoAlimentos()
        {

            try
            {
                var webClient = new WebClient();
                var json = webClient.DownloadData(url + "ListarTipoAlimentos");
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<TipoAlimentoClase>>(htmlCode);
            }
            catch
            {
                return null;
            }
        }
       




        public TipoAlimentoClase BuscarTipoAlimento(string codigo)
        {

            try
            {
                var webClient = new WebClient();
                string ur = string.Format(url + "BuscarTipoAlimentos/{0}", codigo);
                var json = webClient.DownloadData(ur);
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<TipoAlimentoClase>(htmlCode);
            }
            catch
            {
                return null;
            }
        }

        public bool AgregarTipoAlimentos(TipoAlimentoClase ali)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(TipoAlimentoClase));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, ali);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "AgregarTipoAlimentos", "POST", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditarTipoAlimentos(TipoAlimentoClase ali)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(TipoAlimentoClase));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, ali);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                var webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "EditarTipoAlimentos", "PUT", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarTipoAlimentos(TipoAlimentoClase ali)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(TipoAlimentoClase));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, ali);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                var webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "EliminarTipoAlimentos", "DELETE", data);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}