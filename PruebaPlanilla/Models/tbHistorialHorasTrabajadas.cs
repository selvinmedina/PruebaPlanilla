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
    
    public partial class tbHistorialHorasTrabajadas
    {
        public int htra_Id { get; set; }
        public int emp_Id { get; set; }
        public int tiho_id { get; set; }
        public int jor_id { get; set; }
        public int htra_Cantidadhoras { get; set; }
        public Nullable<System.DateTime> htra_Fecha { get; set; }
        public int htra_UsuarioCrea { get; set; }
        public System.DateTime htra_FechaCrea { get; set; }
        public Nullable<int> htra_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> htra_FechaModifica { get; set; }
    }
}
