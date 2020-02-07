using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicios" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicios
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Login/{rut},{nombre}", ResponseFormat = WebMessageFormat.Json)]
        EmpleadoC Login(string rut, string nombre);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarPersonas", ResponseFormat = WebMessageFormat.Json)]
        List<PersonaC> ListarPersonas();
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AgregarPersonas", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AgregarPersonas(PersonaC per);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "EditarPersonas", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EditarPersonas(PersonaC per);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "EliminarPersonas", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EliminarPersonas(PersonaC per);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "BuscarPersonas/{rut}", ResponseFormat = WebMessageFormat.Json)]
        PersonaC BuscarPersonas(string rut);


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarCategorias", ResponseFormat = WebMessageFormat.Json)]
        List<CategoriaC> ListarCategorias();
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AgregarCategorias", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AgregarCategorias(CategoriaC cate);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "EditarCategorias", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EditarCategorias(CategoriaC cate);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "EliminarCategorias", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EliminarCategorias(CategoriaC cate);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "BuscarCategorias/{nombre}", ResponseFormat = WebMessageFormat.Json)]
        CategoriaC BuscarCategorias(string nombre);


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarFallecidos", ResponseFormat = WebMessageFormat.Json)]
        List<FallecidoC> ListarFallecidos();
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AgregarFallecidos", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AgregarFallecidos(FallecidoC f);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "EditarFallecidos", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EditarFallecidos(FallecidoC f);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "EliminarFallecidos", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EliminarFallecidos(FallecidoC f);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "BuscarFallecidos/{rut}", ResponseFormat = WebMessageFormat.Json)]
        FallecidoC BuscarFallecidos(string rut);


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarDatosInteres", ResponseFormat = WebMessageFormat.Json)]
        List<DatoInteresC> ListarDatosInteres();
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AgregarDatosInteres", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AgregarDatosInteres(DatoInteresC f);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "EditarDatosInteres", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EditarDatosInteres(DatoInteresC f);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "EliminarDatosInteres", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EliminarDatosInteres(DatoInteresC f);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "BuscarDatosInteres/{nombre}", ResponseFormat = WebMessageFormat.Json)]
        DatoInteresC BuscarDatosInteres(string nombre);


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarDetallesDatosInteres", ResponseFormat = WebMessageFormat.Json)]
        List<DetalleDatoInteresC> ListarDetallesDatosInteres();
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AgregarDetallesDatosInteres", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AgregarDetallesDatosInteres(DetalleDatoInteresC f);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "EditarDetallesDatosInteres", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EditarDetallesDatosInteres(DetalleDatoInteresC f);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "EliminarDetallesDatosInteres", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EliminarDetallesDatosInteres(DetalleDatoInteresC f);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "BuscarDetallesDatosInteres/{id}", ResponseFormat = WebMessageFormat.Json)]
        DetalleDatoInteresC BuscarDetallesDatosInteres(string id);


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarDetallesFacturas", ResponseFormat = WebMessageFormat.Json)]
        List<DetalleFacturaC> ListarDetallesFacturas();
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AgregarDetallesFacturas", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AgregarDetallesFacturas(DetalleFacturaC f);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "EditarDetallesFacturas", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EditarDetallesFacturas(DetalleFacturaC f);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "EliminarDetallesFacturas", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EliminarDetallesFacturas(DetalleFacturaC f);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "BuscarDetallesFacturas/{id}", ResponseFormat = WebMessageFormat.Json)]
        DetalleFacturaC BuscarDetallesFacturas(string id);


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarEmpleados", ResponseFormat = WebMessageFormat.Json)]
        List<EmpleadoC> ListarEmpleados();
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AgregarEmpleados", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AgregarEmpleados(EmpleadoC f);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "EditarEmpleados", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EditarEmpleados(EmpleadoC f);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "EliminarEmpleados", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EliminarEmpleados(EmpleadoC f);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "BuscarEmpleados/{rut}", ResponseFormat = WebMessageFormat.Json)]
        EmpleadoC BuscarEmpleados(string rut);


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarFacturas", ResponseFormat = WebMessageFormat.Json)]
        List<FacturaC> ListarFacturas();
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AgregarFacturas", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AgregarFacturas(FacturaC f);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "EditarFacturas", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EditarFacturas(FacturaC f);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "EliminarFacturas", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EliminarFacturas(FacturaC f);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "BuscarFacturas/{id}", ResponseFormat = WebMessageFormat.Json)]
        FacturaC BuscarFacturas(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarFamiliares", ResponseFormat = WebMessageFormat.Json)]
        List<FamiliarC> ListarFamiliar();
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AgregarFamiliares", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AgregarFamiliares( FamiliarC f);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "EditarFamiliares", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EditarFamiliares(FamiliarC f);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "EliminarFamiliares", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EliminarFamiliares(FamiliarC f);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "BuscarFamiliares/{rut}", ResponseFormat = WebMessageFormat.Json)]
        FamiliarC BuscarFamiliares(string rut);


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarJornadaLaborales", ResponseFormat = WebMessageFormat.Json)]
        List<JornadaLaboralC> ListarJornadaLaboral();
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AgregarJornadaLaborales", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AgregarJornadaLaborales(JornadaLaboralC f);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "EditarJornadaLaborales", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EditarJornadaLaborales(JornadaLaboralC f);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "EliminarJornadaLaborales", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EliminarJornadaLaborales(JornadaLaboralC f);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "BuscarJornadaLaborales/{nombre}", ResponseFormat = WebMessageFormat.Json)]
        JornadaLaboralC BuscarJornadaLaborales(string nombre);


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarMateriales", ResponseFormat = WebMessageFormat.Json)]
        List<MaterialC> ListarMateriales();
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AgregarMateriales", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AgregarMateriales(MaterialC f);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "EditarMateriales", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EditarMateriales(MaterialC f);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "EliminarMateriales", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EliminarMateriales(MaterialC f);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "BuscarMateriales/{nombre}", ResponseFormat = WebMessageFormat.Json)]
        MaterialC BuscarMateriales(string nombre);


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarSectores", ResponseFormat = WebMessageFormat.Json)]
        List<SectorC> ListarSector();
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AgregarSectores", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AgregarSectores(SectorC f);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "EditarSectores", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EditarSectores(SectorC f);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "EliminarSectores", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EliminarSectores(SectorC f);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "BuscarSectores/{nombre}", ResponseFormat = WebMessageFormat.Json)]
        SectorC BuscarSectores(string nombre);


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarTipoTumbas", ResponseFormat = WebMessageFormat.Json)]
        List<TipoTumbaC> ListarTipoTumba();
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AgregarTipoTumbas", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AgregarTipoTumbas(TipoTumbaC f);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "EditarTipoTumbas", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EditarTipoTumbas(TipoTumbaC f);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "EliminarTipoTumbas", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EliminarTipoTumbas(TipoTumbaC f);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "BuscarTipoTumbas/{nombre}", ResponseFormat = WebMessageFormat.Json)]
        TipoTumbaC BuscarTipoTumbas(string nombre);


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarTumbas", ResponseFormat = WebMessageFormat.Json)]
        List<TumbaC> ListarTumbas();
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AgregarTumbas", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AgregarTumbas(TumbaC f);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "EditarTumbas", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EditarTumbas(TumbaC f);
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "EliminarTumbas", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool EliminarTumbas(TumbaC f);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "BuscarTumbas/{rut}", ResponseFormat = WebMessageFormat.Json)]
        TumbaC BuscarTumbas(string rut);

    }
}
