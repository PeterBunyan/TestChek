using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestChek.Models;
using System.Data.Entity;

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

        // POST: api/OrderedTest
        [HttpPost]
        public OrderedTest CreateOrderedTest([FromBody]string id, string test)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            OrderedTest orderedTest = new OrderedTest
            {
                Id = id,
                test = test
            };

            _context.OrderedTests.Add(orderedTest);
            _context.SaveChanges();

            return orderedTest;
        }

        // PUT: api/OrderedTest/5 - removes tests from pending database table after tests have been completed
        [HttpPut]
        public void ClearOrderedTests(string id)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var orderedTestInDB = _context.OrderedTests.Where(c => c.Id == id);

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
        public void DeleteOrderedTest(string id, string test)
        {
            var orderedTestInDB = _context.OrderedTests.FirstOrDefault(c => c.Id == id && c.test == test);

            if (orderedTestInDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.OrderedTests.Remove(orderedTestInDB);
            _context.SaveChanges();
        }
    }
}
