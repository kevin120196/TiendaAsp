using MVCWEB.Models;
using MVCWEB.Models.GuanteModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DataSet1 vista = new DataSet1();
            List<guanteModel> lst = null;
            using (TiendaOnlineEntities1 db=new TiendaOnlineEntities1())
            {
                lst = (from d in db.Guante_View.OrderBy(f=>f.NombreMarca) 
                           select new guanteModel
                           {
                               imagenGuante=d.ImagenGuante,
                               Descripcion=d.Descripcion,
                               Talla=d.Talla,
                               NombreCategoria=d.NombreCategoria,
                               NombreMarca=d.NombreMarca,
                               NombreModelo=d.NombreModelo,
                               NombreColores=d.NombreColores
                           }
                       ).ToList();
            }
            return View(lst);
        }

        public ActionResult GuanteArticulo()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}