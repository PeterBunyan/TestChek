using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestChek.Models;

namespace TestChek.Controllers
{
    public class FAQController : Controller
    {
        // GET: FAQ
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WhatDoMyTestResultsMean()
        {
            return View();
        }

        public ActionResult WhoPerformsTheseTests()
        {
            return View();
        }
    }
    
}