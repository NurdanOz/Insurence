using System;
using System.Linq;
using System.Web.Mvc;
using Insurence.Models;
using Insurence.Models.DataModels; 

namespace Insurence.Controllers
{
    public class AboutController : Controller
    {
        private InsuranceDbContext db = new InsuranceDbContext();

       
        public ActionResult Index()
        {
            var values = db.TblAbouts.ToList();
            return View(values);
        }

        
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TblAbout about)
        {
            if (ModelState.IsValid)
            {
                db.TblAbouts.Add(about);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(about);
        }

       
        public ActionResult Edit(int id)
        {
            var value = db.TblAbouts.Find(id);
            if (value == null)
            {
                return HttpNotFound();
            }
            return View(value);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TblAbout about)
        {
            if (ModelState.IsValid)
            {
                db.Entry(about).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(about);
        }

        
        public ActionResult Delete(int id)
        {
            var value = db.TblAbouts.Find(id);
            if (value != null)
            {
                db.TblAbouts.Remove(value);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

       
    }
}