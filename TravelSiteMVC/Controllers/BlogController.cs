﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelSiteMVC.Models.Sınıflar;

namespace TravelSiteMVC.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        public ActionResult Index()
        {
            var bloglar = c.Blogs.ToList();
            return View(bloglar);
        }
        public ActionResult BlogDetay(int id) 
        {
            return View();
        }
    }
}