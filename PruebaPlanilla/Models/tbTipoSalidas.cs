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
    
    public partial class tbTipoSalidas
    {
        public int tsal_id { get; set; }
        public Nullable<int> rdes_id { get; set; }
        public Nullable<int> rren_id { get; set; }
        public string tsal_descripcion { get; set; }
        public int tsal_usuariocrea { get; set; }
        public System.DateTime tsal_fechacrea { get; set; }
        public Nullable<int> tsal_usuariomodifica { get; set; }
        public Nullable<System.DateTime> tsal_fechamodifica { get; set; }
    }
}
