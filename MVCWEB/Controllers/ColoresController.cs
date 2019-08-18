using MVCWEB.Models;
using MVCWEB.Models.ColorModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWEB.Controllers
{
    public class ColoresController : Controller
    {
        // GET: Colores
        public ActionResult Index()
        {
            List<colorModel> lst = null;
            using (TiendaOnlineEntities1 db = new TiendaOnlineEntities1())
            {
                lst = (from d in db.Colores
                       select new colorModel
                       {
                           idColores = d.idColores,
                           NombreColores = d.NombreColores
                       }
                     ).ToList();
            }
            return View(lst);
        }

        // GET: Colores/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Colores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Colores/Create
        [HttpPost]
        public ActionResult Create(colorRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            using (var db = new TiendaOnlineEntities1())
            {
                Colores color = new Colores();
                color.NombreColores = request.NombreColor;
                db.Colores.Add(color);
                db.SaveChanges();
            }
            return Redirect(Url.Content("~/Colores/"));
        }

        // GET: Colores/Edit/5
        public ActionResult Edit(int id)
        {
            colorEditRequest color = new colorEditRequest();
            using (var db = new TiendaOnlineEntities1())
            {
                var color1 = db.Colores.Find(id);
                color.NombreColor = color1.NombreColores;
                color.idColor = color1.idColores;
            }
            return View(color);

        }

        // POST: Colores/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, colorEditRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            using (var db = new TiendaOnlineEntities1())
            {
                var color1 = db.Colores.Find(request.idColor);
                color1.NombreColores = request.NombreColor;
                db.SaveChanges();
            }

            return Redirect(Url.Content("~/Colores/"));
        }

        // GET: Colores/Delete/5
        public ActionResult Delete(int id)
        {
            using (TiendaOnlineEntities1 db = new TiendaOnlineEntities1())
            {
                var Color1 = db.Colores.Find(id);
                db.Colores.Remove(Color1);
                db.SaveChanges();
            }
            return Redirect("~/Colores/");
        }

        // POST: Colores/Delete/5
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
