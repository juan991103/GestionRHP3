﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionRH.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MaitenanceModuleContainer : DbContext
    {
        public MaitenanceModuleContainer()
            : base("name=MaitenanceModuleContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Mantenimiento_Empleado> Mantenimiento_EmpleadoSet { get; set; }
        public virtual DbSet<Mantenimiento_Departamento> Mantenimiento_DepartamentoSet { get; set; }
        public virtual DbSet<Mantenimiento_Cargo> Mantenimiento_CargoSet { get; set; }
        public virtual DbSet<Process_nominas> Process_nominasSet { get; set; }
        public virtual DbSet<Process_salida_empleado> Process_salida_empleadoSet { get; set; }
        public virtual DbSet<Process_Vacaciones> Process_VacacionesSet { get; set; }
        public virtual DbSet<Process_licencias> Process_licenciasSet { get; set; }
        public virtual DbSet<Process_Permisos> Process_PermisosSet { get; set; }
    }
}
