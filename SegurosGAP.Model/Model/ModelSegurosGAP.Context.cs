﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SegurosGAP.Model.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using SegurosGAP.Entities;

    public partial class DBSegurosGAPEntities : DbContext
    {
        public DBSegurosGAPEntities()
            : base("name=DBSegurosGAPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PolizasSeguro> PolizasSeguros { get; set; }
        public virtual DbSet<TiposCubrimiento> TiposCubrimientoes { get; set; }
        public virtual DbSet<TiposRiesgo> TiposRiesgoes { get; set; }
    }
}
