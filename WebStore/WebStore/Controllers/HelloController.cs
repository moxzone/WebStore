﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebStore.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello1
        public ActionResult Index()
        {
            return View();
        }

        //public string index()
        //{
        //    return "这是一个<b><>页面~";
        //}

        public string Welcome(string userName = "test", int id = 1)
        {
            return HttpUtility.HtmlEncode("Hello "+userName+", ID:"+id);
        }
    }
}