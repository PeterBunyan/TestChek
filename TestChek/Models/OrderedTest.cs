using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestChek.Models
{
    public class OrderedTest
    {
        //primary key representing patient ID/medRecNumber
        public string Id { get; set; }

        //ordered test that has not yet been completed
        public string test { get; set; }
    }
}