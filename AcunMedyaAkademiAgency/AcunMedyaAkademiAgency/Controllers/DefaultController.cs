using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiAgency.Context;

namespace AcunMedyaAkademiAgency.Controllers
{
    public class DefaultController : Controller
    {
        AgencyContext context = new AgencyContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult ProjectPartial()
        {
            var values = context.Projects.OrderByDescending(x => x.ProjectId).Take(6).ToList();
            return PartialView(values);
        }
        public PartialViewResult ModalPartial()
        {
            var values = context.ProjectDetails.ToList();
            return PartialView(values);
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult FeaturePartial()
        {
            var values = context.Features.ToList();
            return PartialView(values);
        }
        public PartialViewResult ServicePartial()
        {
            var values = context.Services.ToList();
            return PartialView(values);
        }
        public PartialViewResult AboutPartial()
        {
            var values = context.Abouts.ToList();
            return PartialView(values);
        }
        public PartialViewResult TeamPartial()
        {
            var values = context.Teams.ToList();
            return PartialView(values);
        }
        public PartialViewResult ClientsPartial()
        {
            return PartialView();
        }
        public PartialViewResult ContactPartial()
        {
            return PartialView();
        }
        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult SocialMediaPartial()
        {
            var values = context.SocialMedias.ToList();
            return PartialView(values);
        }
 



    }
}