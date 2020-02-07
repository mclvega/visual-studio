using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosProveedor
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiciosProveedor" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiciosProveedor.svc o ServiciosProveedor.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiciosProveedor : IServiciosProveedor
    {

        public List<SaldoClase> ListarSaldo()
        {
            using (IntegracionEntities su = new IntegracionEntities())
            {


                return su.Saldo.OrderByDescending(a => a.codigo).Select(s => new SaldoClase
                {
                    codigo = s.codigo,
                    datosBancarios = s.datosBancarios,
                    nCuenta = s.DatosBancarios1.numeroCuenta,
                    monto = s.monto
                }).ToList();
            };
        }
        public SaldoClase ListaSaldo()
        {
            using (IntegracionEntities su = new IntegracionEntities())
            {


                return su.Saldo.OrderByDescending(a => a.codigo).Select(s => new SaldoClase
                {
                    codigo = s.codigo,
                    datosBancarios = s.datosBancarios,
                    nCuenta = s.DatosBancarios1.numeroCuenta,
                    monto = s.monto
                }).First();
            };
        }

        public bool AgregarSaldo(SaldoClase ali)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {
                try
                {
                    Saldo t = new Saldo();

                    t.datosBancarios = ali.datosBancarios;
                    t.monto = ali.monto;
                    tipoPro.Saldo.Add(t);
                    tipoPro.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public List<CategoriaClase> ListarCategoriaAlimentos()
        {
            using (IntegracionEntities cat = new IntegracionEntities())
            {
                return cat.Categoria.Select(ca => new CategoriaClase
                {
                    Codigo = ca.codigo,
                    Nombre = ca.nombre,
                    Descripcion = ca.descripcion,
                    Activo = ca.activo
                }).ToList();
            };
        }

        public List<ComunaClase> ListarComunas()
        {
            using (IntegracionEntities com = new IntegracionEntities())
            {
                return com.Comuna.OrderBy(s => s.nombre).Select(c => new ComunaClase
                {
                    Codigo = c.codigo,
                    Nombre = c.nombre,
                    Provincia = c.provincia
                }).ToList();
            };
        }

        public List<BancoClase> ListarBancos()
        {
            using (IntegracionEntities com = new IntegracionEntities())
            {
                return com.Banco.Select(c => new BancoClase
                {
                    Codigo = c.codigo,
                    Nombre = c.nombre,
                    Activo = c.activo

                }).ToList();
            };
        }

        public bool AgregarBancos(BancoClase ban)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {
                try
                {
                    Banco t = new Banco();

                    t.nombre = ban.Nombre;
                    t.activo = 1;
                    tipoPro.Banco.Add(t);
                    tipoPro.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EditarBancos(BancoClase ban)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {
                try
                {
                    decimal c = ban.Codigo;
                    Banco ti = tipoPro.Banco.Single(t => t.codigo == c);
                    ti.nombre = ban.Nombre;
                    tipoPro.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }
        public bool EliminarBancos(BancoClase ban)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {
                try
                {
                    Banco ti = tipoPro.Banco.Single(t => t.codigo == ban.Codigo);
                    tipoPro.Banco.Remove(ti);
                    tipoPro.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }
        public BancoClase BuscarBancos(string codigo)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {

                decimal c = decimal.Parse(codigo);
                return tipoPro.Banco.Where(p => p.codigo == c).Select(p => new BancoClase
                {
                    Nombre = p.nombre,
                    Codigo = p.codigo,
                    Activo = p.activo
                }).First();
            };
        }



        public List<DetalleAlimentoClase> ListarDetallePro()
        {
            using (IntegracionEntities det = new IntegracionEntities())
            {
                return det.DetalleAlimento.Select(d => new DetalleAlimentoClase
                {
                    codigo = d.codigo,
                    categoria = d.categoria,
                    producto = d.alimento,
                    tipoProducto = d.tipoAlimento,
                    activo = d.activo
                }).ToList();
            };
        }

        public List<AlimentoClase> ListarAlimentos()
        {
            using (IntegracionEntities pro = new IntegracionEntities())
            {
                return pro.Alimento.Select(p => new AlimentoClase
                {
                    Codigo = p.Codigo,
                    Nombre = p.nombre,
                    DatosSucursal = p.Sucursal1.Proveedor1.nombre + " " + p.Sucursal1.rut,
                    Descripcion = p.descripcion,
                    ProveedorC=p.Sucursal1.proveedor,
                    
                    Precio = p.precio,
                    Foto = "http://drive.google.com/uc?export=view&id=" + p.foto,
                    CategoriaAlimento = p.CategoriaAlimento,
                    TipoAlimento = p.TipoAlimento,
                    Fecha_elaboracion = p.fecha_elaboracion,
                    Fecha_vencimiento = p.fecha_vencimiento,
                    DatosCategoria = p.Categoria.nombre,
                    DatosTipo = p.TipoAlimento1.nombre,
                    Stock = p.stock,
                    Sucursal = p.Sucursal,
                    Activo = p.activo
                }).ToList();
            };
        }

        public bool AgregarAlimentos(AlimentoClase ali)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {
                try
                {
                    Alimento t = new Alimento();

                    t.nombre = ali.Nombre;
                    t.descripcion = ali.Descripcion;
                    t.precio = ali.Precio;
                    t.fecha_elaboracion = ali.Fecha_elaboracion;
                    t.foto = ali.Foto;
                    t.fecha_vencimiento = ali.Fecha_vencimiento;
                    t.stock = ali.Stock;
                    t.CategoriaAlimento = ali.CategoriaAlimento;
                    t.TipoAlimento = ali.TipoAlimento;
                    t.Sucursal = ali.Sucursal;
                    t.activo = 1;
                    tipoPro.Alimento.Add(t);
                    tipoPro.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }
        public AlimentoClase BuscarAlimentos(string codigo)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {

                decimal c = Decimal.Parse(codigo);
                return tipoPro.Alimento.Where(p => p.Codigo == c).Select(p => new AlimentoClase
                {
                    Codigo = p.Codigo,
                    CategoriaAlimento = p.CategoriaAlimento,
                    Fecha_elaboracion = p.fecha_elaboracion,
                    Foto = p.foto,
                    Fecha_vencimiento = p.fecha_vencimiento,
                    Precio = p.precio,
                    Stock = p.stock,
                    ProveedorC = p.Sucursal1.proveedor,
                    DatosCategoria = p.Categoria.nombre,
                    DatosSucursal = p.Sucursal1.Proveedor1.nombre + " " + p.Sucursal1.rut,
                    DatosTipo = p.TipoAlimento1.nombre,
                    Sucursal = p.Sucursal,
                    TipoAlimento = p.TipoAlimento,
                    Nombre = p.nombre,
                    Descripcion = p.descripcion,
                    Activo = p.activo
                }).First();
            };
        }

        public bool EditarAlimentos(AlimentoClase ali)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {
                try
                {
                    decimal c = ali.Codigo;
                    Alimento ti = tipoPro.Alimento.Single(t => t.Codigo == c);
                    ti.nombre = ali.Nombre;
                    ti.descripcion = ali.Descripcion;
                    ti.precio = ali.Precio;
                    ti.stock = ali.Stock;
                    ti.fecha_elaboracion = ali.Fecha_elaboracion;
                    ti.fecha_vencimiento = ali.Fecha_vencimiento;
                    ti.Sucursal = ali.Sucursal;
                    ti.foto = ali.Foto;
                    ti.CategoriaAlimento = ali.CategoriaAlimento;
                    ti.TipoAlimento = ali.TipoAlimento;
                    if (ali.Stock>0)
                    {
                        ti.activo = 1;
                    }
                    
                    tipoPro.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EliminarAlimentos(AlimentoClase ali)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {
                try
                {
                    Alimento ti = tipoPro.Alimento.Single(t => t.Codigo == ali.Codigo);
                    tipoPro.Alimento.Remove(ti);
                    tipoPro.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public List<ProveedorClase> ListarProveedores()
        {
            using (IntegracionEntities pr = new IntegracionEntities())
            {
                return pr.Proveedor.Select(c => new ProveedorClase
                {
                    Codigo = c.codigo,
                    Rut = c.rut,
                    Usuario = c.usuario,
                    Pass = c.pass,
                    Telefono = c.telefono,
                    Correo = c.correo,
                    Nombre = c.nombre,
                    Activo = c.activo
                }).ToList();
            };
        }

        public List<RegionClase> ListarRegiones()
        {
            using (IntegracionEntities re = new IntegracionEntities())
            {
                return re.Region.Select(r => new RegionClase
                {
                    codigo = r.codigo,
                    nombre = r.nombre,
                    ordinal = r.ordinal
                }).ToList();
            };
        }

        public List<SucursalClase> ListarSucursales()
        {
            using (IntegracionEntities su = new IntegracionEntities())
            {
                return su.Sucursal.Select(s => new SucursalClase
                {
                    Codigo = s.codigo,
                    NombreProveedor = s.Proveedor1.nombre,
                    CP = s.Proveedor1.codigo,
                    Rut = s.rut,
                    Comuna = s.comuna,
                    Direccion = s.direccion,
                    Proveedor = s.proveedor,
                    NombreComuna = s.Comuna1.nombre,
                    Telefono = s.telefono,
                    Latitud = s.latitud,
                    Longitud = s.longitud,
                    Activo = s.activo
                }).ToList();
            };
        }

        public List<TipoAlimentoClase> ListarTipoProductos()
        {
            using (IntegracionEntities pro = new IntegracionEntities())
            {
                return pro.TipoAlimento.OrderByDescending(p => p.nombre).Select(p => new TipoAlimentoClase
                {
                    Codigo = p.codigo,
                    Nombre = p.nombre,
                    Descripcion = p.descripcion,
                    Activo = p.activo
                }).ToList();
            };
        }

        public TipoAlimentoClase BuscarTipoAlimentos(string codigo)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {
                decimal c = decimal.Parse(codigo);
                return tipoPro.TipoAlimento.Where(p => p.codigo == c).Select(p => new TipoAlimentoClase
                {
                    Codigo = p.codigo,
                    Nombre = p.nombre,
                    Descripcion = p.descripcion,
                    Activo = p.activo
                }).First();
            };
        }

        public bool AgregarTipoAlimentos(TipoAlimentoClase tipo)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {
                try
                {
                    TipoAlimento t = new TipoAlimento();
                    t.nombre = tipo.Nombre;
                    t.descripcion = tipo.Descripcion;
                    t.activo = 1;
                    tipoPro.TipoAlimento.Add(t);
                    tipoPro.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EditarTipoAlimentos(TipoAlimentoClase tipo)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {
                try
                {
                    TipoAlimento ti = tipoPro.TipoAlimento.Single(t => t.nombre == tipo.Nombre);
                    ti.codigo = tipo.Codigo;
                    ti.descripcion = tipo.Descripcion;
                    ti.activo = tipo.Activo;
                    tipoPro.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EliminarTipoAlimentos(TipoAlimentoClase tipo)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {
                try
                {
                    TipoAlimento ti = tipoPro.TipoAlimento.Single(t => t.codigo == tipo.Codigo);
                    tipoPro.TipoAlimento.Remove(ti);
                    tipoPro.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public List<InfoAlimentos> ListarInfoAlimentos()
        {
            using (IntegracionEntities su = new IntegracionEntities())
            {
                return su.Alimento.Where(s=>s.activo==1).Select(s => new InfoAlimentos
                {
                    NombreProveedor = s.Sucursal1.Proveedor1.nombre,
                    CorreoProveedor = s.Sucursal1.Proveedor1.correo,
                    TelefonoProveedor = s.Sucursal1.Proveedor1.telefono,
                    RutSucursal = s.Sucursal1.rut,
                    ComunaSucursal = s.Sucursal1.Comuna1.nombre,
                    ProvinciaSucursal = s.Sucursal1.Comuna1.Provincia1.nombre,
                    DireccionSucursal = s.Sucursal1.direccion,
                    TelefonoSucursal = s.Sucursal1.telefono,
                    latitud = s.Sucursal1.latitud,
                    longitud = s.Sucursal1.longitud,
                    CategoriaProducto = s.Categoria.nombre,
                    TipoProducto = s.TipoAlimento1.nombre,
                    NombreProducto = s.nombre,
                    foto = "http://drive.google.com/uc?export=view&id=" + s.foto,
                    fecha_elaboracionProducto = s.fecha_elaboracion,
                    fecha_vencimientoProducto = s.fecha_vencimiento,
                    DescripcionProducto = s.descripcion,
                    stockProducto = s.stock,
                    PrecioProducto = s.precio
                }).ToList();
            };
        }

        public List<TipoAlimentoClase> ListarTipoAlimentos()
        {
            using (IntegracionEntities su = new IntegracionEntities())
            {
                return su.TipoAlimento.Select(s => new TipoAlimentoClase
                {
                    Codigo = s.codigo,
                    Nombre = s.nombre,
                    Descripcion = s.descripcion,
                    Activo = s.activo
                }).ToList();
            };
        }

        public List<DetalleAlimentoClase> ListarDetalleAlimentos()
        {
            using (IntegracionEntities su = new IntegracionEntities())
            {
                return su.DetalleAlimento.Select(s => new DetalleAlimentoClase
                {
                    codigo = s.codigo,
                    categoria = s.categoria,
                    producto = s.alimento,
                    tipoProducto = s.tipoAlimento,
                    activo = s.activo
                }).ToList();
            };
        }

        public CategoriaClase BuscarCategoriaAlimentos(string codigo)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {
                decimal c = decimal.Parse(codigo);
                return tipoPro.Categoria.Where(p => p.codigo == c).Select(p => new CategoriaClase
                {
                    Codigo = p.codigo,
                    Nombre = p.nombre,
                    Descripcion = p.descripcion,
                    Activo = p.activo
                }).First();
            };
        }

        public bool AgregarCategoriaAlimentos(CategoriaClase cat)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {
                try
                {
                    Categoria t = new Categoria();
                    t.nombre = cat.Nombre;
                    t.descripcion = cat.Descripcion;
                    t.activo = 1;
                    tipoPro.Categoria.Add(t);
                    tipoPro.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EditarCategoriaAlimentos(CategoriaClase cat)
        {
            throw new NotImplementedException();
        }

        public bool EliminarCategoriaAlimentos(CategoriaClase cat)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {
                try
                {
                    Categoria ti = tipoPro.Categoria.Single(t => t.codigo == cat.Codigo);
                    tipoPro.Categoria.Remove(ti);
                    tipoPro.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public List<DatosBancariosClase> ListarDatosBancarios()
        {
            using (IntegracionEntities su = new IntegracionEntities())
            {
                return su.DatosBancarios.Select(s => new DatosBancariosClase
                {
                    Codigo = s.codigo,
                    Banco = s.Banco,
                    NombreBanco = s.Banco1.nombre,
                    NumeroCuenta = s.numeroCuenta,
                    NombreSucursal = s.Sucursal1.Proveedor1.nombre + " " + s.Sucursal1.rut,
                    Sucursal = s.Sucursal,
                    TipoCuenta = s.TipoCuenta,
                    NombreTipo = s.TipoCuenta1.nombre,
                    Activo = s.activo
                }).ToList();
            };
        }

        public DatosBancariosClase BuscarDatosBancarios(string codigo)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {
                decimal c = decimal.Parse(codigo);
                return tipoPro.DatosBancarios.Where(p => p.codigo == c).Select(p => new DatosBancariosClase
                {
                    Codigo = p.codigo,
                    Banco = p.Banco,
                    NumeroCuenta = p.numeroCuenta,
                    Sucursal = p.Sucursal,
                    TipoCuenta = p.TipoCuenta,
                    NombreBanco = p.Banco1.nombre,
                    NombreSucursal = p.Sucursal1.Proveedor1.nombre + " " + p.Sucursal1.rut,
                    NombreTipo = p.TipoCuenta1.nombre,
                    Activo = p.activo
                }).First();
            };
        }

        public bool AgregarDatosBancarios(DatosBancariosClase ban)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {
                try
                {
                    DatosBancarios t = new DatosBancarios();
                    t.numeroCuenta = ban.NumeroCuenta;
                    t.Sucursal = ban.Sucursal;
                    t.TipoCuenta = ban.TipoCuenta;
                    t.Banco = ban.Banco;
                    t.activo = 1;
                    tipoPro.DatosBancarios.Add(t);
                    tipoPro.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }


        public bool EliminarDatosBancarios(DatosBancariosClase ban)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {
                try
                {
                    DatosBancarios ti = tipoPro.DatosBancarios.Single(t => t.codigo == ban.Codigo);
                    tipoPro.DatosBancarios.Remove(ti);
                    tipoPro.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public List<TipoCuentaClase> ListarTipoCuentas()
        {
            using (IntegracionEntities su = new IntegracionEntities())
            {
                return su.TipoCuenta.Select(s => new TipoCuentaClase
                {
                    Codigo = s.codigo,
                    Nombre = s.nombre,
                    Activo = s.activo
                }).ToList();
            };
        }

        public ProveedorClase BuscarProveedor(string rut)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {

                return tipoPro.Proveedor.Where(p => p.rut == rut).Select(p => new ProveedorClase
                {
                    Codigo = p.codigo,
                    Rut = p.rut,
                    Correo = p.correo,
                    Nombre = p.nombre,
                    Pass = p.pass,

                    Telefono = p.telefono,
                    Usuario = p.usuario,
                    Activo = p.activo
                }).First();
            };
        }

        public bool AgregarProveedor(ProveedorClase pro)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {
                try
                {
                    Proveedor t = new Proveedor();
                    t.usuario = pro.Usuario;
                    t.pass = pro.Pass;
                    t.rut = pro.Rut;
                    t.correo = pro.Correo;
                    t.nombre = pro.Nombre;
                    t.telefono = pro.Telefono;
                    t.activo = 1;
                    tipoPro.Proveedor.Add(t);
                    tipoPro.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EditarProveedor(ProveedorClase pro)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {
                try
                {
                    Proveedor t = tipoPro.Proveedor.Single(ti => ti.codigo == pro.Codigo);
                    t.usuario = pro.Usuario;
                    t.rut = pro.Rut;
                    t.pass = pro.Pass;
                    t.correo = pro.Correo;
                    t.nombre = pro.Nombre;
                    t.telefono = pro.Telefono;
                    tipoPro.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EliminarProveedor(ProveedorClase pro)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {
                try
                {
                    Proveedor ti = tipoPro.Proveedor.Single(t => t.codigo == pro.Codigo);
                    tipoPro.Proveedor.Remove(ti);
                    tipoPro.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public SucursalClase BuscarSucursal(string rut)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {

                return tipoPro.Sucursal.Where(p => p.rut == rut).Select(p => new SucursalClase
                {
                    Codigo = p.codigo,
                    Rut = p.rut,
                    Telefono = p.telefono,
                    Comuna = p.comuna,
                    Direccion = p.direccion,
                    Latitud = p.latitud,
                    Longitud = p.longitud,
                    NombreProveedor = p.Proveedor1.nombre,
                    CP = p.Proveedor1.codigo,
                    NombreComuna = p.Comuna1.nombre,
                    Proveedor = p.proveedor,
                    Activo = p.activo
                }).First();
            };
        }

        public bool AgregarSucursal(SucursalClase suc)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {
                try
                {
                    Sucursal t = new Sucursal();

                    t.rut = suc.Rut;
                    t.direccion = suc.Direccion;
                    t.comuna = suc.Comuna;
                    t.latitud = suc.Latitud;
                    t.longitud = suc.Longitud;
                    t.proveedor = suc.Proveedor;
                    t.telefono = suc.Telefono;
                    t.activo = 1;
                    tipoPro.Sucursal.Add(t);
                    tipoPro.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EditarSucursal(SucursalClase suc)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {
                try
                {
                    Sucursal t = tipoPro.Sucursal.Single(ti => ti.codigo == suc.Codigo);

                    t.direccion = suc.Direccion;
                    t.comuna = suc.Comuna;
                    t.latitud = suc.Latitud;
                    t.longitud = suc.Longitud;
                    t.proveedor = suc.Proveedor;
                    t.telefono = suc.Telefono;
                    tipoPro.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool EliminarSucursal(SucursalClase suc)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {
                try
                {
                    Sucursal t = tipoPro.Sucursal.Single(ti => ti.codigo == suc.Codigo);
                    tipoPro.Sucursal.Remove(t);
                    tipoPro.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }
        public List<SucursalClase> ListarSucursalesC(string codigo)
        {
            using (IntegracionEntities su = new IntegracionEntities())
            {
                decimal c = decimal.Parse(codigo);

                return su.Sucursal.Where(suc => suc.Proveedor1.codigo == c).Select(s => new SucursalClase
                {
                    Codigo = s.codigo,
                    NombreProveedor = s.Proveedor1.nombre,
                    CP = s.Proveedor1.codigo,
                    Rut = s.rut,
                    Comuna = s.comuna,
                    Direccion = s.direccion,
                    NombreComuna = s.Comuna1.nombre,
                    Proveedor = s.proveedor,
                    Telefono = s.telefono,
                    Latitud = s.latitud,
                    Longitud = s.longitud,
                    Activo = s.activo
                }).ToList();
            };
        }

      
       

        

        public List<DatosBancariosClase> ListarDatosBancariosC(string codigo)
        {
            using (IntegracionEntities su = new IntegracionEntities())
            {
                decimal c = decimal.Parse(codigo);

                return su.DatosBancarios.Where(suc => suc.Sucursal1.codigo == c).Select(s => new DatosBancariosClase
                {
                    Codigo = s.codigo,
                    Banco = s.Banco,
                    NombreBanco = s.Banco1.nombre,
                    NumeroCuenta = s.numeroCuenta,
                    NombreSucursal = s.Sucursal1.Proveedor1.nombre + " " + s.Sucursal1.rut,
                    ProveedorC = s.Sucursal1.proveedor,
                    Sucursal = s.Sucursal,
                    TipoCuenta = s.TipoCuenta,
                    NombreTipo = s.TipoCuenta1.nombre,
                    Activo = s.activo
                }).ToList();
            };
        }

        public List<AlimentoClase> ListarAlimentosC(string codigo)
        {
            using (IntegracionEntities pro = new IntegracionEntities())
            {
                decimal c = decimal.Parse(codigo);
                return pro.Alimento.Where(a => a.Sucursal1.codigo == c).Select(p => new AlimentoClase
                {
                    Codigo = p.Codigo,
                    Nombre = p.nombre,
                    DatosSucursal = p.Sucursal1.Proveedor1.nombre + " " + p.Sucursal1.rut,
                    Descripcion = p.descripcion,
                    Precio = p.precio,
                    Foto = "http://drive.google.com/uc?export=view&id=" + p.foto,
                    CategoriaAlimento = p.CategoriaAlimento,
                    TipoAlimento = p.TipoAlimento,
                    ProveedorC = p.Sucursal1.proveedor,
                    Fecha_elaboracion = p.fecha_elaboracion,
                    Fecha_vencimiento = p.fecha_vencimiento,
                    DatosCategoria = p.Categoria.nombre,
                    DatosTipo = p.TipoAlimento1.nombre,
                    Stock = p.stock,
                    Sucursal = p.Sucursal,
                    Activo = p.activo
                }).ToList();
            };
        }

        public ProveedorClase Login(string user, string pass)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {

                return tipoPro.Proveedor.Where(p => p.usuario == user && p.pass == pass).Select(p => new ProveedorClase
                {
                    Codigo = p.codigo,
                    Rut = p.rut,
                    Correo = p.correo,
                    Nombre = p.nombre,
                    Pass = p.pass,
                    Telefono = p.telefono,
                    Usuario = p.usuario,
                    Activo = p.activo
                }).First();
            };
        }

        public List<ProveedorClase> ListarProveedorC(string codigo)
        {
            using (IntegracionEntities pro = new IntegracionEntities())
            {
                decimal c = decimal.Parse(codigo);
                return pro.Proveedor.Where(pr => pr.codigo == c).Select(p => new ProveedorClase
                {
                    Codigo = p.codigo,
                    Rut = p.rut,
                    Correo = p.correo,
                    Nombre = p.nombre,
                    Pass = p.pass,
                    Telefono = p.telefono,
                    Usuario = p.usuario,
                    Activo = p.activo
                }).ToList();
            };
        }

        private bool Desactivar(string codigo)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {
                try
                {
                    decimal c = decimal.Parse(codigo);
                    Alimento ti = tipoPro.Alimento.Single(t => t.Codigo == c);
                    ti.activo = 0;
                    tipoPro.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool Stock(string codigo, string cantidad)
        {
            using (IntegracionEntities tipoPro = new IntegracionEntities())
            {
                try
                {
                    decimal c = decimal.Parse(codigo);
                    decimal cant = decimal.Parse(cantidad);
                    Alimento ti = tipoPro.Alimento.Single(t => t.Codigo == c);
                    decimal s= ti.stock - cant;
                    if (s >= 1)
                    {
                        ti.stock = ti.stock - cant;
                        tipoPro.SaveChanges();
                        return true;
                    }
                    else if(s<=0)
                    {
                        ti.stock = 0;
                        tipoPro.SaveChanges();
                        Desactivar(codigo);
                        return true;

                    }
                    return false;
                }
                catch
                {
                    return false;
                }
            };
        }
            public bool StockS(string codigo, string cantidad)
            {
                using (IntegracionEntities tipoPro = new IntegracionEntities())
                {
                    try
                    {
                        decimal c = decimal.Parse(codigo);
                        decimal cant = decimal.Parse(cantidad);
                        Alimento ti = tipoPro.Alimento.Single(t => t.Codigo == c);
                        
                            ti.stock = ti.stock + cant;
                            tipoPro.SaveChanges();
                            return true;
                        
                    }
                    catch
                    {
                        return false;
                    }
                };
            }
    }
}
