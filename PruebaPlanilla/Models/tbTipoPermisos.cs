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
    
    public partial class tbTipoPermisos
    {
        public int tper_Id { get; set; }
        public string tper_Descripcion { get; set; }
        public int tper_UsuarioCrea { get; set; }
        public System.DateTime tper_FechaCrea { get; set; }
        public Nullable<int> tper_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> tper_FechaModifica { get; set; }
    }
}
