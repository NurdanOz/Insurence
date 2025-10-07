using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Insurence.Models;
using Insurence.Models.DataModels;

namespace Insurence.Controllers
{
    public class TestimonialController : Controller
    {
        private InsuranceDbContext db = new InsuranceDbContext();

        
        public ActionResult Index()
        {
            var values = db.TblTestimonials.ToList();
            return View(values);
        }

        
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TblTestimonial testimonial, HttpPostedFileBase ImageFile)
        {
            if (ModelState.IsValid)
            {
                if (ImageFile != null && ImageFile.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(ImageFile.FileName);
                    string extension = Path.GetExtension(fileName).ToLower();

                    if (extension == ".jpg" || extension == ".jpeg" || extension == ".png")
                    {
                        string uniqueFileName = Guid.NewGuid().ToString() + extension;
                        string path = Path.Combine(Server.MapPath("~/Uploads/Testimonials/"), uniqueFileName);

                        string directory = Server.MapPath("~/Uploads/Testimonials/");
                        if (!Directory.Exists(directory))
                        {
                            Directory.CreateDirectory(directory);
                        }

                        ImageFile.SaveAs(path);
                        testimonial.ImageUrl = "/Uploads/Testimonials/" + uniqueFileName;
                    }
                    else
                    {
                        ModelState.AddModelError("ImageFile", "Sadece .jpg, .jpeg veya .png dosyaları yükleyebilirsiniz.");
                        return View(testimonial);
                    }
                }

                db.TblTestimonials.Add(testimonial);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(testimonial);
        }

        
        public ActionResult Edit(int id)
        {
            var value = db.TblTestimonials.Find(id);
            if (value == null)
            {
                return HttpNotFound();
            }
            return View(value);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TblTestimonial testimonial, HttpPostedFileBase ImageFile)
        {
            if (ModelState.IsValid)
            {
                var existingTestimonial = db.TblTestimonials.Find(testimonial.TestimoniaLId);

               
                if (ImageFile != null && ImageFile.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(ImageFile.FileName);
                    string extension = Path.GetExtension(fileName).ToLower();

                    if (extension == ".jpg" || extension == ".jpeg" || extension == ".png")
                    {
                        // Eski resmi sil
                        if (!string.IsNullOrEmpty(existingTestimonial.ImageUrl))
                        {
                            string oldImagePath = Server.MapPath("~" + existingTestimonial.ImageUrl);
                            if (System.IO.File.Exists(oldImagePath))
                            {
                                System.IO.File.Delete(oldImagePath);
                            }
                        }

                        string uniqueFileName = Guid.NewGuid().ToString() + extension;
                        string path = Path.Combine(Server.MapPath("~/Uploads/Testimonials/"), uniqueFileName);

                        string directory = Server.MapPath("~/Uploads/Testimonials/");
                        if (!Directory.Exists(directory))
                        {
                            Directory.CreateDirectory(directory);
                        }

                        ImageFile.SaveAs(path);
                        testimonial.ImageUrl = "/Uploads/Testimonials/" + uniqueFileName;
                    }
                    else
                    {
                        ModelState.AddModelError("ImageFile", "Sadece .jpg, .jpeg veya .png dosyaları yükleyebilirsiniz.");
                        return View(testimonial);
                    }
                }
                else
                {
                    testimonial.ImageUrl = existingTestimonial.ImageUrl;
                }

                db.Entry(existingTestimonial).State = System.Data.Entity.EntityState.Detached;
                db.Entry(testimonial).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(testimonial);
        }

        
        public ActionResult Delete(int id)
        {
            var value = db.TblTestimonials.Find(id);
            if (value != null)
            {
                
                if (!string.IsNullOrEmpty(value.ImageUrl))
                {
                    string imagePath = Server.MapPath("~" + value.ImageUrl);
                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }
                }

                db.TblTestimonials.Remove(value);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}