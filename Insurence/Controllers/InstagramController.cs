using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace YourProjectName.Controllers
{
    public class InstagramController : Controller
    {
        public async Task<JsonResult> GetFollowers()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("x-rapidapi-key", "****");
                    client.DefaultRequestHeaders.Add("x-rapidapi-host", "****");

                    // DOĞRU ENDPOINT - User About için
                    var response = await client.GetAsync("****");

                    if (response.IsSuccessStatusCode)
                    {
                        var data = await response.Content.ReadAsStringAsync();
                        return Json(new { success = true, data = data }, JsonRequestBehavior.AllowGet);
                    }

                    return Json(new { success = false, message = "API isteği başarısız" }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}