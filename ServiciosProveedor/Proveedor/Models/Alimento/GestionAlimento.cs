using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.IO;
using System.Text;
using Proveedor.Models.Sucursal;
using Proveedor.Models.CategoriaAlimento;
using Proveedor.Models.TipoAlimento;
using System.Runtime.Serialization.Json;

namespace Proveedor.Models.Alimento
{
    public class GestionAlimento
    {
        private string url = "http://proveedores.somee.com/ServiciosProveedor.svc/";

        public List<AlimentoClase> ListarAlimentos()
        {

            try
            {
                var webClient = new WebClient();
                var json = webClient.DownloadData(url + "ListarAlimentos");
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<AlimentoClase>>(htmlCode);
            }
            catch
            {
                return null;
            }
        }


        public List<AlimentoClase> ListarAlimentosC(string c)
        {

            try
            {
                var webClient = new WebClient();
                string ur = string.Format(url + "ListarAlimentosC/{0}", c);
                var json = webClient.DownloadData(ur);
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<AlimentoClase>>(htmlCode);
            }
            catch
            {
                return null;
            }
        }

       
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

         public AlimentoClase BuscarAlimentos(string codigo)
         {

             try
             {
                 var webClient = new WebClient();
                 string ur = string.Format(url + "BuscarAlimentos/{0}", codigo);
                 var json = webClient.DownloadData(ur);
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                 return js.Deserialize<AlimentoClase>(htmlCode);
             }
             catch
             {
                 return null;
             }
         }
 
        public bool AgregarAlimentos(AlimentoClase ali)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(AlimentoClase));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, ali);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "AgregarAlimentos", "POST", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

         public bool EditarAlimentos(AlimentoClase ali)
         {

             try
             {
                 DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(AlimentoClase));
                 MemoryStream mem = new MemoryStream();
                 ser.WriteObject(mem, ali);
                 string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                 var webClient = new WebClient();
                 webClient.Headers["Content-type"] = "application/json";
                 webClient.Encoding = Encoding.UTF8;
                 webClient.UploadString(url + "EditarAlimentos", "PUT", data);
                 return true;
             }
             catch
             {
                 return false;
             }
         }

         public bool EliminarAlimentos(AlimentoClase ali)
         {

             try
             {
                 DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(AlimentoClase));
                 MemoryStream mem = new MemoryStream();
                 ser.WriteObject(mem, ali);
                 string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                 var webClient = new WebClient();
                 webClient.Headers["Content-type"] = "application/json";
                 webClient.Encoding = Encoding.UTF8;
                 webClient.UploadString(url + "EliminarAlimentos", "DELETE", data);
                 return true;
             }
             catch
             {
                 return false;
             }
         }
         
    }
}