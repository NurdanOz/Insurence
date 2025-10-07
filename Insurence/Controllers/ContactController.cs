using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Insurence.Models;
using Insurence.Models.DataModels;

namespace Insurence.Controllers
{
    public class ContactController : Controller
    {
        private InsuranceDbContext db = new InsuranceDbContext();

       
        public ActionResult Index()
        {
            var contacts = db.TblContacts.ToList();
            return View(contacts);
        }

        
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TblContact contact)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.TblContacts.Add(contact);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(contact);
            }
            catch
            {
                return View(contact);
            }
        }

       
        public ActionResult Edit(int id)
        {
            var contact = db.TblContacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TblContact contact)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(contact).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(contact);
            }
            catch
            {
                return View(contact);
            }
        }

      
        public ActionResult Delete(int id)
        {
            var contact = db.TblContacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }

            try
            {
                db.TblContacts.Remove(contact);
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