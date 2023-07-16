﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Portfolio.Models.Entities;

namespace Casgem_Portfolio.Controllers
{
    public class ContactController : Controller
    {
        CasgemPortfolioEntities1 db = new CasgemPortfolioEntities1();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index(TblMessage p)
        {
            db.TblMessage.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index","Portfolio");
        }
        [HttpGet]
        public ActionResult Get()
        {
            var values = db.TblContact.ToList();
            return View(values);
        }
    }
}