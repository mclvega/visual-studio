using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.IO;
using System.Text;
using Proveedor.Models.Banco;
using System.Runtime.Serialization.Json;
using System.Net;
namespace Proveedor.Models.Banco
{
    public class GestionBanco
    {
        private string url = "http://proveedores.somee.com/ServiciosProveedor.svc/";




        public List<BancoClase> ListarBancos()
        {

            try
            {
                var webClient = new WebClient();
                var json = webClient.DownloadData(url + "ListarBancos");
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<BancoClase>>(htmlCode);
            }
            catch
            {
                return null;
            }
        }





        public BancoClase BuscarBanco(string codigo)
        {

            try
            {
                var webClient = new WebClient();
                string ur = string.Format(url + "BuscarBancos/{0}", codigo);
                var json = webClient.DownloadData(ur);
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<BancoClase>(htmlCode);
            }
            catch
            {
                return null;
            }
        }

        public bool AgregarBancos(BancoClase ali)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(BancoClase));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, ali);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "AgregarBancos", "POST", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditarBancos(BancoClase ali)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(BancoClase));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, ali);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                var webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "EditarBancos", "PUT", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarBancos(BancoClase ali)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(BancoClase));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, ali);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                var webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "EliminarBancos", "DELETE", data);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}