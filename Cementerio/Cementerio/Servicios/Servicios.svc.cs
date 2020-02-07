using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Servicios" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Servicios.svc o Servicios.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Servicios : IServicios
    {
        /****************************PERSONAS**********************************************/

        

        public List<PersonaC> ListarPersonas()
        {
            using (mbbCementerioEntities su = new mbbCementerioEntities())
            {


                return su.persona.Select(s => new PersonaC
                {
                    id = s.id,
                    rut=s.rut,
                    nombre = s.nombre,
                    apellidoPaterno = s.apellidoPaterno,
                    apellidoMaterno=s.apellidoMaterno,
                    edad=s.edad,
                    telefono=s.telefono
                }).ToList();
            };
        }

        public bool AgregarPersonas(PersonaC per)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    persona x = new persona();
                    x.rut = per.rut;
                    x.nombre = per.nombre;
                    x.apellidoPaterno = per.apellidoPaterno;
                    x.apellidoMaterno = per.apellidoMaterno;
                    x.edad = per.edad;
                    x.telefono = per.telefono;
                    mbb.persona.Add(x);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EditarPersonas(PersonaC per)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {

                    persona x = mbb.persona.Single(t => t.id == per.id);
                    x.rut = per.rut;                    
                    x.nombre = per.nombre;
                    x.apellidoPaterno = per.apellidoPaterno;
                    x.apellidoMaterno = per.apellidoMaterno;
                    x.edad = per.edad;
                    x.telefono = per.telefono;
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EliminarPersonas(PersonaC per)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    persona x = mbb.persona.Single(t => t.id == per.id);
                    mbb.persona.Remove(x);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public PersonaC BuscarPersonas(string rut)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {

                return mbb.persona.Where(p => p.rut == rut).Select(s => new PersonaC
                {
                    id = s.id,
                    rut = s.rut,
                    nombre = s.nombre,
                    apellidoPaterno = s.apellidoPaterno,
                    apellidoMaterno = s.apellidoMaterno,
                    edad = s.edad,
                    telefono = s.telefono
                }).First();

            };
        }

        /****************************CATEGORIAS**********************************************/
        public List<CategoriaC> ListarCategorias()
        {
            using (mbbCementerioEntities su = new mbbCementerioEntities())
            {


                return su.categoria.Select(s => new CategoriaC
                {
                    id=s.id,
                    nombre=s.nombre,
                    descripcion=s.descripcion
                }).ToList();
            };
        }

        public bool AgregarCategorias(CategoriaC cate)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    categoria x = new categoria();

                    x.nombre = cate.nombre;
                    x.descripcion = cate.descripcion;
                    mbb.categoria.Add(x);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EditarCategorias(CategoriaC cate)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    
                    categoria x = mbb.categoria.Single(t => t.id == cate.id);
                    x.nombre = cate.nombre;
                    x.descripcion = cate.descripcion;
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EliminarCategorias(CategoriaC cate)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    categoria x = mbb.categoria.Single(t => t.id== cate.id);
                    mbb.categoria.Remove(x);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public CategoriaC BuscarCategorias(string nombre)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                    
                    return mbb.categoria.Where(p => p.nombre == nombre).Select(p => new CategoriaC
                    {
                        nombre = p.nombre,
                        id = p.id,
                        descripcion = p.descripcion
                    }).First();
                
            };
        }


        /****************************FALLECIDOS**********************************************/
        public List<FallecidoC> ListarFallecidos()
        {
            using (mbbCementerioEntities su = new mbbCementerioEntities())
            {
                
                return su.fallecido.Select(e => new FallecidoC
                {
                    id = e.id,
                    persona_id = e.persona_id,
                    rut = e.persona.rut,
                    nombre = e.persona.nombre,
                    apellidoPaterno = e.persona.apellidoPaterno,
                    apellidoMaterno = e.persona.apellidoMaterno,
                    edad = e.persona.edad
                }).ToList();
            };
        }
        
        public bool AgregarFallecidos(FallecidoC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {

                    PersonaC p = new PersonaC();
                    p.rut = f.rut;
                    p.nombre = f.nombre;
                    p.apellidoPaterno = f.apellidoPaterno;
                    p.apellidoMaterno = f.apellidoMaterno;
                    p.edad = f.edad;
                    p.telefono = 0;
                    AgregarPersonas(p);
                    fallecido x = new fallecido();
                    x.persona_id = BuscarPersonas(f.rut).id;
                    mbb.fallecido.Add(x);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EditarFallecidos(FallecidoC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {

                    fallecido x = mbb.fallecido.Single(t => t.id == f.id);
                    x.persona.rut = f.rut;
                    x.persona.nombre = f.nombre;
                    x.persona.apellidoPaterno = f.apellidoPaterno;
                    x.persona.apellidoMaterno = f.apellidoMaterno;
                    x.persona.edad = f.edad;
                    x.persona.telefono = f.telefono;
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EliminarFallecidos(FallecidoC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    fallecido x = mbb.fallecido.Single(t => t.id == f.id);
                    mbb.fallecido.Remove(x);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public FallecidoC BuscarFallecidos(string rut)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {

                return mbb.fallecido.Where(p => p.persona.rut == rut).Select(p => new FallecidoC
                {
                    rut=p.persona.rut,
                    persona_id=p.persona_id,                    
                    nombre = p.persona.nombre,
                    id = p.id,
                    apellidoPaterno=p.persona.apellidoPaterno,
                    apellidoMaterno=p.persona.apellidoMaterno,
                    edad=p.persona.edad,
                    telefono=p.persona.telefono

                }).First();

            };
        }


        /****************************DATOS INTERES**********************************************/
        public List<DatoInteresC> ListarDatosInteres()
        {
            using (mbbCementerioEntities su = new mbbCementerioEntities())
            {

                return su.dato_interes.Select(e => new DatoInteresC
                {
                    id = e.id,
                    nombre=e.nombre,
                    descripcion=e.descripcion
                }).ToList();
            };
        }


        public bool AgregarDatosInteres(DatoInteresC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    dato_interes x = new dato_interes();
                    
                    x.nombre = f.nombre;
                    x.descripcion = f.descripcion;
                    mbb.dato_interes.Add(x);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EditarDatosInteres(DatoInteresC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {

                    dato_interes x = mbb.dato_interes.Single(t => t.id == f.id);
                    x.nombre = f.nombre;
                    x.descripcion = f.descripcion;
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EliminarDatosInteres(DatoInteresC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    dato_interes x = mbb.dato_interes.Single(t => t.id == f.id);
                    mbb.dato_interes.Remove(x);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public DatoInteresC BuscarDatosInteres(string nombre)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {

                return mbb.dato_interes.Where(p => p.nombre == nombre).Select(p => new DatoInteresC
                {
                   id=p.id,
                   nombre=p.nombre,
                   descripcion=p.descripcion

                }).First();

            };
        }
        /****************************DETALLES DATOS INTERES**********************************************/
        public List<DetalleDatoInteresC> ListarDetallesDatosInteres()
        {
            using (mbbCementerioEntities su = new mbbCementerioEntities())
            {

                return su.detalle_dato_interes.Select(e => new DetalleDatoInteresC
                {
                    id = e.id,
                    dato_interes_id=e.dato_interes_id,
                    dato_interes_nombre=e.dato_interes.nombre,
                    dato_interes_descripcion=e.dato_interes.descripcion,
                    familiar_id=e.familiar_id,
                    familiar_rut=e.familiar.persona.rut,
                    familiar_nombre=e.familiar.persona.nombre,
                    familiar_apellidoPaterno=e.familiar.persona.apellidoPaterno,
                    familiar_apellidoMaterno=e.familiar.persona.apellidoMaterno,
                    familiar_edad=e.familiar.persona.edad,
                    familiar_telefono=e.familiar.persona.telefono
                }).ToList();
            };
        }


        public bool AgregarDetallesDatosInteres(DetalleDatoInteresC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    DatoInteresC d = new DatoInteresC();
                    d.nombre = f.dato_interes_nombre;
                    d.descripcion = f.dato_interes_descripcion;
                    AgregarDatosInteres(d);
                    detalle_dato_interes x = new detalle_dato_interes();
                    x.dato_interes_id = BuscarDatosInteres(d.nombre).id;
                    x.familiar_id = f.familiar_id;
                    mbb.detalle_dato_interes.Add(x);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EditarDetallesDatosInteres(DetalleDatoInteresC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {

                    detalle_dato_interes x = mbb.detalle_dato_interes.Single(t => t.id == f.id);
                    x.familiar_id = f.familiar_id;
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EliminarDetallesDatosInteres(DetalleDatoInteresC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    detalle_dato_interes x = mbb.detalle_dato_interes.Single(t => t.id == f.id);
                    mbb.detalle_dato_interes.Remove(x);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public DetalleDatoInteresC BuscarDetallesDatosInteres(string id)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                int i = int.Parse(id);
                return mbb.detalle_dato_interes.Where(p => p.id == i).Select(e => new DetalleDatoInteresC
                {
                    id = e.id,
                    dato_interes_id = e.dato_interes_id,
                    dato_interes_nombre = e.dato_interes.nombre,
                    dato_interes_descripcion = e.dato_interes.descripcion,
                    familiar_id = e.familiar_id,
                    familiar_rut = e.familiar.persona.rut,
                    familiar_nombre = e.familiar.persona.nombre,
                    familiar_apellidoPaterno = e.familiar.persona.apellidoPaterno,
                    familiar_apellidoMaterno = e.familiar.persona.apellidoMaterno,
                    familiar_edad = e.familiar.persona.edad,
                    familiar_telefono = e.familiar.persona.telefono

                }).First();

            };
        }


        /****************************EMPLEADOS**********************************************/
        public List<EmpleadoC> ListarEmpleados()
        {
            using (mbbCementerioEntities su = new mbbCementerioEntities())
            {

                return su.empleado.Select(e => new EmpleadoC
                {
                    id = e.id,
                    antiguedad=e.antiguedad,
                    categoria_id=e.categoria_id,
                    categoria_nombre=e.categoria.nombre,
                    jornada_laboral_id=e.jornada_laboral_id,
                    jornada_laboral_nombre=e.jornada_laboral.nombre,
                    persona_id=e.persona_id,
                    empleado_rut=e.persona.rut,
                    empleado_nombre=e.persona.nombre,
                    empleado_apellidoPaterno=e.persona.apellidoPaterno,
                    empleado_apellidoMaterno=e.persona.apellidoMaterno,
                    empleado_edad=e.persona.edad,
                    empleado_telefono=e.persona.telefono,
                    salario=e.salario
                }).ToList();
            };
        }


        public bool AgregarEmpleados(EmpleadoC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    PersonaC p = new PersonaC();
                    p.rut = f.empleado_rut;
                    p.nombre = f.empleado_nombre;
                    p.apellidoPaterno = f.empleado_apellidoPaterno;
                    p.apellidoMaterno = f.empleado_apellidoMaterno;
                    p.edad = f.empleado_edad;
                    p.telefono = f.empleado_telefono;
                    AgregarPersonas(p);
                    empleado x = new empleado();
                    x.persona_id = BuscarPersonas(p.rut).id;
                    x.jornada_laboral_id = f.jornada_laboral_id;
                    x.categoria_id = f.categoria_id;
                    x.antiguedad = f.antiguedad;
                    x.salario = f.salario;
                    mbb.empleado.Add(x);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EditarEmpleados(EmpleadoC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {

                    empleado x = mbb.empleado.Single(t => t.id == f.id);
                    x.persona.rut = f.empleado_rut;
                    x.persona.nombre = f.empleado_nombre;
                    x.persona.apellidoPaterno = f.empleado_apellidoPaterno;
                    x.persona.apellidoMaterno = f.empleado_apellidoMaterno;
                    x.persona.edad = f.empleado_edad;
                    x.persona.telefono = f.empleado_telefono;
                    x.salario = f.salario;
                    x.antiguedad = f.antiguedad;
                    x.categoria_id = f.categoria_id;
                    x.jornada_laboral_id = f.jornada_laboral_id;
                    
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EliminarEmpleados(EmpleadoC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    empleado x = mbb.empleado.Single(t => t.id == f.id);
                    mbb.empleado.Remove(x);
                    mbb.persona.Remove(x.persona);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public EmpleadoC BuscarEmpleados(string rut)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {

                return mbb.empleado.Where(p => p.persona.rut == rut).Select(e => new EmpleadoC
                {
                    id = e.id,
                    antiguedad = e.antiguedad,
                    categoria_id = e.categoria_id,
                    categoria_nombre = e.categoria.nombre,
                    jornada_laboral_id = e.jornada_laboral_id,
                    jornada_laboral_nombre = e.jornada_laboral.nombre,
                    persona_id = e.persona_id,
                    empleado_rut = e.persona.rut,
                    empleado_nombre = e.persona.nombre,
                    empleado_apellidoPaterno = e.persona.apellidoPaterno,
                    empleado_apellidoMaterno = e.persona.apellidoMaterno,
                    empleado_edad = e.persona.edad,
                    empleado_telefono = e.persona.telefono,
                    salario = e.salario

                }).First();

            };
        }

        public EmpleadoC Login(string rut, string nombre)
        {
            using (mbbCementerioEntities tipoPro = new mbbCementerioEntities())
            {

                return tipoPro.empleado.Where(p => p.persona.rut == rut && p.persona.nombre == nombre &&p.categoria_id==3).Select(e => new EmpleadoC
                {
                    id = e.id,
                    antiguedad = e.antiguedad,
                    categoria_id = e.categoria_id,
                    categoria_nombre = e.categoria.nombre,
                    jornada_laboral_id = e.jornada_laboral_id,
                    jornada_laboral_nombre = e.jornada_laboral.nombre,
                    persona_id = e.persona_id,
                    empleado_rut = e.persona.rut,
                    empleado_nombre = e.persona.nombre,
                    empleado_apellidoPaterno = e.persona.apellidoPaterno,
                    empleado_apellidoMaterno = e.persona.apellidoMaterno,
                    empleado_edad = e.persona.edad,
                    empleado_telefono = e.persona.telefono,
                    salario = e.salario
                }).First();
            };
        }

        /****************************DETALLE FACTURAS**********************************************/


        public List<DetalleFacturaC> ListarDetallesFacturas()
        {
            using (mbbCementerioEntities su = new mbbCementerioEntities())
            {

                return su.detalle_factura.Select(e => new DetalleFacturaC
                {
                     id=e.id,
                     tumba_id=e.tumba_id,
                     tumba_tipo=e.tumba.tipo_tumba.nombre,
                     tumba_material=e.tumba.material.nombre,
                     sector_id=e.sector_id,
                     sector_capacidad=e.sector.capacidad,
                     sector_extension_variable=e.sector.extension_variable,
                     fallecido_id=e.tumba.fallecido_id,
                     fallecido_rut=e.tumba.fallecido.persona.rut,
                     fallecido_nombre=e.tumba.fallecido.persona.nombre,
                     fallecido_apellidoPaterno= e.tumba.fallecido.persona.apellidoPaterno,
                     fallecido_apellidoMaterno= e.tumba.fallecido.persona.apellidoMaterno,
                     fallecido_edad= e.tumba.fallecido.persona.edad,
                     familiar_id=e.familiar_id,
                     familiar_rut=e.familiar.persona.rut,
                     familiar_nombre= e.familiar.persona.nombre,
                     familiar_apellidoPaterno= e.familiar.persona.apellidoPaterno,
                     familiar_apellidoMaterno= e.familiar.persona.apellidoMaterno,
                     familiar_edad= e.familiar.persona.edad,
                     familiar_telefono= e.familiar.persona.telefono
                }).ToList();
            };
        }



        public bool AgregarDetallesFacturas(DetalleFacturaC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    detalle_factura x = new detalle_factura();
                    x.fallecido_id = f.fallecido_id;
                    x.familiar_id = f.familiar_id;
                    x.sector_id = f.sector_id;
                    x.tumba_id = f.tumba_id;
                    mbb.detalle_factura.Add(x);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EditarDetallesFacturas(DetalleFacturaC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {

                    detalle_factura x = mbb.detalle_factura.Single(t => t.id == f.id);
                    x.fallecido_id = f.fallecido_id;
                    x.familiar_id = f.familiar_id;
                    x.sector_id = f.sector_id;
                    x.tumba_id = f.tumba_id;
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EliminarDetallesFacturas(DetalleFacturaC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    detalle_factura x = mbb.detalle_factura.Single(t => t.id == f.id);
                    mbb.detalle_factura.Remove(x);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public DetalleFacturaC BuscarDetallesFacturas(string id)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                int i = int.Parse(id);
                return mbb.detalle_factura.Where(p => p.id == i).Select(e => new DetalleFacturaC
                {
                    id = e.id,
                    tumba_id = e.tumba_id,
                    tumba_tipo = e.tumba.tipo_tumba.nombre,
                    tumba_material = e.tumba.material.nombre,
                    sector_id = e.sector_id,
                    sector_capacidad = e.sector.capacidad,
                    sector_extension_variable = e.sector.extension_variable,
                    fallecido_id = e.tumba.fallecido_id,
                    fallecido_rut = e.tumba.fallecido.persona.rut,
                    fallecido_nombre = e.tumba.fallecido.persona.nombre,
                    fallecido_apellidoPaterno = e.tumba.fallecido.persona.apellidoPaterno,
                    fallecido_apellidoMaterno = e.tumba.fallecido.persona.apellidoMaterno,
                    fallecido_edad = e.tumba.fallecido.persona.edad,
                    familiar_id = e.familiar_id,
                    familiar_rut = e.familiar.persona.rut,
                    familiar_nombre = e.familiar.persona.nombre,
                    familiar_apellidoPaterno = e.familiar.persona.apellidoPaterno,
                    familiar_apellidoMaterno = e.familiar.persona.apellidoMaterno,
                    familiar_edad = e.familiar.persona.edad,
                    familiar_telefono = e.familiar.persona.telefono

                }).First();

            };
        }
        private DetalleFacturaC BuscarDetallesFacturas2(string rut)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                
                return mbb.detalle_factura.Where(p => p.fallecido.persona.rut == rut).Select(e => new DetalleFacturaC
                {
                    id = e.id,
                    tumba_id = e.tumba_id,
                    tumba_tipo = e.tumba.tipo_tumba.nombre,
                    tumba_material = e.tumba.material.nombre,
                    sector_id = e.sector_id,
                    sector_capacidad = e.sector.capacidad,
                    sector_extension_variable = e.sector.extension_variable,
                    fallecido_id = e.tumba.fallecido_id,
                    fallecido_rut = e.tumba.fallecido.persona.rut,
                    fallecido_nombre = e.tumba.fallecido.persona.nombre,
                    fallecido_apellidoPaterno = e.tumba.fallecido.persona.apellidoPaterno,
                    fallecido_apellidoMaterno = e.tumba.fallecido.persona.apellidoMaterno,
                    fallecido_edad = e.tumba.fallecido.persona.edad,
                    familiar_id = e.familiar_id,
                    familiar_rut = e.familiar.persona.rut,
                    familiar_nombre = e.familiar.persona.nombre,
                    familiar_apellidoPaterno = e.familiar.persona.apellidoPaterno,
                    familiar_apellidoMaterno = e.familiar.persona.apellidoMaterno,
                    familiar_edad = e.familiar.persona.edad,
                    familiar_telefono = e.familiar.persona.telefono

                }).First();

            };
        }

        /****************************FACTURAS**********************************************/

        public List<FacturaC> ListarFacturas()
        {
            using (mbbCementerioEntities su = new mbbCementerioEntities())
            {

                return su.factura.Select(e => new FacturaC
                {
                    id=e.id,
                    total=e.total,
                    fecha_emision=e.fecha_emision,
                    detalle_factura_id=e.detalle_factura_id,
                    tumba_id = e.detalle_factura.tumba_id,
                    tumba_tipo = e.detalle_factura.tumba.tipo_tumba.nombre,
                    tumba_material = e.detalle_factura.tumba.material.nombre,
                    sector_id = e.detalle_factura.sector_id,
                    sector_capacidad = e.detalle_factura.sector.capacidad,
                    sector_extension_variable = e.detalle_factura.sector.extension_variable,
                    fallecido_id = e.detalle_factura.tumba.fallecido_id,
                    fallecido_rut = e.detalle_factura.tumba.fallecido.persona.rut,
                    fallecido_nombre = e.detalle_factura.tumba.fallecido.persona.nombre,
                    fallecido_apellidoPaterno = e.detalle_factura.tumba.fallecido.persona.apellidoPaterno,
                    fallecido_apellidoMaterno = e.detalle_factura.tumba.fallecido.persona.apellidoMaterno,
                    fallecido_edad = e.detalle_factura.tumba.fallecido.persona.edad,
                    familiar_id = e.detalle_factura.familiar_id,
                    familiar_rut = e.detalle_factura.familiar.persona.rut,
                    familiar_nombre = e.detalle_factura.familiar.persona.nombre,
                    familiar_apellidoPaterno = e.detalle_factura.familiar.persona.apellidoPaterno,
                    familiar_apellidoMaterno = e.detalle_factura.familiar.persona.apellidoMaterno,
                    familiar_edad = e.detalle_factura.familiar.persona.edad,
                    familiar_telefono = e.detalle_factura.familiar.persona.telefono
                    
                }).ToList();
            };
        }


        public bool AgregarFacturas(FacturaC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    FamiliarC fm = new FamiliarC();
                    fm.rut = f.familiar_rut;
                    fm.nombre = f.familiar_nombre;
                    fm.apellidoPaterno = f.familiar_apellidoPaterno;
                    fm.apellidoMaterno = f.familiar_apellidoMaterno;
                    fm.edad = f.familiar_edad;
                    fm.telefono = f.familiar_telefono;
                    AgregarFamiliares(fm);
                    DetalleFacturaC d = new DetalleFacturaC();
                    d.tumba_id = f.tumba_id;
                    d.familiar_id = BuscarFamiliares(fm.rut).id;
                    d.fallecido_id = f.fallecido_id;
                    d.sector_id = f.sector_id;
                    AgregarDetallesFacturas(d);
                    factura x = new factura();
                    x.total = f.total;
                    x.detalle_factura_id = BuscarDetallesFacturas2(f.fallecido_rut).id;
                    x.fecha_emision = f.fecha_emision;
                    mbb.factura.Add(x);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EditarFacturas(FacturaC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {

                    factura x = mbb.factura.Single(t => t.id == f.id);
                    x.total = f.total;
                    x.detalle_factura_id = f.detalle_factura_id;
                    x.fecha_emision = f.fecha_emision;
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EliminarFacturas(FacturaC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    factura x = mbb.factura.Single(t => t.id == f.id);
                    mbb.factura.Remove(x);
                    mbb.detalle_factura.Remove(x.detalle_factura);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public FacturaC BuscarFacturas(string id)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                int i = int.Parse(id)
;                return mbb.factura.Where(p => p.id == i).Select(e => new FacturaC
                {
                    id = e.id,
                    total = e.total,
                    fecha_emision = e.fecha_emision,
                    detalle_factura_id = e.detalle_factura_id,
                    tumba_id = e.detalle_factura.tumba_id,
                    tumba_tipo = e.detalle_factura.tumba.tipo_tumba.nombre,
                    tumba_material = e.detalle_factura.tumba.material.nombre,
                    sector_id = e.detalle_factura.sector_id,
                    sector_capacidad = e.detalle_factura.sector.capacidad,
                    sector_extension_variable = e.detalle_factura.sector.extension_variable,
                    fallecido_id = e.detalle_factura.tumba.fallecido_id,
                    fallecido_rut = e.detalle_factura.tumba.fallecido.persona.rut,
                    fallecido_nombre = e.detalle_factura.tumba.fallecido.persona.nombre,
                    fallecido_apellidoPaterno = e.detalle_factura.tumba.fallecido.persona.apellidoPaterno,
                    fallecido_apellidoMaterno = e.detalle_factura.tumba.fallecido.persona.apellidoMaterno,
                    fallecido_edad = e.detalle_factura.tumba.fallecido.persona.edad,
                    familiar_id = e.detalle_factura.familiar_id,
                    familiar_rut = e.detalle_factura.familiar.persona.rut,
                    familiar_nombre = e.detalle_factura.familiar.persona.nombre,
                    familiar_apellidoPaterno = e.detalle_factura.familiar.persona.apellidoPaterno,
                    familiar_apellidoMaterno = e.detalle_factura.familiar.persona.apellidoMaterno,
                    familiar_edad = e.detalle_factura.familiar.persona.edad,
                    familiar_telefono = e.detalle_factura.familiar.persona.telefono

                }).First();

            };
        }
        /****************************FAMILIARES**********************************************/

        public List<FamiliarC> ListarFamiliar()
        {
            using (mbbCementerioEntities su = new mbbCementerioEntities())
            {

                return su.familiar.Select(e => new FamiliarC
                {
                    id=e.id,
                    persona_id=e.persona_id,
                    rut=e.persona.rut,
                    nombre=e.persona.nombre,
                    apellidoPaterno=e.persona.apellidoPaterno,
                    apellidoMaterno=e.persona.apellidoMaterno,
                    edad=e.persona.edad,
                    telefono=e.persona.telefono
                }).ToList();
            };
        }


        public bool AgregarFamiliares(FamiliarC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    PersonaC p = new PersonaC();
                    p.rut = f.rut;
                    p.nombre = f.nombre;
                    p.apellidoPaterno = f.apellidoPaterno;
                    p.apellidoMaterno = f.apellidoMaterno;
                    p.edad = f.edad;
                    p.telefono = f.telefono;
                    AgregarPersonas(p);
                    familiar x = new familiar();
                    x.persona_id = BuscarPersonas(p.rut).id;
                    mbb.familiar.Add(x);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EditarFamiliares(FamiliarC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {

                    familiar x = mbb.familiar.Single(t => t.id == f.id);
                    x.persona.rut = f.rut;
                    x.persona.nombre = f.nombre;
                    x.persona.apellidoPaterno = f.apellidoPaterno;
                    x.persona.apellidoMaterno = f.apellidoMaterno;
                    x.persona.edad = f.edad;
                    x.persona.telefono = f.telefono;
                   
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EliminarFamiliares(FamiliarC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    familiar x = mbb.familiar.Single(t => t.id == f.id);
                    mbb.familiar.Remove(x);
                    mbb.persona.Remove(x.persona);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public FamiliarC BuscarFamiliares(string rut)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {

                return mbb.familiar.Where(p => p.persona.rut == rut).Select(e => new FamiliarC
                {
                    id = e.id,
                    persona_id = e.persona_id,
                    rut = e.persona.rut,
                    nombre = e.persona.nombre,
                    apellidoPaterno = e.persona.apellidoPaterno,
                    apellidoMaterno = e.persona.apellidoMaterno,
                    edad = e.persona.edad,
                    telefono = e.persona.telefono

                }).First();

            };
        }

        /****************************JORNADA LABORAL**********************************************/

        public List<JornadaLaboralC> ListarJornadaLaboral()
        {
            using (mbbCementerioEntities su = new mbbCementerioEntities())
            {

                return su.jornada_laboral.Select(e => new JornadaLaboralC
                {
                    id=e.id,
                    nombre=e.nombre,
                    descripcion=e.descripcion
                }).ToList();
            };
        }


        public bool AgregarJornadaLaborales(JornadaLaboralC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    jornada_laboral x = new jornada_laboral();

                    x.nombre = f.nombre;
                    x.descripcion = f.descripcion;
                    mbb.jornada_laboral.Add(x);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EditarJornadaLaborales(JornadaLaboralC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {

                    jornada_laboral x = mbb.jornada_laboral.Single(t => t.id == f.id);
                    x.nombre = f.nombre;
                    x.descripcion = f.descripcion;
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EliminarJornadaLaborales(JornadaLaboralC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    jornada_laboral x = mbb.jornada_laboral.Single(t => t.id == f.id);
                    mbb.jornada_laboral.Remove(x);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public JornadaLaboralC BuscarJornadaLaborales(string nombre)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {

                return mbb.jornada_laboral.Where(p => p.nombre == nombre).Select(e => new JornadaLaboralC
                {
                    id = e.id,
                    nombre = e.nombre,
                    descripcion = e.descripcion

                }).First();

            };
        }

        /****************************MATERIALES**********************************************/

        public List<MaterialC> ListarMateriales()
        {
            using (mbbCementerioEntities su = new mbbCementerioEntities())
            {

                return su.material.Select(e => new MaterialC
                {
                    id=e.id,
                    nombre=e.nombre,
                    descripcion=e.descripcion
                }).ToList();
            };
        }


        public bool AgregarMateriales(MaterialC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    material x = new material();
                    x.nombre = f.nombre;
                    x.descripcion = f.descripcion;
                    mbb.material.Add(x);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EditarMateriales(MaterialC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {

                    material x = mbb.material.Single(t => t.id == f.id);
                    x.nombre = f.nombre;
                    x.descripcion = f.descripcion;
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EliminarMateriales(MaterialC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    material x = mbb.material.Single(t => t.id == f.id);
                    mbb.material.Remove(x);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public MaterialC BuscarMateriales(string nombre)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {

                return mbb.material.Where(p => p.nombre == nombre).Select(p => new MaterialC
                {

                    id = p.id,
                    nombre = p.nombre,
                    descripcion = p.descripcion


            }).First();

            };
        }
        /****************************SECTORES**********************************************/

        public List<SectorC> ListarSector()
        {
            using (mbbCementerioEntities su = new mbbCementerioEntities())
            {

                return su.sector.OrderBy(s=>s.capacidad).Select(e => new SectorC
                {
                    id=e.id,
                    capacidad=e.capacidad,
                    extension_variable=e.extension_variable
                }).ToList();
            };
        }

        public bool AgregarSectores(SectorC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    sector x = new sector();
                    x.capacidad = f.capacidad;
                    x.extension_variable = f.extension_variable;
                    mbb.sector.Add(x);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EditarSectores(SectorC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {

                    sector x = mbb.sector.Single(t => t.id == f.id);
                    x.capacidad = f.capacidad;
                    x.extension_variable = f.extension_variable;
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EliminarSectores(SectorC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    sector x = mbb.sector.Single(t => t.id == f.id);
                    mbb.sector.Remove(x);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public SectorC BuscarSectores(string id)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                int i = int.Parse(id);
                return mbb.sector.Where(p => p.id == i).Select(p => new SectorC
                {
                    id=p.id,
                    capacidad=p.capacidad,
                    extension_variable=p.extension_variable

                }).First();

            };
        }


        /****************************TIPO DE TUMBAS**********************************************/

        public List<TipoTumbaC> ListarTipoTumba()
        {
            using (mbbCementerioEntities su = new mbbCementerioEntities())
            {

                return su.tipo_tumba.Select(e => new TipoTumbaC
                {
                    id = e.id,
                    nombre=e.nombre,
                    descripcion=e.descripcion
                }).ToList();
            };
        }

        public bool AgregarTipoTumbas(TipoTumbaC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    tipo_tumba x = new tipo_tumba();

                    x.nombre = f.nombre;
                    x.descripcion = f.descripcion;
                    mbb.tipo_tumba.Add(x);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EditarTipoTumbas(TipoTumbaC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {

                    tipo_tumba x = mbb.tipo_tumba.Single(t => t.id == f.id);
                    x.nombre = f.nombre;
                    x.descripcion = f.descripcion;
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EliminarTipoTumbas(TipoTumbaC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    tipo_tumba x = mbb.tipo_tumba.Single(t => t.id == f.id);
                    mbb.tipo_tumba.Remove(x);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public TipoTumbaC BuscarTipoTumbas(string nombre)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {

                return mbb.tipo_tumba.Where(p => p.nombre==nombre).Select(p => new TipoTumbaC
                {
                    id=p.id,
                    nombre=p.nombre,
                    descripcion=p.descripcion

                }).First();

            };
        }

        /****************************TUMBAS**********************************************/

        public List<TumbaC> ListarTumbas()
        {
            using (mbbCementerioEntities su = new mbbCementerioEntities())
            {

                return su.tumba.Select(e => new TumbaC
                {
                    id = e.id,
                    fallecido_id=e.fallecido_id,
                    fallecido_rut = e.fallecido.persona.rut,
                    fallecido_nombre = e.fallecido.persona.nombre,
                    fallecido_apellidoPaterno = e.fallecido.persona.apellidoPaterno,
                    fallecido_apellidoMaterno = e.fallecido.persona.apellidoMaterno,
                    fallecido_edad = e.fallecido.persona.edad,
                    material_id=e.material_id,
                    material_nombre=e.material.nombre,
                    tipo_tumba_id=e.tipo_tumba_id,
                    tipo_tumba_nombre=e.tipo_tumba.nombre
                }).ToList();
            };
        }

        public bool AgregarTumbas(TumbaC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    FallecidoC fa = new FallecidoC();
                    fa.rut = f.fallecido_rut;
                    fa.nombre = f.fallecido_nombre;
                    fa.apellidoPaterno = f.fallecido_apellidoPaterno;
                    fa.apellidoMaterno = f.fallecido_apellidoMaterno;
                    fa.edad = f.fallecido_edad;
                    AgregarFallecidos(fa);
                    tumba x = new tumba();
                    x.tipo_tumba_id = f.tipo_tumba_id;
                    x.fallecido_id = BuscarFallecidos(fa.rut).id;
                    x.material_id = f.material_id;
                    mbb.tumba.Add(x);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EditarTumbas(TumbaC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {

                    tumba x = mbb.tumba.Single(t => t.id == f.id);
                    x.tipo_tumba_id = f.tipo_tumba_id;
                    x.fallecido_id = f.fallecido_id;
                    x.material_id = f.material_id;
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EliminarTumbas(TumbaC f)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {
                try
                {
                    tumba x = mbb.tumba.Single(t => t.id == f.id);
                    mbb.tumba.Remove(x);
                    mbb.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public TumbaC BuscarTumbas(string rut)
        {
            using (mbbCementerioEntities mbb = new mbbCementerioEntities())
            {

                return mbb.tumba.Where(p => p.fallecido.persona.rut == rut).Select(e => new TumbaC
                {
                    id = e.id,
                    fallecido_id = e.fallecido_id,
                    fallecido_rut = e.fallecido.persona.rut,
                    fallecido_nombre = e.fallecido.persona.nombre,
                    fallecido_apellidoPaterno = e.fallecido.persona.apellidoPaterno,
                    fallecido_apellidoMaterno = e.fallecido.persona.apellidoMaterno,
                    fallecido_edad = e.fallecido.persona.edad,
                    material_id = e.material_id,
                    material_nombre = e.material.nombre,
                    tipo_tumba_id = e.tipo_tumba_id,
                    tipo_tumba_nombre = e.tipo_tumba.nombre

                }).First();

            };
        }

        

     

        

        
    }
}
