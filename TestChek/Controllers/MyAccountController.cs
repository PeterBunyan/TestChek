using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestChek.Models;
using Microsoft.AspNet.Identity;

namespace TestChek.Controllers
{
    [Authorize(Roles = Roles.CanViewOrOrderTests)]
    public class MyAccountController : Controller
    {
        private ModelDBContext _context;

        public MyAccountController()
        {
            _context = new ModelDBContext();
        }
        IEnumerable<PatientRecord> patientRecord = new List<PatientRecord>();

        // GET: MyAccount
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult MyResults(string id)
        {

            if (User.IsInRole(Roles.CanOrderTests))
            {
                var resultsToProvider = _context.PatientRecords.Where(c => c.medRecNumber == id);
                patientRecord = resultsToProvider;
                return View(patientRecord);
            }

            var userId = User.Identity.GetUserId();

            var resultsToPatient = _context.PatientRecords.Where(c => c.medRecNumber == userId);
            patientRecord = resultsToPatient;
            return View(patientRecord);

        }

    }
}