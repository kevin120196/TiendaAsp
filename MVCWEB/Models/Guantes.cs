//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCWEB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Guantes
    {
        public int idGuante { get; set; }
        public string ImagenGuante { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> Talla { get; set; }
        public Nullable<int> idMarca { get; set; }
        public Nullable<int> idModelo { get; set; }
        public Nullable<int> idCategoria { get; set; }
        public Nullable<int> idColores { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        public virtual Colores Colores { get; set; }
        public virtual Modelo Modelo { get; set; }
        public virtual Marca Marca { get; set; }
    }
}
