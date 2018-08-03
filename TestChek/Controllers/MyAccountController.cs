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
        // GET: MyAccount
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult MyResults()
        {
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
                new TestClass { TestName = "WBC", Result = (testResult.Next(200, 1800) / 100), MinReferenceRange = 5.0f, MaxReferenceRange = 10.0f, Units = "x 10^3/uL"},
                new TestClass { TestName = "RBC", Result = (testResult.Next(300, 550) / 100), MinReferenceRange = 3.90f, MaxReferenceRange = 5.10f, Units = "x 10^6/uL" },
                new TestClass { TestName = "HGB", Result = (testResult.Next(750, 1650) / 100), MinReferenceRange = 11.5f, MaxReferenceRange = 15.3f, Units = "g/dL"},
                new TestClass { TestName = "HCT", Result = (testResult.Next(2520, 4710) / 100), MinReferenceRange = 35.2f, MaxReferenceRange = 45.1f, Units = "%" },
                new TestClass { TestName = "PLT", Result = (testResult.Next(900, 6010) / 10), MinReferenceRange = 160.0f, MaxReferenceRange = 401.0f, Units = "x 10^3/uL" }

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