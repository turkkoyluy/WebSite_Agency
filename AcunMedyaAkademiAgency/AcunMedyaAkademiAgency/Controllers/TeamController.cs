using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiAgency.Entities;
using AcunMedyaAkademiAgency.Context;

namespace AcunMedyaAkademiAgency.Controllers
{
    public class TeamController : Controller
    {
        AgencyContext context = new AgencyContext();
        public ActionResult TeamList(string searchText)
        {
            List<Team> values;
            if (searchText != null)
            {
                values = context.Teams.Where(x => x.NameSurname.Contains(searchText)).ToList();
                return View(values);
            }

            values = context.Teams.ToList();
            return View(values);
        }

        public ActionResult DeleteTeam(int id)
        {
            var value = context.Teams.Find(id);
            context.Teams.Remove(value);
            context.SaveChanges();

            return RedirectToAction("TeamList");
        }

        [HttpGet]
        public ActionResult CreateTeam()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTeam(Team team)
        {
            context.Teams.Add(team);
            context.SaveChanges();
            return RedirectToAction("TeamList");
        }


        [HttpGet]
        public ActionResult UpdateTeam(int id)
        {
            var value =context.Teams.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateTeam(Team team)
        {
            var value = context.Teams.Find(team.TeamId);

            value.NameSurname = team.NameSurname;
            value.ImageUrl = team.ImageUrl;
            context.SaveChanges();
            return RedirectToAction("TeamList");
        }

    }
}