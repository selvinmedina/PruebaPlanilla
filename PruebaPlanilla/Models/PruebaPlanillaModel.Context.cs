﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebaPlanilla.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PlanillaEntities : DbContext
    {
        public PlanillaEntities()
            : base("name=PlanillaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tbAccesoRol> tbAccesoRol { get; set; }
        public DbSet<tbObjeto> tbObjeto { get; set; }
        public DbSet<tbRol> tbRol { get; set; }
        public DbSet<tbRolesUsuario> tbRolesUsuario { get; set; }
        public DbSet<tbUsuario> tbUsuario { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<tbCatalogoDeDeducciones> tbCatalogoDeDeducciones { get; set; }
        public DbSet<tbCatalogoDeIngresos> tbCatalogoDeIngresos { get; set; }
        public DbSet<tbCatalogoDePlanillas> tbCatalogoDePlanillas { get; set; }
        public DbSet<tbDeduccionesExtraordinarias> tbDeduccionesExtraordinarias { get; set; }
        public DbSet<tbDeduccionInstitucionFinanciera> tbDeduccionInstitucionFinanciera { get; set; }
        public DbSet<tbEmpleadoBonos> tbEmpleadoBonos { get; set; }
        public DbSet<tbEmpleadoComisiones> tbEmpleadoComisiones { get; set; }
        public DbSet<tbHistorialDeduccionPago> tbHistorialDeduccionPago { get; set; }
        public DbSet<tbHistorialDeIngresosPago> tbHistorialDeIngresosPago { get; set; }
        public DbSet<tbHistorialDePago> tbHistorialDePago { get; set; }
        public DbSet<tbInstitucionesFinancieras> tbInstitucionesFinancieras { get; set; }
        public DbSet<tbPeriodos> tbPeriodos { get; set; }
        public DbSet<tbRamaActividad> tbRamaActividad { get; set; }
        public DbSet<tbSalarioPorHora> tbSalarioPorHora { get; set; }
        public DbSet<tbTechosDeducciones> tbTechosDeducciones { get; set; }
        public DbSet<tbTipoDeduccion> tbTipoDeduccion { get; set; }
        public DbSet<tbTipoPlanillaDetalleDeduccion> tbTipoPlanillaDetalleDeduccion { get; set; }
        public DbSet<tbTipoPlanillaDetalleIngreso> tbTipoPlanillaDetalleIngreso { get; set; }
        public DbSet<tbAreas> tbAreas { get; set; }
        public DbSet<tbCargos> tbCargos { get; set; }
        public DbSet<tbCompetencias> tbCompetencias { get; set; }
        public DbSet<tbCompetenciasPersona> tbCompetenciasPersona { get; set; }
        public DbSet<tbCompetenciasRequisicion> tbCompetenciasRequisicion { get; set; }
        public DbSet<tbDepartamentos> tbDepartamentos { get; set; }
        public DbSet<tbEmpleados> tbEmpleados { get; set; }
        public DbSet<tbEmpleadosAreas> tbEmpleadosAreas { get; set; }
        public DbSet<tbEmpresas> tbEmpresas { get; set; }
        public DbSet<tbEquipoEmpleados> tbEquipoEmpleados { get; set; }
        public DbSet<tbEquipoTrabajo> tbEquipoTrabajo { get; set; }
        public DbSet<tbFaseSeleccion> tbFaseSeleccion { get; set; }
        public DbSet<tbFasesReclutamiento> tbFasesReclutamiento { get; set; }
        public DbSet<tbHabilidades> tbHabilidades { get; set; }
        public DbSet<tbHabilidadesPersona> tbHabilidadesPersona { get; set; }
        public DbSet<tbHabilidadesRequisicion> tbHabilidadesRequisicion { get; set; }
        public DbSet<tbHistorialAmonestaciones> tbHistorialAmonestaciones { get; set; }
        public DbSet<tbHistorialAudienciaDescargo> tbHistorialAudienciaDescargo { get; set; }
        public DbSet<tbHistorialCargos> tbHistorialCargos { get; set; }
        public DbSet<tbHistorialContrataciones> tbHistorialContrataciones { get; set; }
        public DbSet<tbHistorialHorasTrabajadas> tbHistorialHorasTrabajadas { get; set; }
        public DbSet<tbHistorialincapacidades> tbHistorialincapacidades { get; set; }
        public DbSet<tbHistorialLiquidaciones> tbHistorialLiquidaciones { get; set; }
        public DbSet<tbHistorialPermisos> tbHistorialPermisos { get; set; }
        public DbSet<tbHistorialRefrendamientos> tbHistorialRefrendamientos { get; set; }
        public DbSet<tbHistorialSalidas> tbHistorialSalidas { get; set; }
        public DbSet<tbHistorialVacaciones> tbHistorialVacaciones { get; set; }
        public DbSet<tbHorarios> tbHorarios { get; set; }
        public DbSet<tbIdiomaPersona> tbIdiomaPersona { get; set; }
        public DbSet<tbidiomas> tbidiomas { get; set; }
        public DbSet<tbIdiomasRequisicion> tbIdiomasRequisicion { get; set; }
        public DbSet<tbJornadas> tbJornadas { get; set; }
        public DbSet<tbPersonas> tbPersonas { get; set; }
        public DbSet<tbPrestaciones> tbPrestaciones { get; set; }
        public DbSet<tbRazonDespidos> tbRazonDespidos { get; set; }
        public DbSet<tbRazonRenuncias> tbRazonRenuncias { get; set; }
        public DbSet<tbRequisiciones> tbRequisiciones { get; set; }
        public DbSet<tbRequisicionPersonal> tbRequisicionPersonal { get; set; }
        public DbSet<tbSeleccionCandidatos> tbSeleccionCandidatos { get; set; }
        public DbSet<tbSucursales> tbSucursales { get; set; }
        public DbSet<tbSueldos> tbSueldos { get; set; }
        public DbSet<tbTipoAmonestaciones> tbTipoAmonestaciones { get; set; }
        public DbSet<tbTipoHoras> tbTipoHoras { get; set; }
        public DbSet<tbTipoIncapacidades> tbTipoIncapacidades { get; set; }
        public DbSet<tbTipoMonedas> tbTipoMonedas { get; set; }
        public DbSet<tbTipoPermisos> tbTipoPermisos { get; set; }
        public DbSet<tbTipoSalidas> tbTipoSalidas { get; set; }
        public DbSet<tbTitulos> tbTitulos { get; set; }
        public DbSet<tbTitulosPersona> tbTitulosPersona { get; set; }
        public DbSet<tbTitulosRequisicion> tbTitulosRequisicion { get; set; }
        public DbSet<tbVacaciones> tbVacaciones { get; set; }
    }
}