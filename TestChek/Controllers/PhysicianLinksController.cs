using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestChek.Models;
using System.Data.SqlClient;

namespace TestChek.Controllers
{
    //Only providers can access this portion of the site
    [Authorize(Roles = Roles.CanOrderTests)]
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
            ViewBag.Message = "";
            //populate list of AspNetUsers to supply to ViewModel for display
            var patients = _context.AspNetUsers.ToList();
            //var AuthUsers = from aspNetUser in _context.AspNetUsers
            //                join userinroles in _context.AspNetUserRoles on aspNetUser.Id equals userinroles.UserId
            //                where userinroles.RoleId = 1
            //                //&& userinroles.RoleId == 
            //                select aspNetUser;
            var viewModel = new OrderedTestViewModel();

            //Tests used to populate test menu list in Index view
            viewModel.CBC = "CBC";
            viewModel.BMP = "BMP";
            viewModel.UA = "UA";

            viewModel.patientList = patients;
            
            return View(viewModel);
        }
    }
}