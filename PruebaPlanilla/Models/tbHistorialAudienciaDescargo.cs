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
    
    public partial class tbHistorialAudienciaDescargo
    {
        public int aude_Id { get; set; }
        public int emp_Id { get; set; }
        public string aude_Descripcion { get; set; }
        public System.DateTime aude_Fechaaudiencia { get; set; }
        public Nullable<bool> aude_Testigo { get; set; }
        public string aude_Direccionarchivo { get; set; }
        public int aude_UsuarioCrea { get; set; }
        public System.DateTime aude_Fechacrea { get; set; }
        public Nullable<int> aude_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> aude_Fechamodifica { get; set; }
    }
}