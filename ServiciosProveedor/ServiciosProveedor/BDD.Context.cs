﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiciosProveedor
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IntegracionEntities : DbContext
    {
        public IntegracionEntities()
            : base("name=IntegracionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alimento> Alimento { get; set; }
        public virtual DbSet<Banco> Banco { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Comuna> Comuna { get; set; }
        public virtual DbSet<DatosBancarios> DatosBancarios { get; set; }
        public virtual DbSet<DetalleAlimento> DetalleAlimento { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Saldo> Saldo { get; set; }
        public virtual DbSet<Sucursal> Sucursal { get; set; }
        public virtual DbSet<TipoAlimento> TipoAlimento { get; set; }
        public virtual DbSet<TipoCuenta> TipoCuenta { get; set; }
    }
}
