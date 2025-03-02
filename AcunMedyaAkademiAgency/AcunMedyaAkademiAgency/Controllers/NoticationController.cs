using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiAgency.Context;
using AcunMedyaAkademiAgency.Entities;

namespace AcunMedyaAkademiAgency.Controllers
{
    public class NoticationController : Controller
    {
        AgencyContext context = new AgencyContext();
        public ActionResult NotifactionList(string searchText)
        {
            List<Notification> values;
            if (searchText != null)
            {
                values = context.Notifications.Where(x => x.NameSurname.Contains(searchText)).ToList();
                return View(values);
            }

            values = context.Notifications.ToList();
            return View(values);
        }
    }
}