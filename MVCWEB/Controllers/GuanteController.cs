using MVCWEB.Clases;
using MVCWEB.Models;
using MVCWEB.Models.CategoriaModel;
using MVCWEB.Models.GuanteModel;
using MVCWEB.Models.MarcaModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVCWEB.Controllers
{
    public class GuanteController : Controller
    {
        // GET: Guante
        public ActionResult Index()
        {
            List<guanteModel> lst = null;
            using (TiendaOnlineEntities1 db=new TiendaOnlineEntities1())
            {
                lst = (from d in db.Guante_View  

                       select new guanteModel
                       {
                           idGuante = d.idGuante,
                           imagenGuante=d.ImagenGuante,
                           Descripcion=d.Descripcion,
                           Talla=d.Talla,
                            NombreCategoria=d.NombreCategoria,
                           NombreColores=d.NombreColores,
                           NombreMarca=d.NombreMarca,
                           NombreModelo=d.NombreModelo

                       }
                     ).ToList();
            }
            
            return View(lst);
        }

        // GET: Guante/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Guante/Create
        public ActionResult Create()
        {
            guanteRequest cat = new guanteRequest();
            using (TiendaOnlineEntities1 db=new TiendaOnlineEntities1())
            {
                cat.CategoriaList = db.Categoria.ToList<Categoria>();
                cat.ModeloList = db.Modelo.ToList<Modelo>();
                cat.MarcaList = db.Marca.ToList<Marca>();
                cat.ColoresList = db.Colores.ToList<Colores>();
            }
            return View(cat);
        }

        // POST: Guante/Create
        [HttpPost]
        public ActionResult Create(guanteRequest request)
        {
            if (ModelState.IsValid)
            {
                var pic = string.Empty;
                var folder = "~/Content/images";

                if (request.ImageFile != null)
                {
                    pic = FilesHelper.UploadPhoto(request.ImageFile, folder);
                    pic = string.Format("{0}/{1}", folder, pic);
                }


                using (TiendaOnlineEntities1 db=new TiendaOnlineEntities1())
                {

                    var guante = ToGuante(request);
                    guante.ImagenGuante = pic;
                    db.Guantes.Add(guante);
                    db.SaveChanges();
                    return Redirect(Url.Content("~/Guante/"));

                }
            }

            return View(request);
        }

        private Guantes ToGuante(guanteRequest request)
        {
            return new Guantes
            {
                ImagenGuante = request.imagenGuante,
                Descripcion = request.Descripcion,
                Talla = request.Talla,
                idMarca = request.idMarca,
                idCategoria = request.idCategoria,
                idColores = request.idColores,
                idModelo = request.idModelo

            };
        }

        // GET: Guante/Edit/5
        public ActionResult Edit(int id)
        {

            guanteModel guante = new guanteModel();
            guanteRequest gua = new guanteRequest();
                using (TiendaOnlineEntities1 db =new TiendaOnlineEntities1())
            {
                var cat = db.Guantes.Find(id);
                gua.imagenGuante = cat.ImagenGuante;
                gua.Descripcion = cat.Descripcion;
                gua.Talla = cat.Talla;
                gua.CategoriaList = db.Categoria.ToList<Categoria>();
                gua.ModeloList = db.Modelo.ToList<Modelo>();
                gua.ColoresList = db.Colores.ToList<Colores>();
                gua.MarcaList = db.Marca.ToList<Marca>();
                gua.idGuante = cat.idGuante;
            }
            return View(ToView(gua));
        }

        private guanteEdit ToView(guanteRequest request)
        {
            return new guanteEdit
            {
                imagenGuante = request.imagenGuante,
                Descripcion = request.Descripcion,
                Talla = request.Talla,
                idMarca = request.idMarca,
                idCategoria = request.idCategoria,
                idColores = request.idColores,
                idModelo = request.idModelo,
                CategoriaList=request.CategoriaList,
                MarcaList = request.MarcaList,
                ColoresList = request.ColoresList,
                ModeloList=request.ModeloList


            };
        }



        // POST: Guante/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, guanteRequest request)
        {
            if (ModelState.IsValid)
            {
                using (var db=new TiendaOnlineEntities1())
                {
                    var gua = db.Guantes.Find(request.idGuante);
                    var pic = request.imagenGuante;
                    var folder = "~/Content/images";

                    if (request.ImageFile != null)
                    {
                        pic = FilesHelper.UploadPhoto(request.ImageFile, folder);
                        pic = string.Format("{0}/{1}", folder, pic);
                    }
                    
                    var guante = ToView(request);
                    guante.imagenGuante = pic;
                    guante.Descripcion = request.Descripcion;
                    guante.Talla = request.Talla;
                    guante.idCategoria = request.idCategoria;
                    guante.idColores = request.idColores;
                    guante.idMarca = request.idMarca;
                    guante.idModelo = request.idModelo;
                    db.SaveChanges();
                        return Redirect(Url.Content("~/Guante/"));
                }

            }

            return View(request);
        }

        // GET: Guante/Delete/5
        public ActionResult Delete(int id)
        {
            using (TiendaOnlineEntities1 db=new TiendaOnlineEntities1())
            {
                var guante = db.Guantes.Find(id);
                db.Guantes.Remove(guante);
                db.SaveChanges();
            }
            return Redirect("~/Guante/");
        }

        // POST: Guante/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
