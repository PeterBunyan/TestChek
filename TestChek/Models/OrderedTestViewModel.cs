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
<<<<<<< HEAD
        //[Key]
        //[NotMapped]
        [Key]
        public int Id { get; set; }
        //[NotMapped]
        //public int OTVMId { get; set; }

        public List<AspNetUser> patientList { get; set; }
        //public List<OrderedTest> pendingTests { get; set; }
        //public List<IEnumerable<TestClass>> TestMenuList { get; set; }
        //public List<List<TestClass>> TestMenuList { get; set; }
        //public TestMenu testMenu { get; set; }
        public List<TestPanel> testPanelList { get; set; }

        public OrderedTest orderedTest { get; set; }

        public string CBC { get; set; }

        public string BMP { get; set; }

=======
        //Primary Key, though model does not currently exist in DB
        [Key]
        public int Id { get; set; }
        //Stores a list of AspNetUser, a list of "patients" that registered for site access
        public List<AspNetUser> patientList { get; set; }
        //Test in Drop-down menu of view
        public string CBC { get; set; }
        //Test in Drop-down menu of view
        public string BMP { get; set; }
        //Test in Drop-down menu of view
>>>>>>> API
        public string UA { get; set; }
    }
}