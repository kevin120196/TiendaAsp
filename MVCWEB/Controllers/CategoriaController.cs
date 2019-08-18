using MVCWEB.Models;
using MVCWEB.Models.CategoriaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWEB.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            List<categoriaModel> lst = null;
            using (TiendaOnlineEntities1 db = new TiendaOnlineEntities1())
            {
                lst = (from d in db.Categoria
                       select new categoriaModel
                       {
                           idCategoria = d.idCategoria,
                           NombreCategoria = d.NombreCategoria
                       }

                    ).ToList();
            }
            return View(lst);
        }

        // GET: Categoria/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Categoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categoria/Create
        [HttpPost]
        public ActionResult Create(categoriaRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            using (var db = new TiendaOnlineEntities1())
            {
                Models.Categoria cat = new Models.Categoria();
                cat.NombreCategoria = request.NombreCategoria;
                db.Categoria.Add(cat);
                db.SaveChanges();
            }
            return Redirect(Url.Content("~/Categoria/"));

        }

        // GET: Categoria/Edit/5
        public ActionResult Edit(int id)
        {

            editCategoria cat = new editCategoria();
            using (var db = new TiendaOnlineEntities1())
            {
                var Cat1 = db.Categoria.Find(id);
                cat.NombreCategoria = Cat1.NombreCategoria;
                cat.idCategoria = Cat1.idCategoria;
            }
            return View(cat);
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, editCategoria request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }
            using (var db = new TiendaOnlineEntities1())
            {
                var Cat = db.Categoria.Find(request.idCategoria);
                Cat.NombreCategoria = request.NombreCategoria;
                db.SaveChanges();
            }
            return Redirect(Url.Content("~/Categoria/"));
        }

        // GET: Categoria/Delete/5
        public ActionResult Delete(int id)
        {
            using (TiendaOnlineEntities1 db = new TiendaOnlineEntities1())
            {
                var Cat1 = db.Categoria.Find(id);
                db.Categoria.Remove(Cat1);
                db.SaveChanges();
            }
            return Redirect("~/Categoria/");
        }

        // POST: Categoria/Delete/5
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
