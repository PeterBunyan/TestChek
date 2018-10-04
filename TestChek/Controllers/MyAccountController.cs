using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestChek.Models;

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
            var results = _context.PatientRecords.Where(c => c.medRecNumber == id);
            patientRecord = results;
            return View(patientRecord);
        }

        public ActionResult PayMyBill()
        {
            return View();
        }      
    }
}