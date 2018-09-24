using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestChek.Models
{
    public class OrderedTest
    {
        [Key]
        public int OrderNumber { get; set; }

        //primary key representing patient ID/medRecNumber
        public string Id { get; set; }

        //ordered test that has not yet been completed
        public string test { get; set; } // have this field just return the TestPanel Test name as a string?

        public OrderedTest()
        {
        }
    }

    
}