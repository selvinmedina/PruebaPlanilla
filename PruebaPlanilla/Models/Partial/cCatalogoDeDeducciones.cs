using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PruebaPlanilla.Models
{
    [MetadataType(typeof(cCatalogoDeDeducciones))]
    public partial class tbCatalogoDeDeducciones
    {
    }

    public class cCatalogoDeDeducciones
    {
        [Display(Name = "ID")]
        public int cde_IdDeducciones { get; set; }

        [Display(Name = "Deducción")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(30, ErrorMessage = "Excedió el máximo de caracteres permitidos.")]
        public string cde_DescripcionDeduccion { get; set; }

        [Display(Name = "ID Tipo de ducción")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public Nullable<int> tde_IdTipoDedu { get; set; }

        [Display(Name = "% colaborador")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public Nullable<decimal> cde_PorcentajeColaborador { get; set; }

        [Display(Name = "% empresa")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public Nullable<decimal> cde_PorcentajeEmpresa { get; set; }

        [Display(Name = "Usuario crea")]
        public Nullable<int> cde_UsuarioCrea { get; set; }
        [Display(Name = "Fecha creación")]
        public Nullable<System.DateTime> cde_FechaCrea { get; set; }
        [Display(Name = "Usuario que modificó")]
        public Nullable<int> cde_UsuarioModifica { get; set; }
        [Display(Name = "Fecha modificación")]
        public Nullable<System.DateTime> cde_FechaModifica { get; set; }
    }
}