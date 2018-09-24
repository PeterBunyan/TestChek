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
            //testResult used to generate random results to simulate different patients
            Random testResult = new Random(Guid.NewGuid().GetHashCode());
            return new List<TestClass>
                {
                new TestClass { testName = "Sodium", result = (testResult.Next(12000, 15500) / 100), minReferenceRange = 135.0f, maxReferenceRange = 146.0f, units = "MMOL/L"},
                new TestClass { testName = "Potassium", result = (testResult.Next(300, 550) / 100), minReferenceRange = 3.60f, maxReferenceRange = 5.20f, units = "MMOL/L" },
                new TestClass { testName = "Chloride", result = (testResult.Next(9800, 11500) / 100), minReferenceRange = 100.0f, maxReferenceRange = 108.0f, units = "MMOL/L"},
                new TestClass { testName = "Carbon Dioxide", result = (testResult.Next(1500, 2500) / 100), minReferenceRange = 21.0f, maxReferenceRange = 32.0f, units = "MMOL/L" },
                new TestClass { testName = "Glucose", result = (testResult.Next(6500, 25000) / 100), minReferenceRange = 70.0f, maxReferenceRange = 99.0f, units = "MG/DL" },
                new TestClass { testName = "BUN", result = (testResult.Next(400, 2500) / 100), minReferenceRange = 6.0f, maxReferenceRange = 22.0f, units = "MG/DL"},
                new TestClass { testName = "Creatinine", result = (testResult.Next(40, 150) / 100), minReferenceRange = 0.5f, maxReferenceRange = 1.3f, units = "MG/DL" },
                new TestClass { testName = "Calcium", result = (testResult.Next(800, 1100) / 100), minReferenceRange = 8.5f, maxReferenceRange = 10.1f, units = "MG/DL" }
                };
        }

        public IEnumerable<TestClass> UrineScreen()
        {
            //testResult used to generate random results to simulate different patients
            Random testResult = new Random(Guid.NewGuid().GetHashCode());
            return new List<TestClass>
                {
                new TestClass { testName = "Glucose", result = (testResult.Next(0, 100) / 100), minReferenceRange = 0.0f, maxReferenceRange = 1.0f, units = "MG/DL"},
                new TestClass { testName = "Biliruben", result = (testResult.Next(0, 100) / 100), minReferenceRange = 0.0f, maxReferenceRange = 1.0f, units = "N/A" },
                new TestClass { testName = "Ketones", result = (testResult.Next(0, 100) / 100), minReferenceRange = 0.0f, maxReferenceRange = 1.0f, units = "MG/DL"},
                new TestClass { testName = "Spec. Gravity", result = (testResult.Next(100, 104) / 100), minReferenceRange = 1.003f, maxReferenceRange = 1.035f, units = "N/A" },
                new TestClass { testName = "Blood", result = (testResult.Next(0, 300) / 100), minReferenceRange = 0.0f, maxReferenceRange = 3.0f, units = "N/A" },
                new TestClass { testName = "pH", result = (testResult.Next(400, 800) / 100), minReferenceRange = 5.0f, maxReferenceRange = 9.0f, units = "N/A"},
                new TestClass { testName = "Protein", result = (testResult.Next(0, 30000) / 100), minReferenceRange = 0.0f, maxReferenceRange = 300.0f, units = "MG/DL" },
                new TestClass { testName = "Urobilinogen", result = (testResult.Next(800, 1100) / 100), minReferenceRange = 0.0f, maxReferenceRange = 1.0f, units = "EU/DL" },
                new TestClass { testName = "Nitrite", result = (testResult.Next(0, 100) / 100), minReferenceRange = 0.0f, maxReferenceRange = 1.0f, units = "N/A" },
                new TestClass { testName = "Leukocyte Esterase", result = (testResult.Next(0, 300) / 100), minReferenceRange = 0.0f, maxReferenceRange = 3.0f, units = "N/A" }

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