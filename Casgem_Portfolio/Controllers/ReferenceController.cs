﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Portfolio.Models.Entities;


namespace Casgem_Portfolio.Controllers
{
    public class ReferenceController : Controller
    {
        CasgemPortfolioEntities1 db = new CasgemPortfolioEntities1();
        public ActionResult Index()
        {
            var values = db.TblReference.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddReference()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddReference(TblReference p)
        {
            db.TblReference.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteReference(int id)
        {
            var value = db.TblReference.Find(id);
            db.TblReference.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}