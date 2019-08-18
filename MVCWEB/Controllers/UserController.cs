using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWEB.Models;
using MVCWEB.Models.UserViewModel;
using MVCWEB.Models.ViewModels;

namespace MVCWEB.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            List<UserTableViewModel> lst = null;
            using (TiendaOnlineEntities1 db= new TiendaOnlineEntities1())
            {
                lst = (from d in db.User
                       select new UserTableViewModel
                       {
                           idUser=d.idUser,
                           nombreUser = d.name,
                           email = d.email,
                           password = d.password
                       }).ToList();
            }
            return View(lst);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(UserViewModel user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            using (var db= new TiendaOnlineEntities1())
            {
                User user1 = new User();
                user1.name = user.nombreUser;
                user1.email = user.email;
                user1.password = user.password;
                db.User.Add(user1);
                db.SaveChanges();

            }
            return Redirect(Url.Content("~/User/"));
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {

            EditUserViewModel User = new EditUserViewModel();
            using (var db=new TiendaOnlineEntities1())
            {
                var User1 = db.User.Find(id);
                User.NombreUsuario = User1.name;
                User.email = User1.email;
                User.password = User1.password;
                User.idUser = User1.idUser;
            }
            return View(User);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(EditUserViewModel User)
        {
            if (!ModelState.IsValid)
            {
                return View(User);
            }

            using (var db=new TiendaOnlineEntities1())
            {
                var User1 = db.User.Find(User.idUser);
                User1.name = User.NombreUsuario;
                User1.email = User.email;
                if (User.password!=null && User.password.Trim()!="")
                {

                    User1.password = User.password;
                }

                db.Entry(User1).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            return Redirect(Url.Content("~/User/"));
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            using (TiendaOnlineEntities1 db= new TiendaOnlineEntities1())
            {
                var User1 = db.User.Find(id);
                db.User.Remove(User1);
                db.SaveChanges();
            }
            return Redirect("~/User/");
        }

        // POST: User/Delete/5
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
