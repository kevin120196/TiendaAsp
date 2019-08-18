using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWEB.Models.ViewModels
{
    public class UserViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "El nombre pasa los limites de caracteres establecidos")]
        [Display(Name = "Nombre de Usuario")]
        public string nombreUser { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100, ErrorMessage = "El correo pasa los limites de caracteres establecidos")]
        [Display(Name = "Correo Electronico")]
        public string email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "La contraseña pasa los limites de caracteres establecidos")]
        [Display(Name = "Contraseña")]
        public string password { get; set; }

    }

    public class EditUserViewModel
    {
        public int idUser { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "El nombre de usuario pasa los limites de caracteres establecidos")]
        [Display(Name = "Nombre de Usuario")]
        public string NombreUsuario { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100, ErrorMessage = "El correo pasa los limites de caracteres establecidos")]
        [Display(Name = "Correo Electronico")]
        public string email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Contraseña")]
        public string password { get; set; }
    }
}