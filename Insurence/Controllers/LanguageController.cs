using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Insurence.Controllers
{
    public class LanguageController : Controller
    {
        public ActionResult ChangeLanguage(string lang)
        {
            if (lang == "en")
            {
                Session["Language"] = "en";
            }
            else
            {
                Session["Language"] = "tr";
            }

           
            ViewBag.SelectedLanguage = Session["Language"];

            if (Request.UrlReferrer != null)
            {
                return Redirect(Request.UrlReferrer.ToString());
            }
            return RedirectToAction("Index", "Default");
        }
    }
}