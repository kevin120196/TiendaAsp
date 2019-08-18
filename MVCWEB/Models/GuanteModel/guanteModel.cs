using MVCWEB.Models.CategoriaModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWEB.Models.GuanteModel
{
    public class guanteModel
    {
        public int idGuante { get; set; }
        public string imagenGuante { get; set; }
        [Display(Name = "Imagen")]
        public HttpPostedFileBase ImageFile { get; set; }

        public string Descripcion { get; set; }

        public int? Talla { get; set; }

        public string NombreCategoria { get; set; }
        public Nullable<int> idCategoria { get; set; }
        [NotMapped]
        public List<Categoria> CategoriaList { get; set; }
        public string NombreModelo { get; set; }
        public Nullable<int> idModelo { get; set; }
        [NotMapped]
        public List<Modelo> ModeloList { get; set; }
        public string NombreMarca { get; set; }
        public Nullable<int> idMarca { get; set; }
        [NotMapped]
        public List<Marca> MarcaList { get; set; }
        public string NombreColores { get; set; }
        public Nullable<int> idColores { get; set; }
        [NotMapped]
        public List<Colores> ColoresList { get; set; }
    }
}