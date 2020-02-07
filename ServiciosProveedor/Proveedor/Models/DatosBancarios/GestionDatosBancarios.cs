using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.IO;
using System.Text;
using Proveedor.Models.DatosBancarios;
using Proveedor.Models.Comuna;
using Proveedor.Models.Banco;
using Proveedor.Models.TipoCuentaBancaria;
using System.Runtime.Serialization.Json;
using System.Net;
namespace Proveedor.Models.DatosBancarios
{
    public class GestionDatosBancarios
    {

        private string url = "http://proveedores.somee.com/ServiciosProveedor.svc/";




        public List<DatosBancariosClase> ListarDatosBancarios()
        {

            try
            {
                var webClient = new WebClient();
                var json = webClient.DownloadData(url + "ListarDatosBancarios");
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<DatosBancariosClase>>(htmlCode);
            }
            catch
            {
                return null;
            }
        }
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
        public List<TipoCuentaBancariaClase> ListarTipoCuentaBancaria()
        {

            try
            {
                var webClient = new WebClient();
                var json = webClient.DownloadData(url + "ListarTipoCuentas");
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<TipoCuentaBancariaClase>>(htmlCode);
            }
            catch
            {
                return null;
            }
        }



        public List<DatosBancariosClase> ListarDatosBancariosC(string c)
        {

            try
            {
                var webClient = new WebClient();
                string ur = string.Format(url + "ListarDatosBancariosC/{0}", c);
                var json = webClient.DownloadData(ur);
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<DatosBancariosClase>>(htmlCode);
            }
            catch
            {
                return null;
            }
        }




        public DatosBancariosClase BuscarDatosBancarios(string rut)
        {

            try
            {
                var webClient = new WebClient();
                string ur = string.Format(url + "BuscarDatosBancarios/{0}", rut);
                var json = webClient.DownloadData(ur);
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<DatosBancariosClase>(htmlCode);
            }
            catch
            {
                return null;
            }
        }

        public bool AgregarDatosBancarios(DatosBancariosClase ali)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(DatosBancariosClase));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, ali);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "AgregarDatosBancarios", "POST", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditarDatosBancarios(DatosBancariosClase ali)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(DatosBancariosClase));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, ali);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                var webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "EditarDatosBancarios", "PUT", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarDatosBancarios(DatosBancariosClase ali)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(DatosBancariosClase));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, ali);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                var webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "EliminarDatosBancarios", "DELETE", data);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}