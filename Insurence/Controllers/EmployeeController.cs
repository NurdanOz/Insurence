using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Insurence.Models;
using Insurence.Models.DataModels;

namespace Insurence.Controllers
{
    public class EmployeeController : Controller
    {
        private InsuranceDbContext db = new InsuranceDbContext();

        
        public ActionResult Index()
        {
            var values = db.TblEmployes.ToList();
            return View(values);
        }

       
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TblEmploye employee, HttpPostedFileBase ImageFile)
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
                        string path = Path.Combine(Server.MapPath("~/Uploads/Team/"), uniqueFileName);

                        
                        string directory = Server.MapPath("~/Uploads/Team/");
                        if (!Directory.Exists(directory))
                        {
                            Directory.CreateDirectory(directory);
                        }

                        ImageFile.SaveAs(path);
                        employee.ImageUrl = "/Uploads/Team/" + uniqueFileName;
                    }
                    else
                    {
                        ModelState.AddModelError("ImageFile", "Sadece .jpg, .jpeg veya .png dosyaları yükleyebilirsiniz.");
                        return View(employee);
                    }
                }

                db.TblEmployes.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

       
        public ActionResult Edit(int id)
        {
            var value = db.TblEmployes.Find(id);
            if (value == null)
            {
                return HttpNotFound();
            }
            return View(value);
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TblEmploye employee, HttpPostedFileBase ImageFile)
        {
            if (ModelState.IsValid)
            {
                var existingEmployee = db.TblEmployes.Find(employee.EmployeId);

                
                if (ImageFile != null && ImageFile.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(ImageFile.FileName);
                    string extension = Path.GetExtension(fileName).ToLower();

                    if (extension == ".jpg" || extension == ".jpeg" || extension == ".png")
                    {
                       
                        if (!string.IsNullOrEmpty(existingEmployee.ImageUrl))
                        {
                            string oldImagePath = Server.MapPath("~" + existingEmployee.ImageUrl);
                            if (System.IO.File.Exists(oldImagePath))
                            {
                                System.IO.File.Delete(oldImagePath);
                            }
                        }

                      
                        string uniqueFileName = Guid.NewGuid().ToString() + extension;
                        string path = Path.Combine(Server.MapPath("~/Uploads/Team/"), uniqueFileName);

                        string directory = Server.MapPath("~/Uploads/Team/");
                        if (!Directory.Exists(directory))
                        {
                            Directory.CreateDirectory(directory);
                        }

                        ImageFile.SaveAs(path);
                        employee.ImageUrl = "/Uploads/Team/" + uniqueFileName;
                    }
                    else
                    {
                        ModelState.AddModelError("ImageFile", "Sadece .jpg, .jpeg veya .png dosyaları yükleyebilirsiniz.");
                        return View(employee);
                    }
                }
                else
                {
                    
                    employee.ImageUrl = existingEmployee.ImageUrl;
                }

                db.Entry(existingEmployee).State = System.Data.Entity.EntityState.Detached;
                db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        
        public ActionResult Delete(int id)
        {
            var value = db.TblEmployes.Find(id);
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

                db.TblEmployes.Remove(value);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

       
    }
}