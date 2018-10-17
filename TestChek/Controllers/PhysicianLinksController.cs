using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestChek.Models;
using System.Data.SqlClient;
<<<<<<< HEAD
//using TestChek.ViewModel;

namespace TestChek.Controllers
{
=======

namespace TestChek.Controllers
{
    //Only providers can access this portion of the site
    [Authorize(Roles = Roles.CanOrderTests)]
>>>>>>> API
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
<<<<<<< HEAD
            //var patients = new List<AspNetUser>();
            //try
            //{
            var patients = _context.AspNetUsers.ToList();
            //}
            //catch (Exception exception)
            //{

            //}

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

            //var viewModel = new ViewModel.OrderedTestViewModel();
            var viewModel = new OrderedTestViewModel();
=======
            ViewBag.Message = "";
            //populate list of AspNetUsers to supply to ViewModel for display
            //var patients = _context.AspNetUsers.ToList();
            var AuthUsers = from aspNetUser in _context.AspNetUsers
                            join userinroles in _context.AspNetUserRoles on aspNetUser.Id equals userinroles.UserId
                            where userinroles.RoleId == "1"
                            select aspNetUser;
            AuthUsers = AuthUsers.OrderBy(x => x.LastName);
            var viewModel = new OrderedTestViewModel();

            //Tests used to populate test menu list in Index view
>>>>>>> API
            viewModel.CBC = "CBC";
            viewModel.BMP = "BMP";
            viewModel.UA = "UA";

<<<<<<< HEAD
            viewModel.patientList = patients;
            viewModel.testPanelList = testMenu;

=======
            //viewModel.patientList = patients;
            viewModel.patientList = AuthUsers.ToList();
>>>>>>> API

            return View(viewModel);
        }
    }
}