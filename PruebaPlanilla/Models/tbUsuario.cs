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
    
    public partial class tbUsuario
    {
        public tbUsuario()
        {
            this.tbAccesoRol = new HashSet<tbAccesoRol>();
            this.tbAccesoRol1 = new HashSet<tbAccesoRol>();
            this.tbObjeto = new HashSet<tbObjeto>();
            this.tbObjeto1 = new HashSet<tbObjeto>();
            this.tbRol = new HashSet<tbRol>();
            this.tbRol1 = new HashSet<tbRol>();
            this.tbRolesUsuario = new HashSet<tbRolesUsuario>();
            this.tbRolesUsuario1 = new HashSet<tbRolesUsuario>();
            this.tbRolesUsuario2 = new HashSet<tbRolesUsuario>();
        }
    
        public int usu_Id { get; set; }
        public string usu_NombreUsuario { get; set; }
        public byte[] usu_Password { get; set; }
        public string usu_Nombres { get; set; }
        public string usu_Apellidos { get; set; }
        public string usu_Correos { get; set; }
        public Nullable<bool> usu_EsActivo { get; set; }
        public string usu_RazonInactivo { get; set; }
        public Nullable<bool> usu_EsAdministrador { get; set; }
        public Nullable<byte> usu_SesionesValidas { get; set; }
        public Nullable<int> suc_Id { get; set; }
        public Nullable<short> emp_Id { get; set; }
    
        public virtual ICollection<tbAccesoRol> tbAccesoRol { get; set; }
        public virtual ICollection<tbAccesoRol> tbAccesoRol1 { get; set; }
        public virtual ICollection<tbObjeto> tbObjeto { get; set; }
        public virtual ICollection<tbObjeto> tbObjeto1 { get; set; }
        public virtual ICollection<tbRol> tbRol { get; set; }
        public virtual ICollection<tbRol> tbRol1 { get; set; }
        public virtual ICollection<tbRolesUsuario> tbRolesUsuario { get; set; }
        public virtual ICollection<tbRolesUsuario> tbRolesUsuario1 { get; set; }
        public virtual ICollection<tbRolesUsuario> tbRolesUsuario2 { get; set; }
    }
}
