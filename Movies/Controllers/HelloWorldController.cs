﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movies.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            //return "This is my <b>default</b> action...";
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public ActionResult Welcome(string name , int numTimes = 1)
        {
            ViewBag.Message = " Hello your name is" + name;
            ViewBag.NumTimes = numTimes;
            return View();
            //return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + id);
        }
    }
}