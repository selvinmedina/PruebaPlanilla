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
    
    public partial class tbAccesoRol
    {
        public int acrol_Id { get; set; }
        public Nullable<int> rol_Id { get; set; }
        public Nullable<int> obj_Id { get; set; }
        public Nullable<int> acrol_UsuarioCrea { get; set; }
        public Nullable<System.DateTime> acrol_FechaCrea { get; set; }
        public Nullable<int> acrol_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> acrol_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbObjeto tbObjeto { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbRol tbRol { get; set; }
    }
}
