using System;
using System.Linq;
using System.Web.Mvc;
using Insurence.Models;
using Insurence.Models.DataModels;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;
using System.Configuration;
using System.Collections.Generic;

namespace Insurence.Controllers
{
    public class SSSController : Controller
    {
        private InsuranceDbContext db = new InsuranceDbContext();

        public ActionResult Index()
        {
            var sss = db.TblSSSes.ToList();
            return View(sss);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TblSSS sss)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.TblSSSes.Add(sss);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(sss);
            }
            catch
            {
                return View(sss);
            }
        }

        public ActionResult Edit(int id)
        {
            var sss = db.TblSSSes.Find(id);
            if (sss == null)
            {
                return HttpNotFound();
            }
            return View(sss);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TblSSS sss)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(sss).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(sss);
            }
            catch
            {
                return View(sss);
            }
        }

        public ActionResult Delete(int id)
        {
            var sss = db.TblSSSes.Find(id);
            if (sss == null)
            {
                return HttpNotFound();
            }
            try
            {
                db.TblSSSes.Remove(sss);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<JsonResult> GenerateWithAI()
        {
            try
            {
                string apiKey = ConfigurationManager.AppSettings["GeminiApiKey"];

                if (string.IsNullOrEmpty(apiKey))
                {
                    return Json(new { success = false, message = "API Key bulunamadı!" });
                }

                string url = $"https://generativelanguage.googleapis.com/v1/models/gemini-2.5-flash:generateContent?key={apiKey}";


                var prompt = @"Bir sigorta şirketi için 4 tane sıkça sorulan soru ve cevaplarını oluştur. 
Her soru ve cevap hem Türkçe hem de İngilizce olmalı. 
JSON formatında döndür:
[
  {
    ""soruTR"": ""Türkçe soru"",
    ""cevapTR"": ""Türkçe cevap"",
    ""soruEN"": ""English question"",
    ""cevapEN"": ""English answer""
  }
]
Sadece JSON döndür, başka açıklama ekleme.";

                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(60);

                    var requestBody = new
                    {
                        contents = new[]
                        {
                    new
                    {
                        parts = new[]
                        {
                            new { text = prompt }
                        }
                    }
                }
                    };

                    var json = JsonConvert.SerializeObject(requestBody);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(url, content);
                    var responseString = await response.Content.ReadAsStringAsync();

                    if (!response.IsSuccessStatusCode)
                    {
                        return Json(new { success = false, message = "Gemini API Hatası: " + response.StatusCode + " - " + responseString });
                    }

                    var geminiResponse = JsonConvert.DeserializeObject<dynamic>(responseString);
                    string generatedText = geminiResponse.candidates[0].content.parts[0].text;

                    generatedText = generatedText.Replace("```json", "").Replace("```", "").Trim();

                    return Json(new { success = true, data = generatedText });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Exception: " + ex.Message });
            }
        }



        [HttpPost]
        public ActionResult SaveAIGenerated(List<TblSSS> items)
        {
            try
            {
                foreach (var item in items)
                {
                    db.TblSSSes.Add(item);
                }
                db.SaveChanges();
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<JsonResult> ListModels()
        {
            try
            {
                string apiKey = ConfigurationManager.AppSettings["GeminiApiKey"];
                string url = $"https://generativelanguage.googleapis.com/v1beta/models?key={apiKey}";

                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(url);
                    var responseString = await response.Content.ReadAsStringAsync();

                    dynamic jsonResponse = JsonConvert.DeserializeObject(responseString);
                    var modelNames = new List<string>();

                    if (jsonResponse.models != null)
                    {
                        foreach (var model in jsonResponse.models)
                        {
                            modelNames.Add(model.name.ToString());
                        }
                    }

                    return Json(new
                    {
                        success = true,
                        modelNames = modelNames,
                        fullResponse = responseString
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}