using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestChek.Models;
using TestChek.ViewModel;

namespace TestChek.Controllers
{
    public class PhysicianLinksController : Controller
    {
        private ModelDBContext _context = new ModelDBContext();
        // GET: PhysicianLinks
        public ActionResult Index()
        {
            var patients = new List<AspNetUser>();
            var aspNetUsersList = new AspNetUsersList();
            patients = aspNetUsersList.GetAspNetUsers();
            //patients = _context.AspNetUsers.ToList();
            //patients = _context.AspNetUsers.ToList();

            var viewModel = new ViewModel.OrderedTestViewModel();
            //var testMenuList = new TestMenu().TestMenuList
            //;
            //OrderedTestViewModel patientTests = new OrderedTestViewModel();
            //patientTests.patientList = patients;
            var testPanel = new TestPanel();
            viewModel.TestMenuList.Add(testPanel.CBC());
            viewModel.TestMenuList.Add(testPanel.BasicMetPanel());
            viewModel.TestMenuList.Add(testPanel.UrineScreen());

            //patientTests.TestMenuList.Add(testPanel.UrineScreen());

            //patientTests.testMenu.TestMenuList.Add(testPanel.CBC());
            //patientTests.testMenu.TestMenuList.Add(testPanel.BasicMetPanel());
            //patientTests.testMenu.TestMenuList.Add(testPanel.UrineScreen());
            //TestPanel newTest = new TestPanel();
            //IEnumerable<TestClass> newPanel = newTest.CBC();
            //patientTests.patientList = _context.AspNetUsers.ToList();
            return View(viewModel);
        }
    }
}