using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestChek.Models;
using System.Data.Entity;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using TestChek.Controllers;


namespace TestChek.Controllers.Api
{
    public class OrderedTestController : ApiController
    {

        private ModelDBContext _context = new ModelDBContext();



        // GET: api/OrderedTest - returns pending tests for ALL patients
        public IEnumerable<OrderedTest> GetAllOrderedTests()
        {
            return _context.OrderedTests.ToList();
        }

        // GET: api/OrderedTest/5 - returns pending tests for SINGLE patient
        public IEnumerable<OrderedTest> GetOrderedTest(string id)
        {
            var orderedTest = _context.OrderedTests.Where(c => c.Id == id);
            
            if (orderedTest == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return orderedTest;
        }

        // POST: api/OrderedTest - create OrderedTest object and add to DB
        [HttpPost]
        public void Post(JObject objData)

        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            OrderedTest orderedTest = new OrderedTest();
            dynamic jsonObjData = objData;

            orderedTest = JsonConvert.DeserializeObject<OrderedTest>(jsonObjData.ToString());

            _context.OrderedTests.Add(orderedTest);
            _context.SaveChanges();
        }

        // POST: api/OrderedTest/5 - pulls pending test list from DB to run
        [HttpPost]
        public void RunTests(string id)

        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);


            var orderedTestList = _context.OrderedTests.Where(c => c.Id == id);

            if (orderedTestList == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            var aspNetUser = _context.AspNetUsers.SingleOrDefault(c => c.Id == id);

            if (aspNetUser == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            PatientRecord record = new PatientRecord();
            TestPanel pendingList = new TestPanel();
            List<List<TestClass>> builtList = new List<List<TestClass>>();

            //For each test panel name (order) in orderedTestList, add the associated panel to builtList
            foreach (var order in orderedTestList)
            {
                pendingList.testSelector(order.test);
                builtList.Add(pendingList.panelTestList);               
            }

            record.myTestResults = builtList;

            //gets provider currently logged in
            var orderingProvider = _context.AspNetUsers.Single(c => c.UserName == User.Identity.Name);

            //For each test panel
            foreach (var panel in record.myTestResults)
            {
                //create a PatientRecord object for each test in the test panel and save to DB
                foreach (var test in panel)
                {
                    record.firstName = aspNetUser.FirstName;
                    record.lastName = aspNetUser.LastName;
                    record.medRecNumber = aspNetUser.Id;
                    record.orderingProvider = orderingProvider.LastName + ", " + orderingProvider.FirstName;
                    record.timeofTest = DateTime.Now.ToString("g");
                    record.testName = test.testName;
                    record.result = test.result;
                    record.minReferenceRange = test.minReferenceRange;
                    record.maxReferenceRange = test.maxReferenceRange;
                    record.units = test.units;
                    _context.PatientRecords.Add(record);
                    _context.SaveChanges();
                }
            }
        }



        // PUT: api/OrderedTest/5 - removes tests from 'OrderedTests' database table after tests have been completed
        [HttpPut]
        public void ClearOrderedTests(string id)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            //Find records for one patient
            var orderedTestsInDB = _context.OrderedTests.Where(c => c.Id == id);

            if (orderedTestsInDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            //Delete each record
            foreach (var pendingTest in orderedTestsInDB)
            {
                _context.OrderedTests.Remove(pendingTest);
            }
            _context.SaveChanges();
        }


        // DELETE: api/OrderedTest/ - delete specific instance of OrderedTest in DB
        [HttpDelete]
        public void DeleteOrderedTest(JObject objData)
        {
            OrderedTest orderedTest = new OrderedTest();
            dynamic jsonObjData = objData;

            //converts json object to OrderedTest object
            orderedTest = JsonConvert.DeserializeObject<OrderedTest>(jsonObjData.ToString());

            var orderedTestInDB = _context.OrderedTests.First(c => c.Id == orderedTest.Id && c.test == orderedTest.test);
            
            //if test exists in DB
            if (orderedTestInDB == null)
            {

                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            //delete test
            _context.OrderedTests.Remove(orderedTestInDB);
            _context.SaveChanges();
        }
    }
}
