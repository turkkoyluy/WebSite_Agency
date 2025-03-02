using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiAgency.Context;
using AcunMedyaAkademiAgency.Entities;

namespace AcunMedyaAkademiAgency.Controllers
{
    public class ServiceController : Controller
    {
        AgencyContext context = new AgencyContext();
        public ActionResult ServiceList()
        {
            var values = context.Services.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateService()
        {
            List<SelectListItem> values1 = (from x in context.Services.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.Title,
                                                Value = x.ServiceId.ToString()
                                            }).ToList();
            ViewBag.v = values1;

            return View();
        }
        [HttpPost]
        public ActionResult CreateService(Service service)
        {
            context.Services.Add(service);
            context.SaveChanges();
            return RedirectToAction("ServiceList");
        }
        public ActionResult DeleteService(int id)
        {
            var value = context.Services.Find(id);
            context.Services.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ServiceList");
        }
        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var value = context.Services.Find(id);
            return View(value);
        }
        public ActionResult UpdateService(Service service)
        {
            var value = context.Services.Find(service.ServiceId);
            value.Title = service.Title;
            value.ImageUrl = service.ImageUrl;
            value.Description = service.Description;
            context.SaveChanges();
           
            return RedirectToAction("ServiceList");
        }
    }
}