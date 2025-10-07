using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Insurence.Models;
using Insurence.Models.DataModels;

namespace Insurence.Controllers
{
    public class FeatureController : Controller
    {
        private InsuranceDbContext db = new InsuranceDbContext();

       
        public ActionResult Index()
        {
            var features = db.TblFeatures.ToList();
            return View(features);
        }

       
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TblFeature feature)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.TblFeatures.Add(feature);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(feature);
            }
            catch
            {
                return View(feature);
            }
        }

        
        public ActionResult Edit(int id)
        {
            var feature = db.TblFeatures.Find(id);
            if (feature == null)
            {
                return HttpNotFound();
            }
            return View(feature);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TblFeature feature)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(feature).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(feature);
            }
            catch
            {
                return View(feature);
            }
        }

        
        public ActionResult Delete(int id)
        {
            var feature = db.TblFeatures.Find(id);
            if (feature == null)
            {
                return HttpNotFound();
            }

            try
            {
                db.TblFeatures.Remove(feature);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

       
    }
}