using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiAgency.Entities;
using AcunMedyaAkademiAgency.Context;

namespace AcunMedyaAkademiAgency.Controllers
{
    public class CategoryController : Controller
    {
        AgencyContext context = new AgencyContext();
        public ActionResult CategoryList(string searchText)
        {
            List<Category> values;
            if (searchText != null)
            {
                values = context.Categories.Where(x => x.CategoryName.Contains(searchText)).ToList();
                return View(values);
            }

            values = context.Categories.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View(); // CreateCategory.cshtml açılır.
        }
        [HttpPost]
        public ActionResult CreateCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return RedirectToAction("CategoryList");

        }
        public ActionResult DeleteCategory(int id)
        {
            var value = context.Categories.Find(id);
            context.Categories.Remove(value);
            context.SaveChanges();

            return RedirectToAction("CategoryList");

        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var value = context.Categories.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            var value =context.Categories.Find(category.CategoryId);

            value.CategoryName = category.CategoryName;
            context.SaveChanges();
            return RedirectToAction("CategoryList");
        }

    }
}