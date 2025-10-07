using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Insurence.Models;
using Insurence.Models.DataModels;
using Newtonsoft.Json;

namespace Insurence.Controllers
{
    public class ServiceController : Controller
    {
        private InsuranceDbContext db = new InsuranceDbContext();

        private const string HUGGING_FACE_API_URL = "****"; 
        private const string HUGGING_FACE_TOKEN = "****";


        public ActionResult Index()
        {
            var services = db.TblServices.ToList();
            return View(services);
        }

       
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TblService service)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.TblServices.Add(service);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(service);
            }
            catch
            {
                return View(service);
            }
        }

        
        public ActionResult Edit(int id)
        {
            var service = db.TblServices.Find(id);
            if (service == null)
            {
                return HttpNotFound();
            }
            return View(service);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TblService service)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(service).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(service);
            }
            catch
            {
                return View(service);
            }
        }

        
        public ActionResult Delete(int id)
        {
            var service = db.TblServices.Find(id);
            if (service == null)
            {
                return HttpNotFound();
            }

            try
            {
                db.TblServices.Remove(service);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult AIImageGenerator()
        {
            return View();
        }

        
        [HttpPost]
        public async Task<ActionResult> GenerateAIImage(string prompt)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {HUGGING_FACE_TOKEN}");
                    client.Timeout = TimeSpan.FromMinutes(2); 

                    var payload = new
                    {
                        inputs = prompt,
                        options = new { wait_for_model = true }
                    };

                    var jsonContent = JsonConvert.SerializeObject(payload);
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(HUGGING_FACE_API_URL, content);

                    if (response.IsSuccessStatusCode)
                    {
                        var imageBytes = await response.Content.ReadAsByteArrayAsync();
                        return File(imageBytes, "image/png");
                    }
                    else
                    {
                        var errorContent = await response.Content.ReadAsStringAsync();
                        return Json(new
                        {
                            success = false,
                            error = $"API Error: {response.StatusCode} - {errorContent}"
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    success = false,
                    error = $"Hata oluştu: {ex.Message}"
                });
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}


    
