using Insurence.Models;
using Insurence.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Insurence.Controllers
{

    public class DefaultController : Controller
    {
        private InsuranceDbContext db = new InsuranceDbContext();


        public ActionResult Index()
        {
            return View();
        }

       public PartialViewResult _FeaturePartial()
        {
            var features = db.TblFeatures.ToList();
            return PartialView("_FeaturePartial", features);
        }

        public PartialViewResult _AboutPartial()
        {
            var abouts = db.TblAbouts.ToList();
            return PartialView("_AboutPartial", abouts);
        }

        public PartialViewResult _EmployePartial()
        {
            var employes = db.TblEmployes.ToList();
            return PartialView("_EmployePartial", employes);
        }

        public PartialViewResult _TestimonialPartial()
        {
            var testimonials = db.TblTestimonials.ToList();
            return PartialView("_TestimonialPartial", testimonials);
        }

        public PartialViewResult _ContactPartial()
        {
            var contacts = db.TblContacts.FirstOrDefault();
            return PartialView("_ContactPartial", contacts);
        }

        public PartialViewResult _ServicePartial()
        {
            var values = db.TblServices.ToList();
            return PartialView("_ServicePartial", values);
        }

        public PartialViewResult _SSSPartial()
        {
            var sss = db.TblSSSes.ToList();
            return PartialView("_SSSPartial", sss);
        }


    }
}