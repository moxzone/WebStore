﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    { 
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page（首页）";
            //object o = new Object();  123123

            return View();
        }
    }
}
