using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWEB.Models.ColorModel
{
    public class colorRequest
    {
        [Required]
        [DataType(DataType.Text)]
        [StringLength(20, ErrorMessage = "El color ingresado exede la longitud establecida")]
        [Display(Name = "Nombre de Color")]
        public string NombreColor
        {
            get; set;
        }
    }

    public class colorEditRequest
    {

        public int idColor { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(20, ErrorMessage = "El color ingresado exede la longitud establecida")]
        [Display(Name = "Nombre de Color")]
        public string NombreColor
        {
            get; set;
        }

    }
}