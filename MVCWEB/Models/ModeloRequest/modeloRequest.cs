using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWEB.Models.ModeloRequest
{
    public class modeloRequest
    {
        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "El Modelo ingresado exede la longitud establecida")]
        [Display(Name = "Nombre del Modelo")]
        public string NombreModelo
        {
            get; set;
        }
    }

    public class modeloRequestEdit
    {

        public int idModelo { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "El Modelo ingresado exede la longitud establecida")]
        [Display(Name = "Nombre del Modelo")]
        public string NombreModelo
        {
            get; set;
        }
    }

}