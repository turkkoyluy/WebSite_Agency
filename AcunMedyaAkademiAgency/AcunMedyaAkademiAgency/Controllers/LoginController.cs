using AcunMedyaAkademiAgency.Context;
using AcunMedyaAkademiAgency.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AcunMedyaAkademiAgency.Controllers
{
   [AllowAnonymous]
    public class LoginController : Controller
    {
        AgencyContext context = new AgencyContext();
        public ActionResult AdminLogin()
        {

            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(Admin admin)
        {
            var result = context.Admins.FirstOrDefault(x => x.UserName == admin.UserName && x.Password == admin.Password);
            if (result != null)
            {
                FormsAuthentication.SetAuthCookie(admin.UserName, true);
                Session["username"] = result.UserName;
                return RedirectToAction("ProjectList", "Project");
            }

            return View();
        }
    }
}