﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GLOBALNET.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CajabdEntities : DbContext
    {
        public CajabdEntities()
            : base("name=CajabdEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<boleta_pago> boleta_pago { get; set; }
        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<numero> numero { get; set; }
        public virtual DbSet<tienda> tienda { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
    }
}
