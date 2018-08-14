using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestChek.Models;

namespace TestChek.Controllers
{
    [Authorize]
    public class MyAccountController : Controller
    {
        List<PatientRecord> patientRecord = new List<PatientRecord>();

        // GET: MyAccount
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult MyResults()
        {
            DataAccess db = new DataAccess();

            //patientRecord = db.GetResultRecord("lastName");
            //passes new instance of patient results to the view
            var CBCPanelResults = GetCBCResults();

            return View(CBCPanelResults);
        }

        public ActionResult PayMyBill()
        {
            return View();
        }

        //builds new panel of tests
        private IEnumerable<TestClass> GetCBCResults()
        {
            //testResult used to generate random results to simulate different patients
            Random testResult = new Random(Guid.NewGuid().GetHashCode());
            return new List<TestClass>
                {
                new TestClass { testName = "WBC", result = (testResult.Next(200, 1800) / 100), minReferenceRange = 5.0f, maxReferenceRange = 10.0f, units = "x 10^3/uL"},
                new TestClass { testName = "RBC", result = (testResult.Next(300, 550) / 100), minReferenceRange = 3.90f, maxReferenceRange = 5.10f, units = "x 10^6/uL" },
                new TestClass { testName = "HGB", result = (testResult.Next(750, 1650) / 100), minReferenceRange = 11.5f, maxReferenceRange = 15.3f, units = "g/dL"},
                new TestClass { testName = "HCT", result = (testResult.Next(2520, 4710) / 100), minReferenceRange = 35.2f, maxReferenceRange = 45.1f, units = "%" },
                new TestClass { testName = "PLT", result = (testResult.Next(900, 6010) / 10), minReferenceRange = 160.0f, maxReferenceRange = 401.0f, units = "x 10^3/uL" }

                };
        }

        private IEnumerable<TestClass> GetCompMetaResults()
        {
            return new List<TestClass>
                {
                //Comp Meta results initialized here

                };
        }

        private IEnumerable<TestClass> GetAllResults()
        {
            return new List<TestClass>
                {
                //lists added together here
                //this list/ienumerable of lists will be passed to the results view, 
                //but a new class may need to be created for this list of lists, 
                //so that the view model can display results correctly

                };
        }
        
    }
}