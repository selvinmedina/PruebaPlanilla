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
    
    public partial class tbDeduccionInstitucionFinanciera
    {
        public int deif_IdDeduccionInstFinanciera { get; set; }
        public Nullable<int> emp_Id { get; set; }
        public Nullable<int> insf_IdInstitucionFinanciera { get; set; }
        public Nullable<decimal> deif_Monto { get; set; }
        public string deif_Comentarios { get; set; }
        public Nullable<int> cde_IdDeducciones { get; set; }
        public Nullable<int> deif_UsuarioCrea { get; set; }
        public Nullable<System.DateTime> deif_FechaCrea { get; set; }
        public Nullable<int> deif_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> deif_FechaModifica { get; set; }
    
        public virtual tbCatalogoDeDeducciones tbCatalogoDeDeducciones { get; set; }
        public virtual tbInstitucionesFinancieras tbInstitucionesFinancieras { get; set; }
        public virtual tbEmpleados tbEmpleados { get; set; }
    }
}
