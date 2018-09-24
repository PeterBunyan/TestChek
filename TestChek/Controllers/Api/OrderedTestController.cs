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

        // PUT: api/OrderedTest/5 - removes tests from pending database table after tests have been completed
        [HttpPut]
        public void ClearOrderedTests(OrderedTest orderedTest)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var orderedTestInDB = _context.OrderedTests.Where(c => c.Id == orderedTest.Id);

            if (orderedTestInDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            foreach (var pendingTest in orderedTestInDB)
            {
                _context.OrderedTests.Remove(pendingTest);
            }
            _context.SaveChanges();
        }

        // DELETE: api/OrderedTest/5
        [HttpDelete]
        public void DeleteOrderedTest(OrderedTest orderedTest)
        {
            var orderedTestInDB = _context.OrderedTests.FirstOrDefault(c => c.Id == orderedTest.Id && c.test == orderedTest.test);

            if (orderedTestInDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.OrderedTests.Remove(orderedTestInDB);
            _context.SaveChanges();
        }
    }
}
