using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestChek.Models
{
    public class OrderedTestViewModel
    {
        //[Key]
        //[NotMapped]
        [Key]
        public int Id { get; set; }
        //[NotMapped]
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