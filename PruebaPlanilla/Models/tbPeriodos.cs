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
    
    public partial class tbPeriodos
    {
        public tbPeriodos()
        {
            this.tbHistorialDePago = new HashSet<tbHistorialDePago>();
        }
    
        public int peri_IdPeriodo { get; set; }
        public string peri_DescripPeriodo { get; set; }
        public Nullable<int> peri_UsuarioCrea { get; set; }
        public Nullable<System.DateTime> peri_FechaCrea { get; set; }
        public Nullable<int> peri_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> peri_FechaModifica { get; set; }
    
        public virtual ICollection<tbHistorialDePago> tbHistorialDePago { get; set; }
    }
}
