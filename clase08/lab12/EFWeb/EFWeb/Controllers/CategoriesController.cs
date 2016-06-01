using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFWeb.Models;
using System.Net;
using System.Web.UI;

namespace EFWeb.Controllers
{
    public class CategoriesController : Controller
    {
        // Creando la instancia del administrador de entidades locales
        private CategoryBD db = new CategoryBD();

        [OutputCache(Duration = 300, 
            Location = OutputCacheLocation.Server,
            VaryByParam = "none")]
        public ActionResult Index()
        {
            return View(db.categories.ToList());
        }

        // GET: Categories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Category category = db.categories.Find(id);
            if(category == null)
            {
                return HttpNotFound();
            }

            return View(category);
        }

        public ActionResult DetailsByDescription(string description)
        {
            Category category = (Category)
                (from c in db.categories
                 where c.description == description
                 select c).FirstOrDefault();
            //verificando si el objeto está vacio.
            if(category == null)
            {
                return HttpNotFound();
            }
            return View("Details", category);
        }

        // GET: Categories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "categoryID,description,salesContact,salesNumbers")] Category category)
        {
            if (ModelState.IsValid)
            {
                db.categories.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        // GET: Categories/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Categories/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categories/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Categories/Delete/5
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

        public PartialViewResult _Busqueda()
        {
            return PartialView();
        }

    }
}
