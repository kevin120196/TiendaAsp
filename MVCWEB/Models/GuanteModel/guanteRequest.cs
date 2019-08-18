using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCWEB.Models.GuanteModel
{
    public class guanteRequest
    {
        public int idGuante { get; set; }
        public string imagenGuante { get; set; }
        [Display(Name = "Imagen")]
        public HttpPostedFileBase ImageFile { get; set; }

        [Display(Name = "Descripcion")]
        [DataType(DataType.MultilineText)]
        public string Descripcion { get; set; }
        [DataType(DataType.Text)]
        public int? Talla { get; set; }
        [Display(Name = "Categoria")]
        public string NombreCategoria { get; set; }
        public Nullable<int> idCategoria { get; set; }
        [NotMapped]
        public List<Categoria> CategoriaList { get; set; }
        [Display(Name = "Modelo")]
        public string NombreModelo { get; set; }
        public Nullable<int> idModelo { get; set; }
        [NotMapped]
        public List<Modelo> ModeloList { get; set; }
        [Display(Name = "Marca")]
        public string NombreMarca { get; set; }
        public Nullable<int> idMarca { get; set; }
        [NotMapped]
        public List<Marca> MarcaList { get; set; }
        [Display(Name = "Colores")]
        public string NombreColores { get; set; }
        public Nullable<int> idColores { get; set; }
        [NotMapped]
        public List<Colores> ColoresList { get; set; }
    }

    public class guanteEdit {
        public int idGuante { get; set; }
        public string imagenGuante { get; set; }
        [Display(Name = "Imagen")]
        public HttpPostedFileBase ImageFile { get; set; }

        [Display(Name = "Descripcion")]
        [DataType(DataType.MultilineText)]
        public string Descripcion { get; set; }
        [DataType(DataType.Text)]
        public int? Talla { get; set; }
        [Display(Name = "Categoria")]
        public Nullable<int> idCategoria { get; set; }
        [NotMapped]
        public List<Categoria> CategoriaList { get; set; }
        [Display(Name = "Modelo")]
        public Nullable<int> idModelo { get; set; }
        [NotMapped]
        public List<Modelo> ModeloList { get; set; }
        [Display(Name = "Marca")]
        public Nullable<int> idMarca { get; set; }
        [NotMapped]
        public List<Marca> MarcaList { get; set; }
        [Display(Name = "Colores")]
        public Nullable<int> idColores { get; set; }
        [NotMapped]
        public List<Colores> ColoresList { get; set; }
    }
}