using MVCWEB.Models;
using MVCWEB.Models.MarcaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWEB.Controllers
{
    public class MarcaController : Controller
    {
        // GET: Marca
        public ActionResult Index()
        {
            List<marcaModel> lst = null;
            using (TiendaOnlineEntities1 db = new TiendaOnlineEntities1())
            {
                lst = (from d in db.Marca
                       select new marcaModel
                       {
                           idMarca = d.idMarca,
                           NombreMarca = d.NombreMarca

                       }).ToList();
            }
            return View(lst);
        }

        // GET: Marca/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Marca/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Marca/Create
        [HttpPost]
        public ActionResult Create(marcaRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            using (var db = new TiendaOnlineEntities1())
            {
                Marca Marca1 = new Marca();
                Marca1.NombreMarca = request.NombreMarca;
                db.Marca.Add(Marca1);
                db.SaveChanges();
            }
            return Redirect(Url.Content("~/Marca/"));
        }

        // GET: Marca/Edit/5
        public ActionResult Edit(int id)
        {
            EditMarca Marca = new EditMarca();
            using (var db = new TiendaOnlineEntities1())
            {
                var Marca1 = db.Marca.Find(id);
                Marca.NombreMarca = Marca1.NombreMarca;
                Marca.idMarca = Marca1.idMarca;
            }
            return View(Marca);

        }

        // POST: Marca/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, EditMarca request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            using (var db = new TiendaOnlineEntities1())
            {
                var Marca1 = db.Marca.Find(request.idMarca);
                Marca1.NombreMarca = request.NombreMarca;
                db.SaveChanges();
            }
            return Redirect(Url.Content("~/Marca/"));

        }

        // GET: Marca/Delete/5
        public ActionResult Delete(int id)
        {
            using (TiendaOnlineEntities1 db = new TiendaOnlineEntities1())
            {
                var Marca1 = db.Marca.Find(id);
                db.Marca.Remove(Marca1);
                db.SaveChanges();
            }
            return Redirect("~/Marca/");

        }

        // POST: Marca/Delete/5
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
