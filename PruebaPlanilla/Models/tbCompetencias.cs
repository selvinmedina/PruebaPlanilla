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
    
    public partial class tbCompetencias
    {
        public int comp_Id { get; set; }
        public string comp_Descripcion { get; set; }
        public int comp_UsuarioCrea { get; set; }
        public System.DateTime comp_FechaCrea { get; set; }
        public Nullable<int> comp_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> comp_FechaModifica { get; set; }
    }
}
