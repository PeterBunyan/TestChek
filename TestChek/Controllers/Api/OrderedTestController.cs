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
        //public JsonResult GetOrderedTest(string id)
        {
            var orderedTest = _context.OrderedTests.Where(c => c.Id == id);

            if (orderedTest == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return orderedTest;
            //return Json(orderedTest.ToList(), JsonRequestBehavior.AllowGet);
        }

        // POST: api/OrderedTest
        //public void CreateOrderedTest([FromBody] OrderedTest passedFromAjax)
        //public void CreateOrderedTest([FromBody] string Id, string test)
        //public void CreateOrderedTest([FromBody] dynamic jsonFromAjax)

        [HttpPost]
        public void Post(JObject objData)

        //public void CreateOrderedTest(OrderedTestViewModel viewModel)
        //public void CreateOrderedTest(OrderedTest orderedTest)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            OrderedTest orderedTest = new OrderedTest();
            dynamic jsonObjData = objData;

            JObject orderId = jsonObjData.Id;
            JObject orderTestName = jsonObjData.test;

            //orderedTest = JsonConvert.DeserializeObject<OrderedTest>(jsonObjData.ToString());

            
            //var o = (Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(jsonObjData);
            //o.Property("Id").Remove();
            //o.Property("test").Remove();






            var jObjOrderId = orderId.ToString();
            var jObjOrderTestName = orderTestName.ToString();
            orderedTest.Id = jObjOrderId;
            orderedTest.test = jObjOrderTestName;

            //orderedTest.Id = o.ToString(); ;
            //orderedTest.test = o.ToString();


            //var testpanel = viewModel.testPanelList;
            //foreach (var panel in testpanel)
            //{
            //    orderedTest.test = panel.panelName;
            //}


            //var IdFromAjax = jsonFromAjax.Id;
            //var testFromAjax = jsonFromAjax.test;
            //OrderedTest orderedTest = new OrderedTest();
            //orderedTest.Id = IdFromAjax.Id;
            //orderedTest.test = testFromAjax.test;
            //orderedTest.Id = Id;
            //orderedTest.test = test;

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
