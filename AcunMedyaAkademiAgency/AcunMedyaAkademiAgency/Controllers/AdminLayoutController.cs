﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiAgency.Context;
using AcunMedyaAkademiAgency.Entities;

namespace AcunMedyaAkademiAgency.Controllers
{
    public class AdminLayoutController : Controller
    {
        AgencyContext context = new AgencyContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult SidebarPartial()
        {
            var username = Session["username"];
            var namesurname = context.Admins.Where(x => x.UserName == username).
                Select(x => x.Name + " " + x.Surname).FirstOrDefault();
            ViewBag.profile = namesurname;
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            var username = Session["username"];
            var namesurname = context.Admins.Where(x => x.UserName == username).
                Select(x => x.Name + " " + x.Surname).FirstOrDefault();
            ViewBag.profile = namesurname;
            return PartialView();
        }
        public PartialViewResult NotificationPartial()
        {
            var values = context.Notifications.ToList();
            return PartialView(values);
        }
        public PartialViewResult MessagePartial()
        {
            var values = context.Messages.ToList();
            return PartialView(values);
        }
        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }
        
    }
}