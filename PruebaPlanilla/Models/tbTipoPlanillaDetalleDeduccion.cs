//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tbTipoPlanillaDetalleDeduccion
    {
        public tbTipoPlanillaDetalleDeduccion()
        {
            this.tbHistorialDeduccionPago = new HashSet<tbHistorialDeduccionPago>();
        }
    
        public int tpdd_IdPlanillaDetDeduccion { get; set; }
        public Nullable<int> cpla_IdPlanilla { get; set; }
        public Nullable<int> cde_IdDeducciones { get; set; }
        public Nullable<int> tpdd_UsuarioCrea { get; set; }
        public Nullable<System.DateTime> tpdd_FechaCrea { get; set; }
        public Nullable<int> tpdd_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> tpdd_FechaModifica { get; set; }
    
        public virtual tbCatalogoDeDeducciones tbCatalogoDeDeducciones { get; set; }
        public virtual tbCatalogoDePlanillas tbCatalogoDePlanillas { get; set; }
        public virtual ICollection<tbHistorialDeduccionPago> tbHistorialDeduccionPago { get; set; }
    }
}
