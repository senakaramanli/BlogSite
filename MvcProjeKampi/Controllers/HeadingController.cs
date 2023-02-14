using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class HeadingController : Controller
    {
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        HeadingValidator headingValidator = new HeadingValidator();

        public ActionResult Index()
        {
            var headingvalues = hm.GetList();
            return View(headingvalues);
        }
        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valueCategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                     Text=x.CategoryName,
                                                     Value=x.CategoryID.ToString()
                                                  }).ToList();
            ViewBag.vlc = valueCategory;
            List<SelectListItem> valueWriter = (from x in wm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.WriterName + " " + x.WriterSurname,
                                                      Value = x.WriterID.ToString()
                                                  }).ToList();
            ViewBag.vlw = valueWriter;
            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
           ValidationResult results = headingValidator.Validate(p);
            if (results.IsValid)
            {
                hm.HeadingAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        //public ActionResult DeleteHeading(int id)
        //{
        //    var heading = hm.GetById(id);
        //    hm.HeadingRemove(heading);
        //    return RedirectToAction("Index");
        //}
        //[HttpGet]
        //public ActionResult EditCategory(int id)
        //{
        //    var category = cm.GetById(id);
        //    return View(category);
        //}
        //[HttpPost]
        //public ActionResult EditCategory(Category p)
        //{
        //    ValidationResult results = categoryValidator.Validate(p);
        //    if (results.IsValid)
        //    {
        //        cm.CategoryUpdate(p);
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        foreach (var item in results.Errors)
        //        {
        //            ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
        //        }
        //    }
        //    return View();
        //}

    }



}
