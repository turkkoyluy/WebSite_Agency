using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiAgency.Entities;
using AcunMedyaAkademiAgency.Context;

namespace AcunMedyaAkademiAgency.Controllers
{
    public class AboutController : Controller
    {
        AgencyContext context = new AgencyContext();

        [HttpGet]
        public ActionResult AboutList(string searchText)
        {
            // arama listesi
            List<About> values = new List<About>();
            if (!string.IsNullOrEmpty(searchText))
            {
                values = context.Abouts.Where(x => x.Title.Contains(searchText)).ToList();
                return View(values);
            }
            values = context.Abouts.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAbout(About about)
        {
            context.Abouts.Add(about);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }

        public ActionResult DeleteAbout(int id)
        {
            var value = context.Abouts.Find(id);
            context.Abouts.Remove(value);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value = context.Abouts.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About about)
        {
            var value = context.Abouts.Find(about.AboutId);
            value.Title = about.Title;
            value.Description = about.Description;
            value.ImageUrl = about.ImageUrl;

            context.SaveChanges();
            return RedirectToAction("AboutList");
        }

    }
}