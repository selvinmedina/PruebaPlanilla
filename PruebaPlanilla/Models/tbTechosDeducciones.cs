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
    
    public partial class tbTechosDeducciones
    {
        public int tede_Id { get; set; }
        public Nullable<decimal> tede_RangoInicial { get; set; }
        public Nullable<decimal> tede_RangoFinal { get; set; }
        public Nullable<int> tede_Porcentaje { get; set; }
        public Nullable<int> cde_IdDeducciones { get; set; }
        public Nullable<int> tede_UsuarioCrea { get; set; }
        public Nullable<System.DateTime> tede_FechaCrea { get; set; }
        public Nullable<int> tede_UsuarioModifica { get; set; }
        public Nullable<int> tede_FechaModifica { get; set; }
    
        public virtual tbCatalogoDeDeducciones tbCatalogoDeDeducciones { get; set; }
    }
}
