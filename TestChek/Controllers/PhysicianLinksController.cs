﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestChek.Models;
using System.Data.SqlClient;
//using TestChek.ViewModel;

namespace TestChek.Controllers
{
    public class PhysicianLinksController : Controller
    {
        private ModelDBContext _context;

        public PhysicianLinksController()
        {
            _context = new ModelDBContext();
        }
        // GET: PhysicianLinks
        public ActionResult Index()
        {

            var patients = _context.AspNetUsers.ToList();

            var testMenu = new List<TestPanel>();
            var panelCBC = new TestPanel();
            var panelBMP = new TestPanel();
            var panelUA = new TestPanel();
            panelCBC.panelName = "CBC";
            panelBMP.panelName = "BMP";
            panelUA.panelName = "UA";
            testMenu.Add(panelCBC);
            testMenu.Add(panelBMP);
            testMenu.Add(panelUA);

            var viewModel = new OrderedTestViewModel();
            viewModel.CBC = "CBC";
            viewModel.BMP = "BMP";
            viewModel.UA = "UA";

            viewModel.patientList = patients;
            viewModel.testPanelList = testMenu;


            return View(viewModel);
        }
    }
}