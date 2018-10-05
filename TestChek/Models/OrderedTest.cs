using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestChek.Models
{
    public class OrderedTest
    {
        //Primary key for OrderedTests DB table
        [Key]
        public int OrderNumber { get; set; }

        //primary key representing patient ID/medRecNumber
        public string Id { get; set; }

        //ordered test that has not yet been completed (still pending)
        public string test { get; set; }

        public OrderedTest()
        {
        }
    }

    
}