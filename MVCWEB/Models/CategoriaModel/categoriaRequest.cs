using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWEB.Models.CategoriaModel
{
    public class categoriaRequest
    {
        [Required]
        [DataType(DataType.Text)]
        [StringLength(100,ErrorMessage ="La categoria ingresada exede la longitud establecida")]
        [Display(Name ="Nombre de Categoria")]
        public string NombreCategoria { get; set; }
    }

    public class editCategoria
    {

        public int idCategoria { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "La categoria ingresada exede la longitud establecida")]
        [Display(Name = "Nombre de Categoria")]
        public string NombreCategoria { get; set; }

    }
}