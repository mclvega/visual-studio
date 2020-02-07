using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
namespace ServiciosProveedor
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiciosProveedor" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiciosProveedor
    {

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListaSaldo", ResponseFormat = WebMessageFormat.Json)]
        List<SaldoClase> ListarSaldo();
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarSaldo", ResponseFormat = WebMessageFormat.Json)]
        SaldoClase ListaSaldo();
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AgregarSaldo", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AgregarSaldo(SaldoClase ali);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Stock/{codigo},{cantidad}", ResponseFormat = WebMessageFormat.Json)]
        bool Stock(string codigo,string cantidad);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "StockS/{codigo},{cantidad}", ResponseFormat = WebMessageFormat.Json)]
        bool StockS(string codigo, string cantidad);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Login/{user},{pass}", ResponseFormat = WebMessageFormat.Json)]
        ProveedorClase Login(string user, string pass);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarInfoAlimentos", ResponseFormat = WebMessageFormat.Json)]
        List<InfoAlimentos> ListarInfoAlimentos();

       

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarComunas", ResponseFormat = WebMessageFormat.Json)]
        List<ComunaClase> ListarComunas();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarAlimentos", ResponseFormat = WebMessageFormat.Json)]
        List<AlimentoClase> ListarAlimentos();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AgregarAlimentos", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AgregarAlimentos(AlimentoClase ali);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "EditarAlimentos", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EditarAlimentos(AlimentoClase ali);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "EliminarAlimentos", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EliminarAlimentos(AlimentoClase ali);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "BuscarAlimentos/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        AlimentoClase BuscarAlimentos(string codigo);


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarTipoAlimentos", ResponseFormat = WebMessageFormat.Json)]
        List<TipoAlimentoClase> ListarTipoAlimentos();
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "BuscarTipoAlimentos/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        TipoAlimentoClase BuscarTipoAlimentos(string codigo);
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AgregarTipoAlimentos", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AgregarTipoAlimentos(TipoAlimentoClase tipo);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "EditarTipoAlimentos", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EditarTipoAlimentos(TipoAlimentoClase tipo);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "EliminarTipoAlimentos", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EliminarTipoAlimentos(TipoAlimentoClase tipo);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "BuscarCategoriaAlimentos/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        CategoriaClase BuscarCategoriaAlimentos(string codigo);
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AgregarCategoriaAlimentos", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AgregarCategoriaAlimentos(CategoriaClase cat);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "EditarCategoriaAlimentos", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EditarCategoriaAlimentos(CategoriaClase cat);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "EliminarCategoriaAlimentos", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EliminarCategoriaAlimentos(CategoriaClase cat);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarCategoriaAlimentos", ResponseFormat = WebMessageFormat.Json)]
        List<CategoriaClase> ListarCategoriaAlimentos();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarRegiones", ResponseFormat = WebMessageFormat.Json)]
        List<RegionClase> ListarRegiones();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarDetalleAlimentos", ResponseFormat = WebMessageFormat.Json)]
        List<DetalleAlimentoClase> ListarDetalleAlimentos();



        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarProveedor", ResponseFormat = WebMessageFormat.Json)]
        List<ProveedorClase> ListarProveedores();
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "BuscarProveedor/{rut}", ResponseFormat = WebMessageFormat.Json)]
        ProveedorClase BuscarProveedor(string rut);
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AgregarProveedor", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AgregarProveedor(ProveedorClase pro);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "EditarProveedor", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EditarProveedor(ProveedorClase pro);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "EliminarProveedor", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EliminarProveedor(ProveedorClase pro);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarDatosBancariosC/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        List<DatosBancariosClase> ListarDatosBancariosC(string codigo);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarAlimentosC/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        List<AlimentoClase> ListarAlimentosC(string codigo);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarProveedorC/{Codigo}", ResponseFormat = WebMessageFormat.Json)]
        List<ProveedorClase> ListarProveedorC(string codigo);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarSucursalesC/{Codigo}", ResponseFormat = WebMessageFormat.Json)]
        List<SucursalClase> ListarSucursalesC(string codigo);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarSucursales", ResponseFormat = WebMessageFormat.Json)]
        List<SucursalClase> ListarSucursales();
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "BuscarSucursal/{rut}", ResponseFormat = WebMessageFormat.Json)]
        SucursalClase BuscarSucursal(string rut);
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AgregarSucursal", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AgregarSucursal(SucursalClase suc);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "EditarSucursal", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EditarSucursal(SucursalClase suc);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "EliminarSucursal", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EliminarSucursal(SucursalClase suc);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarBancos", ResponseFormat = WebMessageFormat.Json)]
        List<BancoClase> ListarBancos();
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "BuscarBancos/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        BancoClase BuscarBancos(string codigo);
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AgregarBancos", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AgregarBancos(BancoClase ban);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "EditarBancos", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EditarBancos(BancoClase ban);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "EliminarBancos", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EliminarBancos(BancoClase ban);


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarDatosBancarios", ResponseFormat = WebMessageFormat.Json)]
        List<DatosBancariosClase> ListarDatosBancarios();
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "BuscarDatosBancarios/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        DatosBancariosClase BuscarDatosBancarios(string codigo);
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AgregarDatosBancarios", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AgregarDatosBancarios(DatosBancariosClase ban);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "EliminarDatosBancarios", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EliminarDatosBancarios(DatosBancariosClase ban);


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarTipoCuentas", ResponseFormat = WebMessageFormat.Json)]
        List<TipoCuentaClase> ListarTipoCuentas();
    }
}
