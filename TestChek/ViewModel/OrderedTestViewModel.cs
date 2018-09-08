using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestChek.Models;

namespace TestChek.ViewModel
{
    public class OrderedTestViewModel
    {
    

            //public int OTVMId { get; set; }
            public List<AspNetUser> patientList { get; set; }
            //public List<OrderedTest> pendingTests { get; set; }
            //public List<IEnumerable<TestClass>> TestMenuList { get; set; }
            public List<List<TestClass>> TestMenuList { get; set; }
            //public TestMenu testMenu { get; set; }
            public List<TestPanel> testPanelList { get; set; }

            public OrderedTest orderedTest { get; set; }

    }
}
