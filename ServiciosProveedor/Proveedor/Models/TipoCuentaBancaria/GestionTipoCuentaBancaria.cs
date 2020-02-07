﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.IO;
using System.Text;
using Proveedor.Models.TipoCuentaBancaria;
using System.Runtime.Serialization.Json;
using System.Net;
namespace Proveedor.Models.TipoCuentaBancaria
{
    public class GestionTipoCuentaBancaria
    {
        private string url = "http://proveedores.somee.com/ServiciosProveedor.svc/";




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





        public TipoCuentaBancariaClase BuscarTipoCuentaBancaria(string codigo)
        {

            try
            {
                var webClient = new WebClient();
                string ur = string.Format(url + "BuscarTipoCuentaBancaria/{0}", codigo);
                var json = webClient.DownloadData(ur);
                var htmlCode = Encoding.UTF8.GetString(json);
                var js = new JavaScriptSerializer();
                return js.Deserialize<TipoCuentaBancariaClase>(htmlCode);
            }
            catch
            {
                return null;
            }
        }

        public bool AgregarTipoCuentaBancaria(TipoCuentaBancariaClase ali)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(TipoCuentaBancariaClase));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, ali);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "AgregarTipoCuentaBancaria", "POST", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditarTipoCuentaBancaria(TipoCuentaBancariaClase ali)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(TipoCuentaBancariaClase));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, ali);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                var webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "EditarTipoCuentaBancaria", "PUT", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarTipoCuentaBancaria(TipoCuentaBancariaClase ali)
        {

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(TipoCuentaBancariaClase));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, ali);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                var webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.UploadString(url + "EliminarTipoCuentaBancaria", "DELETE", data);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}