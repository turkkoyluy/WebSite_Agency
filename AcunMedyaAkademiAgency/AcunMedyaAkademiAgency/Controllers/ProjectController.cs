﻿using AcunMedyaAkademiAgency.Entities;
using AcunMedyaAkademiAgency.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AcunMedyaAkademiAgency.Controllers
{   
    public class ProjectController : Controller
    {
        AgencyContext context = new AgencyContext();
        public ActionResult ProjectList(string searchText)
        {
            List<Project> values;
            if (searchText != null)
            {
                values = context.Projects.Where(x => x.Title.Contains(searchText)).ToList();
                return View(values);
            }

            values = context.Projects.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateProject()
        {
            List<SelectListItem> values1 = (from x in context.Categories.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.CategoryName,
                                                Value = x.CategoryId.ToString()
                                            }).ToList();
            ViewBag.v = values1;

            return View();
        }
        [HttpPost]
        public ActionResult CreateProject(Project project)
        {
            context.Projects.Add(project);
            context.SaveChanges();
            return RedirectToAction("ProjectList");

        }
        public ActionResult DeleteProject(int id)
        {
            var value = context.Projects.Find(id);
            context.Projects.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ProjectList");
        }
        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var value = context.Projects.Find(id);
            return View(value);
        }
        public ActionResult UpdateProject(Project project)
        {
            var value = context.Projects.Find(project.ProjectId);
            value.Title = project.Title;
            value.ImageUrl = project.ImageUrl;
            context.SaveChanges();

            return RedirectToAction("ProjectList");
        }

    }
}